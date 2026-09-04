using B__Lyer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SOLVIX
{
    /*
     * منطق فورم الملاحظات:
     * - يتعامل مع البحث والإضافة والتعديل والحذف والتثبيت والفلترة.
     * - لا يتعامل مع SQLite مباشرة، بل يمر عبر B__Lyer.
     * - يحدّث الواجهة بعد كل عملية ناجحة ويحافظ على الملاحظة المحددة.
     * - يتعامل مع حالات عدم وجود بيانات ورسائل الخطأ بشكل واضح.
     */
    public partial class Notes : Form
    {
        private readonly NotesBusinessLayer _business = new NotesBusinessLayer();

        private int _selectedNoteId;
        private bool _editMode;
        private string _activeFilter = "All";
        private bool _loading;

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

            categoryCombo.DrawItem += CategoryCombo_DrawItem;
            categoryCombo.DropDown += (_, _) => StyleCategoryDropDown();

            contentEditBox.Resize += (_, _) => UpdateEditorLayout();
            editorContainer.Resize += (_, _) => UpdateEditorLayout();
            notesScrollPanel.Resize += (_, _) => ResizeVisibleCards();
        }

        private void Notes_Load(object? sender, EventArgs e)
        {
            ConfigureInitialState();
            LoadAll();
        }

        private void Notes_Resize(object? sender, EventArgs e)
        {
            ResizeVisibleCards();
            UpdateEditorLayout();
        }

        private void ConfigureInitialState()
        {
            SetEditMode(false);

            filterButton.Text = "الكل";

            categoryCombo.SelectedIndex = -1;
            categoryCombo.Text = string.Empty;

            searchBox.Text = string.Empty;

            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

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
                List<NoteItem> notes = _business.GetNotes(
                    NormalizeSearch(searchBox.Text),
                    _activeFilter);

                notesScrollPanel.SuspendLayout();

                try
                {
                    notesScrollPanel.Controls.Clear();
                    notesScrollPanel.AutoScroll = true;

                    int top = 8;

                    foreach (NoteItem note in notes)
                    {
                        Control card = CreateNoteCard(note);

                        card.Left = 8;
                        card.Top = top;

                        notesScrollPanel.Controls.Add(card);

                        top += card.Height + 10;
                    }

                    listCountLabel.Text =
                        notes.Count == 1
                            ? "ملاحظة واحدة"
                            : $"{notes.Count} ملاحظات";

                    if (notes.Count == 0)
                    {
                        ShowEmptyState();
                        ClearSelection();
                    }
                    else
                    {
                        NoteItem? selected = null;

                        if (_selectedNoteId > 0)
                        {
                            selected = _business.GetNote(_selectedNoteId);

                            if (selected != null &&
                                !ContainsNote(notes, selected.Id))
                            {
                                selected = null;
                            }
                        }

                        if (selected != null)
                        {
                            DisplayNote(selected);
                        }
                        else
                        {
                            SelectNote(notes[0].Id, refreshList: false);
                        }
                    }
                }
                finally
                {
                    notesScrollPanel.ResumeLayout(true);
                    ResizeVisibleCards();
                }
            }
            catch (Exception ex)
            {
                ShowError(
                    "تعذر تحميل الملاحظات.",
                    ex);
            }
        }

        private static bool ContainsNote(
            List<NoteItem> notes,
            int id)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Id == id)
                    return true;
            }

            return false;
        }

        private void ShowEmptyState()
        {
            Label empty = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 160,
                Padding = new Padding(20),
                Margin = new Padding(8),
                Text =
                    "لا توجد ملاحظات مطابقة.\r\n\r\n" +
                    "أضف ملاحظة جديدة أو غيّر البحث والفلترة.",
                ForeColor = Solvix.UI.AppTheme.MutedText,
                BackColor = Color.Transparent,
                Font = Solvix.UI.AppTheme.Regular(10F),
                TextAlign = ContentAlignment.MiddleCenter,
                RightToLeft = RightToLeft.Yes
            };

            notesScrollPanel.Controls.Add(empty);
        }

        private Control CreateNoteCard(NoteItem note)
        {
            bool selected = note.Id == _selectedNoteId;

            var card = new Solvix.UI.RoundedPanel
            {
                Height = 118,
                Width = Math.Max(
                    220,
                    notesScrollPanel.ClientSize.Width - 20),
                FillColor = selected
                    ? Solvix.UI.AppTheme.CardSelected
                    : Solvix.UI.AppTheme.Card,
                BorderColor = selected
                    ? Solvix.UI.AppTheme.Primary
                    : Solvix.UI.AppTheme.Border,
                BorderThickness = 1,
                CornerRadius = 12,
                Padding = new Padding(15, 13, 15, 12),
                RightToLeft = RightToLeft.Yes,
                Cursor = Cursors.Hand,
                TabStop = false
            };

            var accent = new Panel
            {
                Dock = DockStyle.Right,
                Width = 4,
                BackColor = selected
                    ? Solvix.UI.AppTheme.Primary
                    : Color.FromArgb(47, 68, 94)
            };

            var title = new Label
            {
                Dock = DockStyle.Top,
                Height = 28,
                BackColor = Color.Transparent,
                ForeColor = Solvix.UI.AppTheme.Text,
                Font = Solvix.UI.AppTheme.Bold(10F),
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
                Height = 37,
                BackColor = Color.Transparent,
                ForeColor = Solvix.UI.AppTheme.MutedText,
                Font = Solvix.UI.AppTheme.Regular(8.5F),
                Text = BuildPreview(note.Content),
                TextAlign = ContentAlignment.TopRight,
                RightToLeft = RightToLeft.Yes,
                AutoEllipsis = true,
                Cursor = Cursors.Hand
            };

            string meta = note.Category ?? "عام";

            if (note.IsPinned)
                meta = "مثبت • " + meta;

            if (note.IsImportant)
                meta = "مهم • " + meta;

            meta += " • " + FormatDate(note.UpdatedAt);

            var footer = new Label
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                ForeColor = selected
                    ? Solvix.UI.AppTheme.PrimaryHover
                    : Solvix.UI.AppTheme.MutedText,
                Font = Solvix.UI.AppTheme.Regular(8F),
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

        private void ResizeVisibleCards()
        {
            if (!IsHandleCreated || notesScrollPanel == null)
                return;

            int width = Math.Max(
                220,
                notesScrollPanel.ClientSize.Width
                - notesScrollPanel.Padding.Left
                - notesScrollPanel.Padding.Right
                - 4);

            foreach (Control control in notesScrollPanel.Controls)
            {
                if (control is Solvix.UI.RoundedPanel)
                    control.Width = width;
            }
        }

        private void SelectNote(
            int id,
            bool refreshList = true)
        {
            try
            {
                NoteItem? note = _business.GetNote(id);

                if (note == null)
                {
                    ClearSelection();
                    return;
                }

                _selectedNoteId = id;

                SetEditMode(false);
                DisplayNote(note);

                if (refreshList)
                    RefreshListOnly();
            }
            catch (Exception ex)
            {
                ShowError(
                    "تعذر فتح الملاحظة.",
                    ex);
            }
        }

        private void RefreshListOnly()
        {
            try
            {
                List<NoteItem> notes = _business.GetNotes(
                    NormalizeSearch(searchBox.Text),
                    _activeFilter);

                notesScrollPanel.SuspendLayout();

                try
                {
                    notesScrollPanel.Controls.Clear();

                    int top = 8;

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
                    ResizeVisibleCards();
                }
            }
            catch (Exception ex)
            {
                ShowError(
                    "تعذر تحديث قائمة الملاحظات.",
                    ex);
            }
        }

        private void DisplayNote(NoteItem note)
        {
            detailTitleLabel.Text =
                string.IsNullOrWhiteSpace(note.Title)
                    ? "بدون عنوان"
                    : note.Title;

            detailDateLabel.Text =
                $"{FormatDate(note.CreatedAt)}  •  آخر تحديث {FormatDate(note.UpdatedAt)}";

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

        private void AddNoteButton_Click(
            object? sender,
            EventArgs e)
        {
            _selectedNoteId = 0;

            titleEditBox.Text = string.Empty;
            contentEditBox.Clear();

            categoryCombo.SelectedIndex = -1;
            categoryCombo.Text = string.Empty;

            importantCheckBox.Checked = false;
            pinnedCheckBox.Checked = false;

            editorHeading.Text =
                "إضافة ملاحظة جديدة";

            SetEditMode(true);

            titleEditBox.Focus();
        }

        private void EditButton_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedNoteId <= 0)
                return;

            try
            {
                NoteItem? note =
                    _business.GetNote(_selectedNoteId);

                if (note == null)
                {
                    ShowError("الملاحظة غير موجودة.");
                    return;
                }

                titleEditBox.Text = note.Title;
                contentEditBox.Text = note.Content;

                categoryCombo.Text =
                    note.Category ?? string.Empty;

                importantCheckBox.Checked =
                    note.IsImportant;

                pinnedCheckBox.Checked =
                    note.IsPinned;

                editorHeading.Text =
                    "تعديل الملاحظة";

                SetEditMode(true);

                titleEditBox.Focus();
            }
            catch (Exception ex)
            {
                ShowError(
                    "تعذر فتح محرر الملاحظة.",
                    ex);
            }
        }

        private void SaveButton_Click(
            object? sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                titleEditBox.Text))
            {
                ShowError(
                    "اكتب عنوان الملاحظة أولًا.");

                titleEditBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(
                contentEditBox.Text))
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
                        titleEditBox.Text,
                        contentEditBox.Text,
                        categoryCombo.Text,
                        importantCheckBox.Checked,
                        pinnedCheckBox.Checked);
                }
                else
                {
                    result = _business.UpdateNote(
                        _selectedNoteId,
                        titleEditBox.Text,
                        contentEditBox.Text,
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

        private void CancelButton_Click(
            object? sender,
            EventArgs e)
        {
            SetEditMode(false);

            if (_selectedNoteId > 0)
            {
                try
                {
                    NoteItem? note =
                        _business.GetNote(_selectedNoteId);

                    if (note != null)
                    {
                        DisplayNote(note);
                        RefreshListOnly();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    ShowError(
                        "تعذر استعادة الملاحظة.",
                        ex);
                }
            }

            ClearSelection();
        }

        private void DeleteButton_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedNoteId <= 0)
                return;

            DialogResult answer = MessageBox.Show(
                this,
                "هل أنت متأكد من حذف هذه الملاحظة؟\r\n" +
                "لا يمكن التراجع عن هذه العملية.",
                "حذف الملاحظة",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                OperationResult result =
                    _business.DeleteNote(
                        _selectedNoteId);

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

        private void PinButton_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedNoteId <= 0)
                return;

            try
            {
                OperationResult result =
                    _business.TogglePinned(
                        _selectedNoteId);

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
                    "حدث خطأ أثناء تغيير حالة التثبيت.",
                    ex);
            }
        }

        private void FilterButton_Click(
            object? sender,
            EventArgs e)
        {
            _activeFilter = _activeFilter switch
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

        private void SearchBox_TextChanged(
            object? sender,
            EventArgs e)
        {
            if (_loading)
                return;

            LoadNotes();
        }

        private void SetEditMode(bool enabled)
        {
            _editMode = enabled;

            displayContainer.Visible = !enabled;
            editorContainer.Visible = enabled;

            noteBadge.Visible = !enabled;
            pinButton.Visible = !enabled;
            editButton.Visible = !enabled;
            deleteButton.Visible = !enabled;

            if (enabled)
            {
                editorContainer.BringToFront();
                UpdateEditorLayout();
            }
        }

        private void ClearSelection()
        {
            _selectedNoteId = 0;

            detailTitleLabel.Text =
                "لا توجد ملاحظة";

            detailDateLabel.Text =
                string.Empty;

            detailContentLabel.Text =
                "اختر ملاحظة من القائمة أو اضغط " +
                "«إضافة ملاحظة» للبدء.";

            categoryValue.Text = "-";
            createdValue.Text = "-";
            updatedValue.Text = "-";

            noteBadge.Text = "ملاحظة";
            noteBadge.Style =
                Solvix.UI.BadgeStyle.Primary;

            pinButton.Text = "⚐";
        }

        private void UpdateEditorLayout()
        {
            if (editorContainer == null ||
                !editorContainer.Visible)
                return;

            int width =
                editorContainer.ClientSize.Width;

            int height =
                editorContainer.ClientSize.Height;

            if (width <= 0 || height <= 0)
                return;

            int padding = 24;
            int footerHeight = 92;

            int titleTop =
                editorHeading.Height + 12;

            titleEditBox.Left = padding;
            titleEditBox.Top = titleTop;

            titleEditBox.Width =
                Math.Max(
                    260,
                    width - padding * 2);

            titleEditBox.Height = 44;

            contentEditBox.Left = padding;

            contentEditBox.Top =
                titleEditBox.Bottom + 14;

            contentEditBox.Width =
                Math.Max(
                    260,
                    width - padding * 2);

            contentEditBox.Height =
                Math.Max(
                    160,
                    height -
                    contentEditBox.Top -
                    footerHeight);

            int bottomY =
                height -
                footerHeight +
                8;

            saveButton.Top = bottomY;
            cancelButton.Top = bottomY;

            saveButton.Left =
                width -
                padding -
                saveButton.Width;

            cancelButton.Left =
                saveButton.Left -
                10 -
                cancelButton.Width;

            categoryCombo.Top =
                bottomY + 1;

            categoryCombo.Left =
                Math.Max(
                    padding,
                    cancelButton.Left -
                    18 -
                    categoryCombo.Width);

            importantCheckBox.Top =
                bottomY + 4;

            importantCheckBox.Left =
                Math.Max(
                    padding,
                    categoryCombo.Left -
                    18 -
                    importantCheckBox.Width);

            pinnedCheckBox.Top =
                bottomY + 4;

            pinnedCheckBox.Left =
                Math.Max(
                    padding,
                    importantCheckBox.Left -
                    12 -
                    pinnedCheckBox.Width);
        }

        private void CategoryCombo_DrawItem(
            object? sender,
            DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            Color backColor =
                (e.State & DrawItemState.Selected) ==
                DrawItemState.Selected
                    ? Solvix.UI.AppTheme.CardSelected
                    : Solvix.UI.AppTheme.SurfaceAlt;

            using var back =
                new SolidBrush(backColor);

            using var text =
                new SolidBrush(
                    Solvix.UI.AppTheme.Text);

            e.Graphics.FillRectangle(
                back,
                e.Bounds);

            string value =
                categoryCombo.Items[e.Index]
                ?.ToString() ?? string.Empty;

            e.Graphics.DrawString(
                value,
                Solvix.UI.AppTheme.Regular(9F),
                text,
                new Rectangle(
                    e.Bounds.X + 8,
                    e.Bounds.Y,
                    e.Bounds.Width - 16,
                    e.Bounds.Height),
                new StringFormat
                {
                    Alignment =
                        StringAlignment.Far,

                    LineAlignment =
                        StringAlignment.Center
                });

            e.DrawFocusRectangle();
        }

        private void StyleCategoryDropDown()
        {
            try
            {
                categoryCombo.BeginUpdate();

                categoryCombo.BackColor =
                    Solvix.UI.AppTheme.SurfaceAlt;

                categoryCombo.ForeColor =
                    Solvix.UI.AppTheme.Text;

                categoryCombo.EndUpdate();
            }
            catch
            {
                // أخطاء التنسيق لا توقف التطبيق.
            }
        }

        private static string NormalizeSearch(
            string? value)
        {
            return value?.Trim() ?? string.Empty;
        }

        private static string BuildPreview(
            string? text)
        {
            string value =
                (text ?? string.Empty)
                .Replace("\r", " ")
                .Replace("\n", " ")
                .Trim();

            if (value.Length == 0)
                return "لا يوجد محتوى";

            return value.Length > 90
                ? value[..90] + "..."
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
    }
}