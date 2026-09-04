using B__Lyer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SOLVIX
{
    /*
     * منطق فورم الملاحظات:
     * - إدارة البحث والفلترة.
     * - إضافة وتعديل وحذف وتثبيت الملاحظات.
     * - لا يتعامل مباشرة مع SQLite.
     * - جميع العمليات تمر عبر B__Lyer.
     * - الواجهة تتبدل بين وضع العرض ووضع التحرير بدون فتح فورم آخر.
     */

    public partial class Notes : Form
    {
        private readonly NotesBusinessLayer _business = new();

        private int _selectedNoteId;
        private bool _editMode;
        private bool _loading;
        private string _activeFilter = "All";

        public Notes()
        {
            InitializeComponent();

            DoubleBuffered = true;
            KeyPreview = true;

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

            notesScrollPanel.Resize += (_, _) => ResizeNoteCards();
        }

        private void Notes_Load(object? sender, EventArgs e)
        {
            SetEditMode(false);
            LoadAll();
        }

        private void Notes_Resize(object? sender, EventArgs e)
        {
            ResizeNoteCards();
        }

        // ============================================================
        // DATA
        // ============================================================

        private void LoadAll()
        {
            if (_loading)
                return;

            _loading = true;

            try
            {
                LoadStatistics();
                LoadNotes();
            }
            finally
            {
                _loading = false;
            }
        }

        private void LoadStatistics()
        {
            try
            {
                var stats = _business.GetStatistics();

                totalCard.Value = stats.Total.ToString();
                importantCard.Value = stats.Important.ToString();
                pinnedCard.Value = stats.Pinned.ToString();
                todayCard.Value = stats.Today.ToString();
            }
            catch (Exception ex)
            {
                ShowError(
                    "تعذر تحميل إحصاءات الملاحظات.",
                    ex);
            }
        }

        private void LoadNotes()
        {
            try
            {
                var notes = _business.GetNotes(
                    NormalizeSearch(searchBox.Text),
                    _activeFilter);

                BuildNotesList(notes);

                listCountLabel.Text = GetNotesCountText(notes.Count);

                if (notes.Count == 0)
                {
                    ClearSelection();
                    ShowEmptyState();
                    return;
                }

                NoteItem? selectedNote = null;

                if (_selectedNoteId > 0)
                {
                    selectedNote = _business.GetNote(_selectedNoteId);

                    if (selectedNote != null &&
                        !ContainsNote(notes, selectedNote.Id))
                    {
                        selectedNote = null;
                    }
                }

                if (selectedNote == null)
                {
                    _selectedNoteId = notes[0].Id;
                    selectedNote = notes[0];
                }

                SetEditMode(false);
                DisplayNote(selectedNote);
            }
            catch (Exception ex)
            {
                ShowError(
                    "تعذر تحميل الملاحظات.",
                    ex);
            }
        }

        private void BuildNotesList(List<NoteItem> notes)
        {
            notesScrollPanel.SuspendLayout();

            try
            {
                notesScrollPanel.Controls.Clear();

                int top = 10;

                foreach (var note in notes)
                {
                    Control card = CreateNoteCard(note);

                    card.Left = 10;
                    card.Top = top;

                    notesScrollPanel.Controls.Add(card);

                    top += card.Height + 10;
                }
            }
            finally
            {
                notesScrollPanel.ResumeLayout(true);
                ResizeNoteCards();
            }
        }

        private void RefreshNotesList()
        {
            try
            {
                var notes = _business.GetNotes(
                    NormalizeSearch(searchBox.Text),
                    _activeFilter);

                BuildNotesList(notes);
                listCountLabel.Text = GetNotesCountText(notes.Count);
            }
            catch (Exception ex)
            {
                ShowError(
                    "تعذر تحديث قائمة الملاحظات.",
                    ex);
            }
        }

        // ============================================================
        // NOTE CARDS
        // ============================================================

        private Control CreateNoteCard(NoteItem note)
        {
            bool selected = note.Id == _selectedNoteId;

            var card = new Solvix.UI.RoundedPanel
            {
                Height = 108,
                FillColor = selected
                    ? Color.FromArgb(24, 55, 90)
                    : Color.FromArgb(13, 27, 44),
                BorderColor = selected
                    ? Solvix.UI.AppTheme.Primary
                    : Color.FromArgb(28, 49, 74),
                BorderThickness = 1,
                CornerRadius = 11,
                Cursor = Cursors.Hand,
                Padding = new Padding(14, 11, 14, 10),
                RightToLeft = RightToLeft.Yes
            };

            var accent = new Panel
            {
                Dock = DockStyle.Right,
                Width = 3,
                BackColor = selected
                    ? Solvix.UI.AppTheme.Primary
                    : Color.FromArgb(37, 59, 84)
            };

            var title = new Label
            {
                Dock = DockStyle.Top,
                Height = 27,
                BackColor = Color.Transparent,
                ForeColor = Solvix.UI.AppTheme.Text,
                Font = Solvix.UI.AppTheme.Bold(9.5F),
                Text = string.IsNullOrWhiteSpace(note.Title)
                    ? "بدون عنوان"
                    : note.Title.Trim(),
                TextAlign = ContentAlignment.MiddleRight,
                RightToLeft = RightToLeft.Yes,
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            var preview = new Label
            {
                Dock = DockStyle.Top,
                Height = 36,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(151, 167, 188),
                Font = Solvix.UI.AppTheme.Regular(8.2F),
                Text = BuildPreview(note.Content),
                TextAlign = ContentAlignment.TopRight,
                RightToLeft = RightToLeft.Yes,
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            string meta = string.IsNullOrWhiteSpace(note.Category)
                ? "عام"
                : note.Category;

            if (note.IsPinned)
                meta = "مثبت  •  " + meta;

            if (note.IsImportant)
                meta = "مهم  •  " + meta;

            meta += "  •  " + FormatDate(note.UpdatedAt);

            var footer = new Label
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                ForeColor = selected
                    ? Solvix.UI.AppTheme.PrimaryHover
                    : Solvix.UI.AppTheme.MutedText,
                Font = Solvix.UI.AppTheme.Regular(7.8F),
                Text = meta,
                TextAlign = ContentAlignment.BottomRight,
                RightToLeft = RightToLeft.Yes,
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            void Select()
            {
                SelectNote(note.Id);
            }

            card.Click += (_, _) => Select();
            title.Click += (_, _) => Select();
            preview.Click += (_, _) => Select();
            footer.Click += (_, _) => Select();

            card.Controls.Add(accent);
            card.Controls.Add(footer);
            card.Controls.Add(preview);
            card.Controls.Add(title);

            return card;
        }

        private void ResizeNoteCards()
        {
            if (notesScrollPanel == null ||
                notesScrollPanel.ClientSize.Width <= 0)
            {
                return;
            }

            int width =
                Math.Max(
                    220,
                    notesScrollPanel.ClientSize.Width -
                    notesScrollPanel.Padding.Left -
                    notesScrollPanel.Padding.Right -
                    4);

            foreach (Control control in notesScrollPanel.Controls)
            {
                if (control is Solvix.UI.RoundedPanel)
                    control.Width = width;
            }
        }

        private void ShowEmptyState()
        {
            var emptyPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 190,
                BackColor = Color.Transparent,
                Padding = new Padding(20)
            };

            var title = new Label
            {
                Dock = DockStyle.Top,
                Height = 38,
                ForeColor = Solvix.UI.AppTheme.Text,
                BackColor = Color.Transparent,
                Font = Solvix.UI.AppTheme.Bold(10F),
                Text = "لا توجد ملاحظات",
                TextAlign = ContentAlignment.BottomCenter,
                RightToLeft = RightToLeft.Yes
            };

            var subtitle = new Label
            {
                Dock = DockStyle.Top,
                Height = 70,
                ForeColor = Solvix.UI.AppTheme.MutedText,
                BackColor = Color.Transparent,
                Font = Solvix.UI.AppTheme.Regular(8.5F),
                Text =
                    "لا توجد ملاحظات مطابقة للبحث أو الفلترة الحالية.\r\n" +
                    "ابدأ بإضافة ملاحظة جديدة.",
                TextAlign = ContentAlignment.MiddleCenter,
                RightToLeft = RightToLeft.Yes
            };

            emptyPanel.Controls.Add(subtitle);
            emptyPanel.Controls.Add(title);

            notesScrollPanel.Controls.Add(emptyPanel);
        }

        // ============================================================
        // SELECTION
        // ============================================================

        private void SelectNote(int id)
        {
            try
            {
                var note = _business.GetNote(id);

                if (note == null)
                {
                    ClearSelection();
                    return;
                }

                _selectedNoteId = id;

                SetEditMode(false);
                DisplayNote(note);
                RefreshNotesList();
            }
            catch (Exception ex)
            {
                ShowError(
                    "تعذر فتح الملاحظة.",
                    ex);
            }
        }

        private void DisplayNote(NoteItem note)
        {
            detailHeaderLabel.Text = "تفاصيل الملاحظة";

            detailTitleLabel.Text =
                string.IsNullOrWhiteSpace(note.Title)
                    ? "بدون عنوان"
                    : note.Title;

            detailDateLabel.Text =
                $"تم الإنشاء {FormatDate(note.CreatedAt)}  •  آخر تحديث {FormatDate(note.UpdatedAt)}";

            detailContentLabel.Text =
                string.IsNullOrWhiteSpace(note.Content)
                    ? "لا يوجد محتوى لهذه الملاحظة."
                    : note.Content;

            categoryValue.Text =
                string.IsNullOrWhiteSpace(note.Category)
                    ? "عام"
                    : note.Category;

            createdValue.Text =
                FormatDate(note.CreatedAt);

            updatedValue.Text =
                FormatDate(note.UpdatedAt);

            noteBadge.Text =
                note.IsImportant
                    ? "مهم"
                    : "ملاحظة";

            noteBadge.Style =
                note.IsImportant
                    ? Solvix.UI.BadgeStyle.Warning
                    : Solvix.UI.BadgeStyle.Primary;

            pinButton.Text =
                note.IsPinned
                    ? "⚑"
                    : "⚐";

            pinButton.ForeColor =
                note.IsPinned
                    ? Solvix.UI.AppTheme.PrimaryHover
                    : Solvix.UI.AppTheme.MutedText;
        }

        private void ClearSelection()
        {
            _selectedNoteId = 0;

            detailHeaderLabel.Text = "تفاصيل الملاحظة";
            detailTitleLabel.Text = "لا توجد ملاحظة";
            detailDateLabel.Text = string.Empty;

            detailContentLabel.Text =
                "اختر ملاحظة من القائمة أو أضف ملاحظة جديدة.";

            categoryValue.Text = "-";
            createdValue.Text = "-";
            updatedValue.Text = "-";

            noteBadge.Text = "ملاحظة";
            noteBadge.Style =
                Solvix.UI.BadgeStyle.Primary;

            pinButton.Text = "⚐";
            pinButton.ForeColor =
                Solvix.UI.AppTheme.MutedText;
        }

        // ============================================================
        // ADD
        // ============================================================

        private void AddNoteButton_Click(
            object? sender,
            EventArgs e)
        {
            _selectedNoteId = 0;

            titleEditBox.Clear();
            contentEditBox.Clear();

            categoryCombo.SelectedIndex = -1;
            categoryCombo.Text = string.Empty;

            importantCheckBox.Checked = false;
            pinnedCheckBox.Checked = false;

            editorHeading.Text =
                "إضافة ملاحظة جديدة";

            editorSubHeading.Text =
                "أنشئ ملاحظتك واختَر التصنيف والحالة قبل الحفظ.";

            SetEditMode(true);

            BeginInvoke(new Action(() =>
            {
                titleEditBox.Focus();
            }));
        }

        // ============================================================
        // EDIT
        // ============================================================

        private void EditButton_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedNoteId <= 0)
                return;

            try
            {
                var note =
                    _business.GetNote(_selectedNoteId);

                if (note == null)
                {
                    ShowError("الملاحظة غير موجودة.");
                    return;
                }

                titleEditBox.Text =
                    note.Title;

                contentEditBox.Text =
                    note.Content;

                categoryCombo.Text =
                    note.Category ?? string.Empty;

                importantCheckBox.Checked =
                    note.IsImportant;

                pinnedCheckBox.Checked =
                    note.IsPinned;

                editorHeading.Text =
                    "تعديل الملاحظة";

                editorSubHeading.Text =
                    "عدّل البيانات المطلوبة ثم احفظ التغييرات.";

                SetEditMode(true);

                BeginInvoke(new Action(() =>
                {
                    titleEditBox.Focus();
                    titleEditBox.SelectAll();
                }));
            }
            catch (Exception ex)
            {
                ShowError(
                    "تعذر فتح محرر الملاحظة.",
                    ex);
            }
        }

        // ============================================================
        // SAVE
        // ============================================================

        private void SaveButton_Click(
            object? sender,
            EventArgs e)
        {
            string title =
                titleEditBox.Text.Trim();

            string content =
                contentEditBox.Text.Trim();

            if (title.Length == 0)
            {
                ShowError(
                    "اكتب عنوان الملاحظة أولًا.");

                titleEditBox.Focus();
                return;
            }

            if (content.Length == 0)
            {
                ShowError(
                    "اكتب محتوى الملاحظة أولًا.");

                contentEditBox.Focus();
                return;
            }

            try
            {
                OperationResult result;

                if (_selectedNoteId <= 0)
                {
                    result = _business.AddNote(
                        title,
                        content,
                        categoryCombo.Text,
                        importantCheckBox.Checked,
                        pinnedCheckBox.Checked);
                }
                else
                {
                    result = _business.UpdateNote(
                        _selectedNoteId,
                        title,
                        content,
                        categoryCombo.Text,
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
                LoadAll();
            }
            catch (Exception ex)
            {
                ShowError(
                    "حدث خطأ أثناء حفظ الملاحظة.",
                    ex);
            }
        }

        // ============================================================
        // CANCEL
        // ============================================================

        private void CancelButton_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedNoteId > 0)
            {
                try
                {
                    var note =
                        _business.GetNote(_selectedNoteId);

                    if (note != null)
                    {
                        SetEditMode(false);
                        DisplayNote(note);
                        RefreshNotesList();
                        return;
                    }
                }
                catch
                {
                }
            }

            SetEditMode(false);
            ClearSelection();
            RefreshNotesList();
        }

        // ============================================================
        // DELETE
        // ============================================================

        private void DeleteButton_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedNoteId <= 0)
                return;

            var confirm =
                MessageBox.Show(
                    this,
                    "هل أنت متأكد من حذف هذه الملاحظة؟\r\nلا يمكن التراجع عن هذه العملية.",
                    "حذف الملاحظة",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var result =
                    _business.DeleteNote(_selectedNoteId);

                if (!result.Succeeded)
                {
                    ShowError(result.Message);
                    return;
                }

                _selectedNoteId = 0;

                SetEditMode(false);
                LoadAll();
            }
            catch (Exception ex)
            {
                ShowError(
                    "حدث خطأ أثناء حذف الملاحظة.",
                    ex);
            }
        }

        // ============================================================
        // PIN
        // ============================================================

        private void PinButton_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedNoteId <= 0)
                return;

            try
            {
                var result =
                    _business.TogglePinned(_selectedNoteId);

                if (!result.Succeeded)
                {
                    ShowError(result.Message);
                    return;
                }

                LoadAll();
            }
            catch (Exception ex)
            {
                ShowError(
                    "تعذر تغيير حالة التثبيت.",
                    ex);
            }
        }

        // ============================================================
        // FILTER
        // ============================================================

        private void FilterButton_Click(
            object? sender,
            EventArgs e)
        {
            _activeFilter =
                _activeFilter switch
                {
                    "All" => "Important",
                    "Important" => "Pinned",
                    _ => "All"
                };

            filterButton.Text =
                _activeFilter switch
                {
                    "Important" => "المهمة",
                    "Pinned" => "المثبتة",
                    _ => "الكل"
                };

            _selectedNoteId = 0;

            LoadNotes();
        }

        // ============================================================
        // SEARCH
        // ============================================================

        private void SearchBox_TextChanged(
            object? sender,
            EventArgs e)
        {
            if (_loading)
                return;

            _selectedNoteId = 0;
            LoadNotes();
        }

        // ============================================================
        // MODE
        // ============================================================

        private void SetEditMode(bool enabled)
        {
            _editMode = enabled;

            SuspendLayout();

            try
            {
                displayContainer.Visible = !enabled;
                editorContainer.Visible = enabled;

                noteBadge.Visible = !enabled;
                pinButton.Visible = !enabled;
                editButton.Visible = !enabled;
                deleteButton.Visible = !enabled;

                if (enabled)
                {
                    detailHeaderLabel.Text =
                        _selectedNoteId > 0
                            ? "تعديل الملاحظة"
                            : "إنشاء ملاحظة";

                    editorContainer.BringToFront();

                    titleEditBox.Focus();
                }
                else
                {
                    detailHeaderLabel.Text =
                        "تفاصيل الملاحظة";

                    displayContainer.BringToFront();
                }
            }
            finally
            {
                ResumeLayout(true);
            }
        }

        // ============================================================
        // HELPERS
        // ============================================================

        private static bool ContainsNote(
            List<NoteItem> notes,
            int id)
        {
            foreach (var note in notes)
            {
                if (note.Id == id)
                    return true;
            }

            return false;
        }

        private static string NormalizeSearch(
            string? value)
        {
            return value?.Trim() ?? string.Empty;
        }

        private static string BuildPreview(
            string? content)
        {
            string value =
                (content ?? string.Empty)
                .Replace("\r", " ")
                .Replace("\n", " ")
                .Trim();

            if (value.Length == 0)
                return "لا يوجد محتوى";

            return value.Length > 86
                ? value[..86] + "..."
                : value;
        }

        private static string FormatDate(
            string? value)
        {
            if (DateTime.TryParse(
                value,
                out DateTime date))
            {
                return date.ToString(
                    "yyyy/MM/dd HH:mm");
            }

            return value ?? string.Empty;
        }

        private static string GetNotesCountText(
            int count)
        {
            return count switch
            {
                0 => "لا توجد ملاحظات",
                1 => "ملاحظة واحدة",
                2 => "ملاحظتان",
                _ => $"{count} ملاحظات"
            };
        }

        private void ShowError(
            string message)
        {
            MessageBox.Show(
                this,
                message,
                "SOLVIX",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void ShowError(
            string message,
            Exception exception)
        {
            MessageBox.Show(
                this,
                $"{message}\r\n\r\n{exception.Message}",
                "SOLVIX",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        // ============================================================
        // DARK EDITOR CONTROLS
        // ============================================================

        private sealed class DarkRichTextBox : RichTextBox
        {
            public DarkRichTextBox()
            {
                BorderStyle = BorderStyle.None;
                BackColor = Solvix.UI.AppTheme.SurfaceAlt;
                ForeColor = Solvix.UI.AppTheme.Text;
                ScrollBars = RichTextBoxScrollBars.Vertical;
                DetectUrls = false;
                WordWrap = true;
                HideSelection = false;
                Font = Solvix.UI.AppTheme.Regular(10F);
                RightToLeft = RightToLeft.Yes;

                SetStyle(
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.AllPaintingInWmPaint,
                    true);
            }

            protected override void OnHandleCreated(EventArgs e)
            {
                base.OnHandleCreated(e);

                BackColor =
                    Solvix.UI.AppTheme.SurfaceAlt;

                ForeColor =
                    Solvix.UI.AppTheme.Text;
            }
        }

        private sealed class DarkCheckBox : CheckBox
        {
            public DarkCheckBox()
            {
                Appearance = Appearance.Normal;
                AutoSize = false;
                FlatStyle = FlatStyle.Flat;
                BackColor = Color.Transparent;
                ForeColor = Solvix.UI.AppTheme.Text;
                Font = Solvix.UI.AppTheme.Regular(8.5F);

                SetStyle(
                    ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw,
                    true);

                Cursor = Cursors.Hand;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.SmoothingMode =
                    SmoothingMode.AntiAlias;

                int boxSize = 18;

                Rectangle box =
                    RightToLeft == RightToLeft.Yes
                        ? new Rectangle(
                            Width - boxSize - 2,
                            (Height - boxSize) / 2,
                            boxSize,
                            boxSize)
                        : new Rectangle(
                            2,
                            (Height - boxSize) / 2,
                            boxSize,
                            boxSize);

                using var back =
                    new SolidBrush(
                        Checked
                            ? Solvix.UI.AppTheme.Primary
                            : Solvix.UI.AppTheme.SurfaceAlt);

                using var border =
                    new Pen(
                        Checked
                            ? Solvix.UI.AppTheme.Primary
                            : Solvix.UI.AppTheme.BorderStrong,
                        1);

                e.Graphics.FillRectangle(
                    back,
                    box);

                e.Graphics.DrawRectangle(
                    border,
                    box);

                if (Checked)
                {
                    using var checkPen =
                        new Pen(
                            Color.White,
                            2.2F);

                    checkPen.StartCap =
                        LineCap.Round;

                    checkPen.EndCap =
                        LineCap.Round;

                    Point p1 =
                        new Point(
                            box.Left + 4,
                            box.Top + 9);

                    Point p2 =
                        new Point(
                            box.Left + 8,
                            box.Top + 13);

                    Point p3 =
                        new Point(
                            box.Left + 15,
                            box.Top + 5);

                    e.Graphics.DrawLines(
                        checkPen,
                        new[]
                        {
                            p1,
                            p2,
                            p3
                        });
                }

                Rectangle textRect =
                    RightToLeft == RightToLeft.Yes
                        ? new Rectangle(
                            0,
                            0,
                            Width - boxSize - 8,
                            Height)
                        : new Rectangle(
                            boxSize + 8,
                            0,
                            Width - boxSize - 8,
                            Height);

                TextRenderer.DrawText(
                    e.Graphics,
                    Text,
                    Font,
                    textRect,
                    ForeColor,
                    RightToLeft == RightToLeft.Yes
                        ? TextFormatFlags.Right |
                          TextFormatFlags.VerticalCenter |
                          TextFormatFlags.NoPrefix
                        : TextFormatFlags.Left |
                          TextFormatFlags.VerticalCenter |
                          TextFormatFlags.NoPrefix);
            }
        }
    }
}