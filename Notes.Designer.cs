namespace SOLVIX
{
    partial class Notes
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel headerAccent;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Panel toolbarPanel;
        private Solvix.UI.SearchBox searchBox;
        private Solvix.UI.CustomButton addNoteButton;

        private System.Windows.Forms.Panel statsPanel;
        private Solvix.UI.StatCard totalCard;
        private Solvix.UI.StatCard importantCard;
        private Solvix.UI.StatCard pinnedCard;
        private Solvix.UI.StatCard todayCard;

        private System.Windows.Forms.Panel contentPanel;
        private Solvix.UI.RoundedPanel listPanel;
        private Solvix.UI.RoundedPanel detailPanel;

        private System.Windows.Forms.Panel listHeaderPanel;
        private System.Windows.Forms.Panel listAccent;
        private System.Windows.Forms.Label listTitleLabel;
        private System.Windows.Forms.Label listCountLabel;
        private Solvix.UI.OutlineButton filterButton;
        private System.Windows.Forms.Panel notesScrollPanel;

        private System.Windows.Forms.Panel detailHeaderPanel;
        private System.Windows.Forms.Panel detailAccent;
        private System.Windows.Forms.Label detailHeaderLabel;
        private Solvix.UI.IconButton pinButton;
        private Solvix.UI.IconButton editButton;
        private Solvix.UI.IconButton deleteButton;
        private Solvix.UI.StatusBadge noteBadge;

        private System.Windows.Forms.Panel displayContainer;
        private System.Windows.Forms.Label detailTitleLabel;
        private System.Windows.Forms.Label detailDateLabel;
        private System.Windows.Forms.Label detailContentLabel;
        private Solvix.UI.RoundedPanel infoPanel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label categoryValue;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label createdValue;
        private System.Windows.Forms.Label updatedLabel;
        private System.Windows.Forms.Label updatedValue;

        private System.Windows.Forms.Panel editorContainer;
        private System.Windows.Forms.Label editorHeading;
        private Solvix.UI.CustomTextBox titleEditBox;
        private System.Windows.Forms.RichTextBox contentEditBox;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.CheckBox importantCheckBox;
        private System.Windows.Forms.CheckBox pinnedCheckBox;
        private Solvix.UI.CustomButton saveButton;
        private Solvix.UI.OutlineButton cancelButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            mainPanel = new System.Windows.Forms.Panel();
            headerPanel = new System.Windows.Forms.Panel();
            headerAccent = new System.Windows.Forms.Panel();
            titleLabel = new System.Windows.Forms.Label();
            subtitleLabel = new System.Windows.Forms.Label();
            toolbarPanel = new System.Windows.Forms.Panel();
            searchBox = new Solvix.UI.SearchBox();
            addNoteButton = new Solvix.UI.CustomButton();

            statsPanel = new System.Windows.Forms.Panel();
            totalCard = new Solvix.UI.StatCard();
            importantCard = new Solvix.UI.StatCard();
            pinnedCard = new Solvix.UI.StatCard();
            todayCard = new Solvix.UI.StatCard();

            contentPanel = new System.Windows.Forms.Panel();
            listPanel = new Solvix.UI.RoundedPanel();
            detailPanel = new Solvix.UI.RoundedPanel();

            listHeaderPanel = new System.Windows.Forms.Panel();
            listAccent = new System.Windows.Forms.Panel();
            listTitleLabel = new System.Windows.Forms.Label();
            listCountLabel = new System.Windows.Forms.Label();
            filterButton = new Solvix.UI.OutlineButton();
            notesScrollPanel = new System.Windows.Forms.Panel();

            detailHeaderPanel = new System.Windows.Forms.Panel();
            detailAccent = new System.Windows.Forms.Panel();
            detailHeaderLabel = new System.Windows.Forms.Label();
            pinButton = new Solvix.UI.IconButton();
            editButton = new Solvix.UI.IconButton();
            deleteButton = new Solvix.UI.IconButton();
            noteBadge = new Solvix.UI.StatusBadge();

            displayContainer = new System.Windows.Forms.Panel();
            detailTitleLabel = new System.Windows.Forms.Label();
            detailDateLabel = new System.Windows.Forms.Label();
            detailContentLabel = new System.Windows.Forms.Label();
            infoPanel = new Solvix.UI.RoundedPanel();
            categoryLabel = new System.Windows.Forms.Label();
            categoryValue = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            createdValue = new System.Windows.Forms.Label();
            updatedLabel = new System.Windows.Forms.Label();
            updatedValue = new System.Windows.Forms.Label();

            editorContainer = new System.Windows.Forms.Panel();
            editorHeading = new System.Windows.Forms.Label();
            titleEditBox = new Solvix.UI.CustomTextBox();
            contentEditBox = new System.Windows.Forms.RichTextBox();
            categoryCombo = new System.Windows.Forms.ComboBox();
            importantCheckBox = new System.Windows.Forms.CheckBox();
            pinnedCheckBox = new System.Windows.Forms.CheckBox();
            saveButton = new Solvix.UI.CustomButton();
            cancelButton = new Solvix.UI.OutlineButton();

            SuspendLayout();

            // Main
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Solvix.UI.AppTheme.Background;
            mainPanel.Padding = new Padding(28, 22, 28, 24);
            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(statsPanel);
            mainPanel.Controls.Add(toolbarPanel);
            mainPanel.Controls.Add(headerPanel);

            // Header
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 78;
            headerPanel.BackColor = Color.Transparent;

            headerAccent.BackColor = Solvix.UI.AppTheme.Primary;
            headerAccent.Location = new Point(0, 2);
            headerAccent.Size = new Size(4, 60);

            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(18, 0);
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Solvix.UI.AppTheme.Text;
            titleLabel.Text = "الملاحظات";
            titleLabel.RightToLeft = RightToLeft.Yes;

            subtitleLabel.AutoSize = true;
            subtitleLabel.Location = new Point(20, 43);
            subtitleLabel.Font = Solvix.UI.AppTheme.Regular(9.5F);
            subtitleLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            subtitleLabel.Text = "إدارة الملاحظات ومتابعتها من مكان واحد.";
            subtitleLabel.RightToLeft = RightToLeft.Yes;

            // Toolbar
            toolbarPanel.Dock = DockStyle.Top;
            toolbarPanel.Height = 62;
            toolbarPanel.BackColor = Color.Transparent;

            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBox.Size = new Size(390, 44);
            searchBox.Location = new Point(0, 8);
            searchBox.PlaceholderText = "ابحث في الملاحظات...";
            searchBox.RightToLeft = RightToLeft.Yes;

            addNoteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addNoteButton.Size = new Size(170, 44);
            addNoteButton.Location = new Point(0, 8);
            addNoteButton.Text = "إضافة ملاحظة";

            toolbarPanel.Controls.Add(addNoteButton);
            toolbarPanel.Controls.Add(searchBox);

            toolbarPanel.Resize += (_, _) =>
            {
                int right = toolbarPanel.ClientSize.Width;
                addNoteButton.Left = right - addNoteButton.Width;
                searchBox.Left = addNoteButton.Left - searchBox.Width - 14;
            };

            // Stats
            statsPanel.Dock = DockStyle.Top;
            statsPanel.Height = 104;
            statsPanel.BackColor = Color.Transparent;

            ConfigureStat(totalCard, "إجمالي الملاحظات", "0", "جميع الملاحظات الحالية", Solvix.UI.AppTheme.Primary, 0);
            ConfigureStat(importantCard, "ملاحظات مهمة", "0", "تحتاج انتباهك", Solvix.UI.AppTheme.PrimaryHover, 1);
            ConfigureStat(pinnedCard, "المثبتة", "0", "تظهر في الأعلى", Solvix.UI.AppTheme.Primary, 2);
            ConfigureStat(todayCard, "ملاحظات اليوم", "0", "تم تعديلها أو إضافتها اليوم", Solvix.UI.AppTheme.Warning, 3);

            statsPanel.Controls.Add(todayCard);
            statsPanel.Controls.Add(pinnedCard);
            statsPanel.Controls.Add(importantCard);
            statsPanel.Controls.Add(totalCard);

            statsPanel.Resize += (_, _) =>
            {
                int width = statsPanel.ClientSize.Width;
                int gap = 14;
                int cardWidth = Math.Max(180, (width - gap * 3) / 4);

                totalCard.Width = cardWidth;
                importantCard.Width = cardWidth;
                pinnedCard.Width = cardWidth;
                todayCard.Width = cardWidth;

                totalCard.Left = 0;
                importantCard.Left = cardWidth + gap;
                pinnedCard.Left = (cardWidth + gap) * 2;
                todayCard.Left = (cardWidth + gap) * 3;
            };

            // Content
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = Color.Transparent;
            contentPanel.Padding = new Padding(0, 8, 0, 0);

            // List
            listPanel.Dock = DockStyle.Left;
            listPanel.Width = 500;
            listPanel.FillColor = Color.FromArgb(10, 19, 31);
            listPanel.BorderColor = Solvix.UI.AppTheme.Border;
            listPanel.BorderThickness = 1;
            listPanel.CornerRadius = 15;

            listHeaderPanel.Dock = DockStyle.Top;
            listHeaderPanel.Height = 76;
            listHeaderPanel.BackColor = Color.FromArgb(13, 27, 46);

            listAccent.Dock = DockStyle.Top;
            listAccent.Height = 3;
            listAccent.BackColor = Solvix.UI.AppTheme.Primary;

            listTitleLabel.AutoSize = true;
            listTitleLabel.Location = new Point(22, 15);
            listTitleLabel.Font = Solvix.UI.AppTheme.Bold(11F);
            listTitleLabel.ForeColor = Solvix.UI.AppTheme.Text;
            listTitleLabel.Text = "قائمة الملاحظات";
            listTitleLabel.RightToLeft = RightToLeft.Yes;

            listCountLabel.AutoSize = true;
            listCountLabel.Location = new Point(22, 44);
            listCountLabel.Font = Solvix.UI.AppTheme.Regular(8.5F);
            listCountLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            listCountLabel.Text = "0 ملاحظة";
            listCountLabel.RightToLeft = RightToLeft.Yes;

            filterButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterButton.Size = new Size(92, 38);
            filterButton.Location = new Point(390, 17);
            filterButton.Text = "الكل";

            listHeaderPanel.Controls.Add(filterButton);
            listHeaderPanel.Controls.Add(listCountLabel);
            listHeaderPanel.Controls.Add(listTitleLabel);
            listHeaderPanel.Controls.Add(listAccent);

            notesScrollPanel.Dock = DockStyle.Fill;
            notesScrollPanel.BackColor = Color.FromArgb(7, 14, 24);
            notesScrollPanel.AutoScroll = true;
            notesScrollPanel.HorizontalScroll.Enabled = false;
            notesScrollPanel.HorizontalScroll.Visible = false;
            notesScrollPanel.VerticalScroll.Visible = true;
            notesScrollPanel.Padding = new Padding(12);
            notesScrollPanel.RightToLeft = RightToLeft.No;

            listPanel.Controls.Add(notesScrollPanel);
            listPanel.Controls.Add(listHeaderPanel);

            // Details
            detailPanel.Dock = DockStyle.Fill;
            detailPanel.FillColor = Color.FromArgb(14, 24, 39);
            detailPanel.BorderColor = Solvix.UI.AppTheme.Border;
            detailPanel.BorderThickness = 1;
            detailPanel.CornerRadius = 15;

            detailHeaderPanel.Dock = DockStyle.Top;
            detailHeaderPanel.Height = 68;
            detailHeaderPanel.BackColor = Color.FromArgb(13, 27, 46);

            detailAccent.Dock = DockStyle.Top;
            detailAccent.Height = 3;
            detailAccent.BackColor = Solvix.UI.AppTheme.Primary;

            detailHeaderLabel.AutoSize = true;
            detailHeaderLabel.Location = new Point(24, 22);
            detailHeaderLabel.Font = Solvix.UI.AppTheme.Bold(10.5F);
            detailHeaderLabel.ForeColor = Color.FromArgb(227, 235, 246);
            detailHeaderLabel.Text = "تفاصيل الملاحظة";
            detailHeaderLabel.RightToLeft = RightToLeft.Yes;

            noteBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            noteBadge.Size = new Size(72, 28);
            noteBadge.Style = Solvix.UI.BadgeStyle.Primary;
            noteBadge.Text = "ملاحظة";

            pinButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pinButton.Size = new Size(40, 40);
            pinButton.Text = "⚐";

            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editButton.Size = new Size(40, 40);
            editButton.Text = "✎";

            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Size = new Size(40, 40);
            deleteButton.Text = "⌫";

            detailHeaderPanel.Controls.Add(deleteButton);
            detailHeaderPanel.Controls.Add(editButton);
            detailHeaderPanel.Controls.Add(pinButton);
            detailHeaderPanel.Controls.Add(noteBadge);
            detailHeaderPanel.Controls.Add(detailHeaderLabel);
            detailHeaderPanel.Controls.Add(detailAccent);

            detailHeaderPanel.Resize += (_, _) =>
            {
                int right = detailHeaderPanel.ClientSize.Width;
                deleteButton.Left = right - deleteButton.Width - 18;
                editButton.Left = deleteButton.Left - editButton.Width - 8;
                pinButton.Left = editButton.Left - pinButton.Width - 8;
                noteBadge.Left = pinButton.Left - noteBadge.Width - 12;
            };

            // Display
            displayContainer.Dock = DockStyle.Fill;
            displayContainer.BackColor = Color.Transparent;

            detailTitleLabel.Dock = DockStyle.Top;
            detailTitleLabel.Height = 76;
            detailTitleLabel.Padding = new Padding(26, 12, 26, 0);
            detailTitleLabel.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            detailTitleLabel.ForeColor = Solvix.UI.AppTheme.Text;
            detailTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            detailTitleLabel.RightToLeft = RightToLeft.Yes;

            detailDateLabel.Dock = DockStyle.Top;
            detailDateLabel.Height = 34;
            detailDateLabel.Padding = new Padding(26, 0, 26, 0);
            detailDateLabel.Font = Solvix.UI.AppTheme.Regular(8.5F);
            detailDateLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            detailDateLabel.TextAlign = ContentAlignment.MiddleRight;
            detailDateLabel.RightToLeft = RightToLeft.Yes;

            detailContentLabel.Dock = DockStyle.Fill;
            detailContentLabel.Padding = new Padding(26, 18, 26, 10);
            detailContentLabel.Font = Solvix.UI.AppTheme.Regular(10F);
            detailContentLabel.ForeColor = Color.FromArgb(213, 222, 234);
            detailContentLabel.TextAlign = ContentAlignment.TopRight;
            detailContentLabel.RightToLeft = RightToLeft.Yes;

            infoPanel.Dock = DockStyle.Top;
            infoPanel.Height = 132;
            infoPanel.Padding = new Padding(18);
            infoPanel.FillColor = Color.FromArgb(18, 38, 63);
            infoPanel.BorderColor = Color.FromArgb(39, 77, 121);
            infoPanel.BorderThickness = 1;
            infoPanel.CornerRadius = 12;

            ConfigureInfo(categoryLabel, categoryValue, "التصنيف", "-", 260);
            ConfigureInfo(createdLabel, createdValue, "تاريخ الإنشاء", "-", 135);
            ConfigureInfo(updatedLabel, updatedValue, "آخر تحديث", "-", 18);

            infoPanel.Controls.Add(updatedValue);
            infoPanel.Controls.Add(updatedLabel);
            infoPanel.Controls.Add(createdValue);
            infoPanel.Controls.Add(createdLabel);
            infoPanel.Controls.Add(categoryValue);
            infoPanel.Controls.Add(categoryLabel);

            displayContainer.Controls.Add(infoPanel);
            displayContainer.Controls.Add(detailContentLabel);
            displayContainer.Controls.Add(detailDateLabel);
            displayContainer.Controls.Add(detailTitleLabel);

            // Editor
            editorContainer.Dock = DockStyle.Fill;
            editorContainer.BackColor = Color.Transparent;
            editorContainer.Padding = new Padding(24);

            editorHeading.Dock = DockStyle.Top;
            editorHeading.Height = 42;
            editorHeading.Font = Solvix.UI.AppTheme.Bold(15F);
            editorHeading.ForeColor = Solvix.UI.AppTheme.Text;
            editorHeading.Text = "محرر الملاحظة";
            editorHeading.TextAlign = ContentAlignment.MiddleRight;

            titleEditBox.Dock = DockStyle.Top;
            titleEditBox.Height = 44;
            titleEditBox.PlaceholderText = "عنوان الملاحظة";
            titleEditBox.RightToLeft = RightToLeft.Yes;

            contentEditBox.Dock = DockStyle.Top;
            contentEditBox.Height = 0;
            contentEditBox.BackColor = Solvix.UI.AppTheme.SurfaceAlt;
            contentEditBox.ForeColor = Solvix.UI.AppTheme.Text;
            contentEditBox.BorderStyle = BorderStyle.FixedSingle;
            contentEditBox.Font = Solvix.UI.AppTheme.Regular(10F);
            contentEditBox.RightToLeft = RightToLeft.Yes;
            contentEditBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            contentEditBox.Margin = new Padding(0, 12, 0, 12);

            categoryCombo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            categoryCombo.Size = new Size(240, 38);
            categoryCombo.DropDownStyle = ComboBoxStyle.DropDown;
            categoryCombo.BackColor = Solvix.UI.AppTheme.SurfaceAlt;
            categoryCombo.ForeColor = Solvix.UI.AppTheme.Text;
            categoryCombo.Font = Solvix.UI.AppTheme.Regular(9F);
            categoryCombo.RightToLeft = RightToLeft.Yes;
            categoryCombo.Items.AddRange(new object[]
            {
                "عام", "مشروع", "اجتماع", "مهمة", "فكرة", "تطوير"
            });

            importantCheckBox.Dock = DockStyle.Top;
            importantCheckBox.Height = 34;
            importantCheckBox.Text = "ملاحظة مهمة";
            importantCheckBox.ForeColor = Solvix.UI.AppTheme.Text;
            importantCheckBox.RightToLeft = RightToLeft.Yes;
            importantCheckBox.TextAlign = ContentAlignment.MiddleRight;

            pinnedCheckBox.Dock = DockStyle.Top;
            pinnedCheckBox.Height = 34;
            pinnedCheckBox.Text = "تثبيت الملاحظة";
            pinnedCheckBox.ForeColor = Solvix.UI.AppTheme.Text;
            pinnedCheckBox.RightToLeft = RightToLeft.Yes;
            pinnedCheckBox.TextAlign = ContentAlignment.MiddleRight;

            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Size = new Size(130, 40);
            saveButton.Location = new Point(130, 0);
            saveButton.Text = "حفظ الملاحظة";

            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Size = new Size(100, 40);
            cancelButton.Location = new Point(20, 0);
            cancelButton.Text = "إلغاء";

            editorContainer.Controls.Add(saveButton);
            editorContainer.Controls.Add(cancelButton);
            editorContainer.Controls.Add(pinnedCheckBox);
            editorContainer.Controls.Add(importantCheckBox);
            editorContainer.Controls.Add(categoryCombo);
            editorContainer.Controls.Add(contentEditBox);
            editorContainer.Controls.Add(titleEditBox);
            editorContainer.Controls.Add(editorHeading);

            editorContainer.Resize += (_, _) =>
            {
                int width = editorContainer.ClientSize.Width;
                int height = editorContainer.ClientSize.Height;
                int y = Math.Max(0, height - 42);
                int right = Math.Max(26, width - 26);

                saveButton.Left = right - saveButton.Width;
                saveButton.Top = y;

                cancelButton.Left = saveButton.Left - cancelButton.Width - 10;
                cancelButton.Top = y;

                importantCheckBox.Left = cancelButton.Left - importantCheckBox.Width - 18;
                importantCheckBox.Top = y + 5;

                pinnedCheckBox.Left = importantCheckBox.Left - pinnedCheckBox.Width - 10;
                pinnedCheckBox.Top = y + 5;

                categoryCombo.Left = Math.Max(26, pinnedCheckBox.Left - categoryCombo.Width - 18);
                categoryCombo.Top = y + 2;
            };

            detailPanel.Controls.Add(editorContainer);
            detailPanel.Controls.Add(displayContainer);
            detailPanel.Controls.Add(detailHeaderPanel);

            contentPanel.Controls.Add(detailPanel);
            contentPanel.Controls.Add(listPanel);

            // Form
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScaleDimensions = new SizeF(96F, 96F);
            BackColor = Solvix.UI.AppTheme.Background;
            ClientSize = new Size(1440, 900);
            Controls.Add(mainPanel);
            Font = Solvix.UI.AppTheme.Regular(9.5F);
            ForeColor = Solvix.UI.AppTheme.Text;
            MinimumSize = new Size(1100, 700);
            Name = "Notes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الملاحظات";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            WindowState = FormWindowState.Maximized;

            mainPanel.Resize += (_, _) =>
            {
                int available = contentPanel.ClientSize.Width;
                if (available > 0)
                    listPanel.Width = Math.Clamp((int)(available * 0.36), 410, 500);

                notesScrollPanel.HorizontalScroll.Enabled = false;
                notesScrollPanel.HorizontalScroll.Visible = false;
            };

            ResumeLayout(false);
        }

        private void ConfigureStat(
            Solvix.UI.StatCard card,
            string title,
            string value,
            string subtitle,
            Color accent,
            int index)
        {
            card.Title = title;
            card.Value = value;
            card.Subtitle = subtitle;
            card.AccentColor = accent;
            card.FillColor = Solvix.UI.AppTheme.Surface;
            card.BorderColor = Solvix.UI.AppTheme.Border;
            card.BorderThickness = 1;
            card.CornerRadius = 13;
            card.Size = new Size(250, 92);
            card.Left = index * 264;
            card.Top = 0;
        }

        private void ConfigureInfo(
            Label caption,
            Label value,
            string captionText,
            string valueText,
            int left)
        {
            caption.AutoSize = true;
            caption.Font = Solvix.UI.AppTheme.Regular(8F);
            caption.ForeColor = Color.FromArgb(118, 146, 181);
            caption.Location = new Point(left, 18);
            caption.Text = captionText;
            caption.RightToLeft = RightToLeft.Yes;

            value.AutoSize = true;
            value.Font = Solvix.UI.AppTheme.Medium(9F);
            value.ForeColor = Color.FromArgb(218, 232, 250);
            value.Location = new Point(left, 44);
            value.Text = valueText;
            value.RightToLeft = RightToLeft.Yes;
        }
    }
}
