using B__Lyer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SOLVIX
{
    public partial class Notes : Form
    {
        private readonly NotesBusinessLayer _business = new();
        private readonly System.Windows.Forms.Timer _searchTimer;
        private List<NoteItem> _visibleNotes = new();
        private int _selectedNoteId;
        private bool _editMode;
        private bool _loading;
        private string _activeFilter = "All";

        public Notes()
        {
            InitializeComponent();

            DoubleBuffered = true;
            KeyPreview = true;
            BackColor = Solvix.UI.AppTheme.Background;
            MinimumSize = new Size(1100, 720);
            WindowState = FormWindowState.Maximized;

            _searchTimer = new System.Windows.Forms.Timer { Interval = 280 };
            _searchTimer.Tick += SearchTimer_Tick;

            Load += Notes_Load;
            Resize += Notes_Resize;

            searchBox.TextChanged += SearchBox_TextChanged;
            addNoteButton.Click += AddNoteButton_Click;
            filterButton.Click += FilterButton_Click;

            pinButton.Click += PinButton_Click;
            editButton.Click += EditButton_Click;
            deleteButton.Click += DeleteButton_Click;

            saveButton.Click += SaveButton_Click;
            cancelButton.Click += CancelButton_Click;
        }

        private void SearchTimer_Tick(object? sender, EventArgs e)
        {
            _searchTimer.Stop();
            if (!_editMode)
                LoadData();
        }

        private void Notes_Load(object? sender, EventArgs e)
        {
            SetEditMode(false);
            LoadData();
            LayoutContent();
            LayoutStats();
        }

        private void Notes_Resize(object? sender, EventArgs e)
        {
            LayoutContent();
            LayoutStats();
            ResizeNoteCards();
        }

        private void LayoutContent()
        {
            if (contentPanel == null || listPanel == null)
                return;

            int width = contentPanel.ClientSize.Width;
            if (width <= 0)
                return;

            listPanel.Width = Math.Clamp((int)(width * 0.38), 360, 455);
        }

        private void LayoutStats()
        {
            if (statsPanel == null || statsPanel.ClientSize.Width <= 0)
                return;

            const int gap = 12;
            int available = statsPanel.ClientSize.Width - (gap * 3);
            int cardWidth = Math.Max(170, available / 4);

            StatCardLayout(totalCard, cardWidth, 3);
            StatCardLayout(importantCard, cardWidth, 2);
            StatCardLayout(pinnedCard, cardWidth, 1);
            StatCardLayout(todayCard, cardWidth, 0);
        }

        private static void StatCardLayout(Solvix.UI.StatCard card, int width, int index)
        {
            const int gap = 12;
            card.Width = width;
            card.Height = 90;
            card.Left = index * (width + gap);
            card.Top = 8;
        }

        private void LoadData()
        {
            if (_loading || IsDisposed)
                return;

            _loading = true;
            try
            {
                NoteStatistics stats = _business.GetStatistics();
                totalCard.Value = stats.Total.ToString();
                importantCard.Value = stats.Important.ToString();
                pinnedCard.Value = stats.Pinned.ToString();
                todayCard.Value = stats.Today.ToString();

                _visibleNotes = _business.GetNotes(
                    NormalizeSearch(searchBox.Text),
                    _activeFilter);

                listCountLabel.Text = GetNotesCountText(_visibleNotes.Count);
                BuildNotesList(_visibleNotes);

                NoteItem? selected = null;
                if (_selectedNoteId > 0)
                {
                    foreach (NoteItem item in _visibleNotes)
                    {
                        if (item.Id == _selectedNoteId)
                        {
                            selected = item;
                            break;
                        }
                    }
                }

                if (selected == null && _visibleNotes.Count > 0)
                {
                    selected = _visibleNotes[0];
                    _selectedNoteId = selected.Id;
                }

                if (selected == null)
                {
                    ClearSelection();
                }
                else if (!_editMode)
                {
                    DisplayNote(selected);
                }

                RefreshActionButtons();
                LayoutStats();
                ResizeNoteCards();
            }
            catch (Exception ex)
            {
                ShowError("تعذر تحميل الملاحظات.", ex);
            }
            finally
            {
                _loading = false;
            }
        }

        private void BuildNotesList(List<NoteItem> notes)
        {
            notesScrollPanel.SuspendLayout();
            try
            {
                notesScrollPanel.Controls.Clear();
                notesScrollPanel.AutoScroll = true;

                if (notes.Count == 0)
                {
                    ShowEmptyState();
                    return;
                }

                int top = 10;
                foreach (NoteItem note in notes)
                {
                    Control card = CreateNoteCard(note);
                    card.Left = 8;
                    card.Top = top;
                    notesScrollPanel.Controls.Add(card);
                    top += card.Height + 10;
                }
            }
            finally
            {
                notesScrollPanel.ResumeLayout(true);
            }
        }

        private Control CreateNoteCard(NoteItem note)
        {
            bool selected = note.Id == _selectedNoteId;

            var card = new Solvix.UI.RoundedPanel
            {
                Height = 106,
                FillColor = selected ? Solvix.UI.AppTheme.CardSelected : Solvix.UI.AppTheme.Surface,
                BorderColor = selected ? Solvix.UI.AppTheme.Primary : Solvix.UI.AppTheme.Border,
                BorderThickness = 1,
                CornerRadius = 11,
                Cursor = Cursors.Hand,
                Padding = new Padding(14, 10, 14, 9),
                RightToLeft = RightToLeft.Yes
            };

            var accent = new Panel
            {
                Dock = DockStyle.Right,
                Width = 3,
                BackColor = selected ? Solvix.UI.AppTheme.Primary : Solvix.UI.AppTheme.Border
            };

            var title = new Label
            {
                Dock = DockStyle.Top,
                Height = 28,
                BackColor = Color.Transparent,
                ForeColor = Solvix.UI.AppTheme.Text,
                Font = Solvix.UI.AppTheme.Bold(9.6F),
                Text = string.IsNullOrWhiteSpace(note.Title) ? "بدون عنوان" : note.Title.Trim(),
                TextAlign = ContentAlignment.MiddleRight,
                RightToLeft = RightToLeft.Yes,
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            var preview = new Label
            {
                Dock = DockStyle.Top,
                Height = 38,
                BackColor = Color.Transparent,
                ForeColor = Solvix.UI.AppTheme.MutedText,
                Font = Solvix.UI.AppTheme.Regular(8.1F),
                Text = BuildPreview(note.Content),
                TextAlign = ContentAlignment.TopRight,
                RightToLeft = RightToLeft.Yes,
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            string meta = string.IsNullOrWhiteSpace(note.Category) ? "عام" : note.Category;
            if (note.IsPinned) meta = "مثبت  •  " + meta;
            if (note.IsImportant) meta = "مهم  •  " + meta;
            meta += "  •  " + FormatDate(note.UpdatedAt);

            var footer = new Label
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                ForeColor = selected ? Solvix.UI.AppTheme.PrimaryHover : Solvix.UI.AppTheme.MutedText,
                Font = Solvix.UI.AppTheme.Regular(7.7F),
                Text = meta,
                TextAlign = ContentAlignment.BottomRight,
                RightToLeft = RightToLeft.Yes,
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            EventHandler select = (_, _) => SelectVisibleNote(note.Id);
            card.Click += select;
            title.Click += select;
            preview.Click += select;
            footer.Click += select;

            card.Controls.Add(accent);
            card.Controls.Add(footer);
            card.Controls.Add(preview);
            card.Controls.Add(title);
            return card;
        }

        private void SelectVisibleNote(int id)
        {
            foreach (NoteItem note in _visibleNotes)
            {
                if (note.Id != id)
                    continue;

                _selectedNoteId = id;
                SetEditMode(false);
                DisplayNote(note);
                BuildNotesList(_visibleNotes);
                RefreshActionButtons();
                ResizeNoteCards();
                return;
            }
        }

        private void ResizeNoteCards()
        {
            if (notesScrollPanel == null || notesScrollPanel.ClientSize.Width <= 0)
                return;

            int width = Math.Max(240,
                notesScrollPanel.ClientSize.Width -
                notesScrollPanel.Padding.Left -
                notesScrollPanel.Padding.Right - 4);

            foreach (Control control in notesScrollPanel.Controls)
            {
                if (control is Solvix.UI.RoundedPanel)
                    control.Width = width;
            }
        }

        private void ShowEmptyState()
        {
            var empty = new Panel
            {
                Dock = DockStyle.Top,
                Height = 220,
                BackColor = Color.Transparent,
                Padding = new Padding(24)
            };

            var title = new Label
            {
                Dock = DockStyle.Top,
                Height = 42,
                BackColor = Color.Transparent,
                ForeColor = Solvix.UI.AppTheme.Text,
                Font = Solvix.UI.AppTheme.Bold(11F),
                Text = "لا توجد ملاحظات",
                TextAlign = ContentAlignment.BottomCenter,
                RightToLeft = RightToLeft.Yes
            };

            var text = new Label
            {
                Dock = DockStyle.Top,
                Height = 72,
                BackColor = Color.Transparent,
                ForeColor = Solvix.UI.AppTheme.MutedText,
                Font = Solvix.UI.AppTheme.Regular(8.5F),
                Text = "ابدأ بإضافة ملاحظة جديدة.",
                TextAlign = ContentAlignment.MiddleCenter,
                RightToLeft = RightToLeft.Yes
            };

            empty.Controls.Add(text);
            empty.Controls.Add(title);
            notesScrollPanel.Controls.Add(empty);
        }

        private void DisplayNote(NoteItem note)
        {
            detailHeaderLabel.Text = "تفاصيل الملاحظة";
            detailTitleLabel.Text = string.IsNullOrWhiteSpace(note.Title) ? "بدون عنوان" : note.Title;
            detailDateLabel.Text = $"تم الإنشاء {FormatDate(note.CreatedAt)}  •  آخر تحديث {FormatDate(note.UpdatedAt)}";
            detailContentLabel.Text = note.Content ?? string.Empty;
            categoryValue.Text = string.IsNullOrWhiteSpace(note.Category) ? "عام" : note.Category;
            createdValue.Text = FormatDate(note.CreatedAt);
            updatedValue.Text = FormatDate(note.UpdatedAt);
            noteBadge.Text = note.IsImportant ? "مهم" : "ملاحظة";
            noteBadge.Style = note.IsImportant ? Solvix.UI.BadgeStyle.Warning : Solvix.UI.BadgeStyle.Primary;
            pinButton.Text = note.IsPinned ? "⚑" : "⚐";
            pinButton.ForeColor = note.IsPinned ? Solvix.UI.AppTheme.PrimaryHover : Solvix.UI.AppTheme.MutedText;
        }

        private void ClearSelection()
        {
            _selectedNoteId = 0;
            detailHeaderLabel.Text = "تفاصيل الملاحظة";
            detailTitleLabel.Text = "";
            detailDateLabel.Text = string.Empty;
            detailContentLabel.Text = "";
            categoryValue.Text = "";
            createdValue.Text = "";
            updatedValue.Text = "";
            noteBadge.Text = "";
            noteBadge.Style = Solvix.UI.BadgeStyle.Primary;
            pinButton.Text = "⚐";
            pinButton.ForeColor = Solvix.UI.AppTheme.MutedText;
            RefreshActionButtons();
        }

        private void SearchBox_TextChanged(object? sender, EventArgs e)
        {
            if (_editMode)
                return;

            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private void FilterButton_Click(object? sender, EventArgs e)
        {
            _activeFilter = _activeFilter switch
            {
                "All" => "Important",
                "Important" => "Pinned",
                _ => "All"
            };

            filterButton.Text = _activeFilter switch
            {
                "Important" => "مهم",
                "Pinned" => "مثبت",
                _ => "الكل"
            };

            _selectedNoteId = 0;
            LoadData();
        }

        private void AddNoteButton_Click(object? sender, EventArgs e)
        {
            _searchTimer.Stop();
            _selectedNoteId = 0;

            titleEditBox.Text = string.Empty;
            contentEditBox.Text = string.Empty;
            categoryCombo.Text = string.Empty;
            categoryCombo.SelectedIndex = -1;
            importantCheckBox.Checked = false;
            pinnedCheckBox.Checked = false;

            editorHeading.Text = "إضافة ملاحظة جديدة";
            editorSubHeading.Text = "";
            SetEditMode(true);
            RefreshActionButtons();
            titleEditBox.Focus();
        }

        private void EditButton_Click(object? sender, EventArgs e)
        {
            if (_selectedNoteId <= 0)
                return;

            NoteItem? note = FindVisibleNote(_selectedNoteId);
            if (note == null)
                return;

            titleEditBox.Text = note.Title;
            contentEditBox.Text = note.Content;
            categoryCombo.Text = note.Category ?? string.Empty;
            importantCheckBox.Checked = note.IsImportant;
            pinnedCheckBox.Checked = note.IsPinned;

            editorHeading.Text = "تعديل الملاحظة";
            editorSubHeading.Text = "";
            SetEditMode(true);
            RefreshActionButtons();
            titleEditBox.Focus();
            titleEditBox.SelectAll();
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            string title = titleEditBox.Text.Trim();
            string content = contentEditBox.Text.Trim();

            if (title.Length == 0)
            {
                ShowError("اكتب عنوان الملاحظة أولًا.");
                titleEditBox.Focus();
                return;
            }

            if (content.Length == 0)
            {
                ShowError("اكتب محتوى الملاحظة أولًا.");
                contentEditBox.Focus();
                return;
            }

            OperationResult result;
            string? category = string.IsNullOrWhiteSpace(categoryCombo.Text)
                ? null
                : categoryCombo.Text.Trim();

            if (_selectedNoteId > 0)
            {
                result = _business.UpdateNote(
                    _selectedNoteId,
                    title,
                    content,
                    category,
                    importantCheckBox.Checked,
                    pinnedCheckBox.Checked);
            }
            else
            {
                result = _business.AddNote(
                    title,
                    content,
                    category,
                    importantCheckBox.Checked,
                    pinnedCheckBox.Checked);
            }

            if (!result.Succeeded)
            {
                ShowError(result.Message);
                return;
            }

            _selectedNoteId = result.Id;
            SetEditMode(false);
            LoadData();
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            SetEditMode(false);

            if (_selectedNoteId > 0)
            {
                NoteItem? note = FindVisibleNote(_selectedNoteId);
                if (note != null)
                    DisplayNote(note);
                else
                    LoadData();
            }
            else
            {
                LoadData();
            }

            RefreshActionButtons();
        }

        private void PinButton_Click(object? sender, EventArgs e)
        {
            if (_selectedNoteId <= 0)
                return;

            OperationResult result = _business.TogglePinned(_selectedNoteId);
            if (!result.Succeeded)
            {
                ShowError(result.Message);
                return;
            }

            LoadData();
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            if (_selectedNoteId <= 0)
                return;

            DialogResult answer = MessageBox.Show(
                this,
                "هل تريد حذف الملاحظة المحددة؟\nلا يمكن التراجع عن هذه العملية.",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (answer != DialogResult.Yes)
                return;

            OperationResult result = _business.DeleteNote(_selectedNoteId);
            if (!result.Succeeded)
            {
                ShowError(result.Message);
                return;
            }

            _selectedNoteId = 0;
            LoadData();
        }

        private void SetEditMode(bool value)
        {
            _editMode = value;
            displayContainer.Visible = !value;
            editorContainer.Visible = value;
            RefreshActionButtons();
        }

        private void RefreshActionButtons()
        {
            bool hasSelection = _selectedNoteId > 0 && !_editMode;
            pinButton.Enabled = hasSelection;
            editButton.Enabled = hasSelection;
            deleteButton.Enabled = hasSelection;
        }

        private NoteItem? FindVisibleNote(int id)
        {
            foreach (NoteItem note in _visibleNotes)
            {
                if (note.Id == id)
                    return note;
            }
            return null;
        }

        private static string NormalizeSearch(string? text)
        {
            return string.IsNullOrWhiteSpace(text)
                ? string.Empty
                : text.Trim();
        }

        private static string BuildPreview(string? text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "بدون محتوى";

            string value = text.Replace("\r", " ").Replace("\n", " ").Trim();
            return value.Length <= 88 ? value : value.Substring(0, 88) + "…";
        }

        private static string GetNotesCountText(int count)
        {
            return count switch
            {
                0 => "لا توجد ملاحظات",
                1 => "ملاحظة واحدة",
                2 => "ملاحظتان",
                _ => $"{count} ملاحظات"
            };
        }

        private static string FormatDate(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "-";

            if (DateTime.TryParse(value, out DateTime date))
                return date.ToString("yyyy/MM/dd HH:mm");

            return value;
        }

        private void ShowError(string message, Exception? ex = null)
        {
            string text = message;
#if DEBUG
            if (ex != null)
                text += "\n\n" + ex.Message;
#endif
            MessageBox.Show(
                this,
                text,
                "الملاحظات",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Dispose();
            base.OnFormClosed(e);
        }

        internal sealed class DarkRichTextBox : RichTextBox
        {
            public DarkRichTextBox()
            {
                BorderStyle = BorderStyle.None;
                BackColor = Solvix.UI.AppTheme.SurfaceAlt;
                ForeColor = Solvix.UI.AppTheme.Text;
                Font = Solvix.UI.AppTheme.Regular(9.2F);
                DetectUrls = false;
                ScrollBars = RichTextBoxScrollBars.Vertical;
                AcceptsTab = true;
                Multiline = true;
                WordWrap = true;
                RightToLeft = RightToLeft.Yes;
            }
        }

        internal sealed class DarkCheckBox : CheckBox
        {
            public DarkCheckBox()
            {
                AutoSize = false;
                Height = 34;
                FlatStyle = FlatStyle.Flat;
                FlatAppearance.BorderSize = 0;
                BackColor = Color.Transparent;
                ForeColor = Solvix.UI.AppTheme.Text;
                Font = Solvix.UI.AppTheme.Regular(8.7F);
                RightToLeft = RightToLeft.Yes;
                TextAlign = ContentAlignment.MiddleRight;
                Padding = new Padding(0, 0, 8, 0);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.Clear(Parent?.BackColor ?? Solvix.UI.AppTheme.Background);

                int size = 17;
                int x = Width - size - 3;
                int y = (Height - size) / 2;
                Rectangle box = new Rectangle(x, y, size, size);

                using var fill = new SolidBrush(
                    Checked ? Solvix.UI.AppTheme.Primary : Solvix.UI.AppTheme.SurfaceAlt);
                using var pen = new Pen(
                    Checked ? Solvix.UI.AppTheme.Primary : Solvix.UI.AppTheme.BorderStrong, 1);

                e.Graphics.FillRectangle(fill, box);
                e.Graphics.DrawRectangle(pen, box);

                if (Checked)
                {
                    using var checkPen = new Pen(Color.White, 2.1F)
                    {
                        StartCap = LineCap.Round,
                        EndCap = LineCap.Round,
                        LineJoin = LineJoin.Round
                    };

                    e.Graphics.DrawLines(checkPen, new[]
                    {
                        new Point(x + 4, y + 8),
                        new Point(x + 7, y + 12),
                        new Point(x + 14, y + 4)
                    });
                }

                Rectangle textRect = new Rectangle(0, 0, x - 8, Height);
                TextRenderer.DrawText(
                    e.Graphics,
                    Text ?? string.Empty,
                    Font,
                    textRect,
                    Enabled ? ForeColor : Solvix.UI.AppTheme.MutedText,
                    TextFormatFlags.Right |
                    TextFormatFlags.VerticalCenter |
                    TextFormatFlags.EndEllipsis);
            }
        }

        internal sealed class DarkComboBox : ComboBox
        {
            public DarkComboBox()
            {
                DrawMode = DrawMode.OwnerDrawFixed;
                DrawItem += DrawItemHandler;
                BackColor = Solvix.UI.AppTheme.SurfaceAlt;
                ForeColor = Solvix.UI.AppTheme.Text;
                FlatStyle = FlatStyle.Flat;
                Font = Solvix.UI.AppTheme.Regular(8.8F);
                ItemHeight = 30;
                DropDownStyle = ComboBoxStyle.DropDown;
                RightToLeft = RightToLeft.Yes;
            }

            private void DrawItemHandler(object? sender, DrawItemEventArgs e)
            {
                if (e.Index < 0)
                {
                    using var empty = new SolidBrush(BackColor);
                    e.Graphics.FillRectangle(empty, e.Bounds);
                    return;
                }

                bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                Color background = selected
                    ? Solvix.UI.AppTheme.CardSelected
                    : Solvix.UI.AppTheme.SurfaceAlt;

                using var brush = new SolidBrush(background);
                e.Graphics.FillRectangle(brush, e.Bounds);

                using var textBrush = new SolidBrush(ForeColor);
                e.Graphics.DrawString(
                    Items[e.Index]?.ToString() ?? string.Empty,
                    Font,
                    textBrush,
                    new RectangleF(e.Bounds.X + 8, e.Bounds.Y + 5, e.Bounds.Width - 16, e.Bounds.Height - 10),
                    new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });

                e.DrawFocusRectangle();
            }
        }
    }
}
