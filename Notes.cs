using B__Lyer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SOLVIX
{
    /*
     * منطق فورم الملاحظات:
     * يستقبل أوامر المستخدم مثل البحث والإضافة والتعديل والحذف والتثبيت.
     * يرسل البيانات إلى Business Layer ولا يتعامل مباشرة مع SQLite.
     * يعرض البيانات الراجعة في قائمة الملاحظات ومنطقة التفاصيل.
     */
    public partial class Notes : Form
    {
        private readonly NotesBusinessLayer _business = new NotesBusinessLayer();
        private int _selectedNoteId;
        private bool _editMode;
        private string _activeFilter = "All";

        public Notes()
        {
            InitializeComponent();

            Load += Notes_Load;
            searchBox.TextChanged += SearchBox_TextChanged;
            addNoteButton.Click += AddNoteButton_Click;
            filterButton.Click += FilterButton_Click;
            pinButton.Click += PinButton_Click;
            editButton.Click += EditButton_Click;
            deleteButton.Click += DeleteButton_Click;
            saveButton.Click += SaveButton_Click;
            cancelButton.Click += CancelButton_Click;
        }

        private void Notes_Load(object? sender, EventArgs e)
        {
            SetEditMode(false);
            LoadAll();
        }

        private void LoadAll()
        {
            LoadStatistics();
            LoadNotes();
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
                ShowError("تعذر تحميل الإحصاءات.\r\n" + ex.Message);
            }
        }

        private void LoadNotes()
        {
            try
            {
                List<NoteItem> notes = _business.GetNotes(
                    searchBox.Text,
                    _activeFilter);

                notesScrollPanel.SuspendLayout();
                notesScrollPanel.Controls.Clear();

                int top = 12;

                foreach (NoteItem note in notes)
                {
                    Control card = CreateNoteCard(note);
                    card.Top = top;
                    top += card.Height + 10;
                    notesScrollPanel.Controls.Add(card);
                }

                if (notes.Count == 0)
                {
                    var empty = new Label
                    {
                        AutoSize = false,
                        Width = Math.Max(280, notesScrollPanel.ClientSize.Width - 30),
                        Height = 100,
                        Location = new Point(12, 20),
                        Text = "لا توجد ملاحظات مطابقة.",
                        ForeColor = Solvix.UI.AppTheme.MutedText,
                        Font = Solvix.UI.AppTheme.Medium(10F),
                        TextAlign = ContentAlignment.MiddleCenter,
                        RightToLeft = RightToLeft.Yes
                    };

                    notesScrollPanel.Controls.Add(empty);
                    ClearSelection();
                }
                else
                {
                    if (_selectedNoteId > 0)
                    {
                        var selected = _business.GetNote(_selectedNoteId);

                        if (selected != null)
                            DisplayNote(selected);
                        else
                            SelectNote(notes[0].Id);
                    }
                    else
                    {
                        SelectNote(notes[0].Id);
                    }
                }

                listCountLabel.Text = $"{notes.Count} ملاحظة";
                notesScrollPanel.ResumeLayout(true);
            }
            catch (Exception ex)
            {
                ShowError("تعذر تحميل الملاحظات.\r\n" + ex.Message);
            }
        }

        private Control CreateNoteCard(NoteItem note)
        {
            bool selected = note.Id == _selectedNoteId;

            var card = new Solvix.UI.RoundedPanel
            {
                Width = Math.Max(320, notesScrollPanel.ClientSize.Width - 30),
                Height = 112,
                FillColor = selected
                    ? Solvix.UI.AppTheme.CardSelected
                    : Solvix.UI.AppTheme.Card,
                BorderColor = selected
                    ? Solvix.UI.AppTheme.Primary
                    : Solvix.UI.AppTheme.Border,
                BorderThickness = 1,
                CornerRadius = 11,
                Padding = new Padding(15),
                RightToLeft = RightToLeft.Yes,
                Cursor = Cursors.Hand
            };

            var accent = new Panel
            {
                Dock = DockStyle.Right,
                Width = 4,
                BackColor = selected
                    ? Solvix.UI.AppTheme.Primary
                    : Color.FromArgb(55, 76, 103)
            };

            var title = new Label
            {
                Dock = DockStyle.Top,
                Height = 28,
                BackColor = Color.Transparent,
                ForeColor = Solvix.UI.AppTheme.Text,
                Font = Solvix.UI.AppTheme.Medium(10F),
                Text = note.Title,
                TextAlign = ContentAlignment.MiddleRight,
                RightToLeft = RightToLeft.Yes
            };

            var preview = new Label
            {
                Dock = DockStyle.Top,
                Height = 34,
                BackColor = Color.Transparent,
                ForeColor = Solvix.UI.AppTheme.MutedText,
                Font = Solvix.UI.AppTheme.Regular(8.5F),
                Text = BuildPreview(note.Content),
                TextAlign = ContentAlignment.MiddleRight,
                RightToLeft = RightToLeft.Yes
            };

            string meta = note.IsPinned ? "مثبت • " : "";
            meta += note.IsImportant ? "مهم • " : "";
            meta += note.Category ?? "عام";
            meta += $" • {FormatDate(note.UpdatedAt)}";

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
                RightToLeft = RightToLeft.Yes
            };

            void Select() => SelectNote(note.Id);

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

        private void SelectNote(int id)
        {
            var note = _business.GetNote(id);
            if (note == null) return;

            _selectedNoteId = id;
            SetEditMode(false);
            DisplayNote(note);
            RefreshListOnly();
        }

        private void RefreshListOnly()
        {
            try
            {
                List<NoteItem> notes = _business.GetNotes(
                    searchBox.Text,
                    _activeFilter);

                notesScrollPanel.SuspendLayout();
                notesScrollPanel.Controls.Clear();

                int top = 12;
                foreach (NoteItem note in notes)
                {
                    Control card = CreateNoteCard(note);
                    card.Top = top;
                    top += card.Height + 10;
                    notesScrollPanel.Controls.Add(card);
                }

                notesScrollPanel.ResumeLayout(true);
            }
            catch
            {
            }
        }

        private void DisplayNote(NoteItem note)
        {
            detailTitleLabel.Text = note.Title;
            detailContentLabel.Text = note.Content;
            detailDateLabel.Text =
                $"{FormatDate(note.CreatedAt)} • آخر تحديث {FormatDate(note.UpdatedAt)}";

            categoryValue.Text = note.Category ?? "عام";
            createdValue.Text = FormatDate(note.CreatedAt);
            updatedValue.Text = FormatDate(note.UpdatedAt);

            noteBadge.Text = note.IsImportant ? "مهم" : "ملاحظة";
            noteBadge.Style = note.IsImportant
                ? Solvix.UI.BadgeStyle.Warning
                : Solvix.UI.BadgeStyle.Primary;

            pinButton.Text = note.IsPinned ? "⚑" : "⚐";
            pinButton.ForeColor = note.IsPinned
                ? Solvix.UI.AppTheme.PrimaryHover
                : Solvix.UI.AppTheme.MutedText;
        }

        private void AddNoteButton_Click(object? sender, EventArgs e)
        {
            _selectedNoteId = 0;
            titleEditBox.Text = "";
            contentEditBox.Clear();
            categoryCombo.SelectedIndex = -1;
            categoryCombo.Text = "";
            importantCheckBox.Checked = false;
            pinnedCheckBox.Checked = false;

            editorHeading.Text = "إضافة ملاحظة جديدة";
            SetEditMode(true);
            titleEditBox.Focus();
        }

        private void EditButton_Click(object? sender, EventArgs e)
        {
            if (_selectedNoteId <= 0) return;

            var note = _business.GetNote(_selectedNoteId);
            if (note == null)
            {
                ShowError("الملاحظة غير موجودة.");
                return;
            }

            titleEditBox.Text = note.Title;
            contentEditBox.Text = note.Content;
            categoryCombo.Text = note.Category ?? "";
            importantCheckBox.Checked = note.IsImportant;
            pinnedCheckBox.Checked = note.IsPinned;

            editorHeading.Text = "تعديل الملاحظة";
            SetEditMode(true);
            titleEditBox.Focus();
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            OperationResult result;

            if (_selectedNoteId == 0)
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

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            SetEditMode(false);

            if (_selectedNoteId > 0)
            {
                var note = _business.GetNote(_selectedNoteId);
                if (note != null)
                {
                    DisplayNote(note);
                    return;
                }
            }

            ClearSelection();
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            if (_selectedNoteId <= 0) return;

            if (MessageBox.Show(
                this,
                "هل أنت متأكد من حذف الملاحظة؟",
                "حذف الملاحظة",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            var result = _business.DeleteNote(_selectedNoteId);

            if (!result.Succeeded)
            {
                ShowError(result.Message);
                return;
            }

            _selectedNoteId = 0;
            SetEditMode(false);
            LoadAll();
        }

        private void PinButton_Click(object? sender, EventArgs e)
        {
            if (_selectedNoteId <= 0) return;

            var result = _business.TogglePinned(_selectedNoteId);

            if (!result.Succeeded)
            {
                ShowError(result.Message);
                return;
            }

            LoadAll();
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
                "Important" => "المهمة",
                "Pinned" => "المثبتة",
                _ => "الكل"
            };

            LoadNotes();
        }

        private void SearchBox_TextChanged(object? sender, EventArgs e)
        {
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
        }

        private void ClearSelection()
        {
            _selectedNoteId = 0;
            detailTitleLabel.Text = "لا توجد ملاحظة";
            detailContentLabel.Text =
                "اختر ملاحظة من القائمة أو اضغط «إضافة ملاحظة».";
            detailDateLabel.Text = "";
            categoryValue.Text = "-";
            createdValue.Text = "-";
            updatedValue.Text = "-";
        }

        private static string BuildPreview(string text)
        {
            string value = text.Replace("\r", " ").Replace("\n", " ").Trim();
            return value.Length > 65 ? value[..65] + "..." : value;
        }

        private static string FormatDate(string value)
        {
            return DateTime.TryParse(value, out DateTime date)
                ? date.ToString("yyyy/MM/dd HH:mm")
                : value;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(
                this,
                message,
                "SOLVIX",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
