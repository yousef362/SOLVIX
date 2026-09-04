using System;
using System.Drawing;
using System.Windows.Forms;

namespace SOLVIX
{
    partial class Notes
    {
        private System.ComponentModel.IContainer components = null;

        private Panel mainPanel;
        private Panel headerPanel;
        private Panel headerAccent;
        private Label titleLabel;
        private Label subtitleLabel;

        private Panel toolbarPanel;
        private Solvix.UI.SearchBox searchBox;
        private Solvix.UI.CustomButton addNoteButton;

        private Panel statsPanel;
        private Solvix.UI.StatCard totalCard;
        private Solvix.UI.StatCard importantCard;
        private Solvix.UI.StatCard pinnedCard;
        private Solvix.UI.StatCard todayCard;

        private Panel contentPanel;
        private Solvix.UI.RoundedPanel listPanel;
        private Solvix.UI.RoundedPanel detailPanel;

        private Panel listHeaderPanel;
        private Panel listAccent;
        private Label listTitleLabel;
        private Label listCountLabel;
        private Solvix.UI.OutlineButton filterButton;
        private Panel notesScrollPanel;

        private Panel detailHeaderPanel;
        private Panel detailAccent;
        private Label detailHeaderLabel;
        private Solvix.UI.IconButton pinButton;
        private Solvix.UI.IconButton editButton;
        private Solvix.UI.IconButton deleteButton;
        private Solvix.UI.StatusBadge noteBadge;

        private Panel displayContainer;
        private Label detailTitleLabel;
        private Label detailDateLabel;
        private Label detailContentLabel;
        private Solvix.UI.RoundedPanel infoPanel;
        private Label categoryLabel;
        private Label categoryValue;
        private Label createdLabel;
        private Label createdValue;
        private Label updatedLabel;
        private Label updatedValue;

        private Panel editorContainer;
        private Label editorHeading;
        private Solvix.UI.CustomTextBox titleEditBox;
        private RichTextBox contentEditBox;
        private ComboBox categoryCombo;
        private CheckBox importantCheckBox;
        private CheckBox pinnedCheckBox;
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

            mainPanel = new Panel();
            headerPanel = new Panel();
            headerAccent = new Panel();
            titleLabel = new Label();
            subtitleLabel = new Label();

            toolbarPanel = new Panel();
            searchBox = new Solvix.UI.SearchBox();
            addNoteButton = new Solvix.UI.CustomButton();

            statsPanel = new Panel();
            totalCard = new Solvix.UI.StatCard();
            importantCard = new Solvix.UI.StatCard();
            pinnedCard = new Solvix.UI.StatCard();
            todayCard = new Solvix.UI.StatCard();

            contentPanel = new Panel();
            listPanel = new Solvix.UI.RoundedPanel();
            detailPanel = new Solvix.UI.RoundedPanel();

            listHeaderPanel = new Panel();
            listAccent = new Panel();
            listTitleLabel = new Label();
            listCountLabel = new Label();
            filterButton = new Solvix.UI.OutlineButton();
            notesScrollPanel = new Panel();

            detailHeaderPanel = new Panel();
            detailAccent = new Panel();
            detailHeaderLabel = new Label();
            pinButton = new Solvix.UI.IconButton();
            editButton = new Solvix.UI.IconButton();
            deleteButton = new Solvix.UI.IconButton();
            noteBadge = new Solvix.UI.StatusBadge();

            displayContainer = new Panel();
            detailTitleLabel = new Label();
            detailDateLabel = new Label();
            detailContentLabel = new Label();
            infoPanel = new Solvix.UI.RoundedPanel();
            categoryLabel = new Label();
            categoryValue = new Label();
            createdLabel = new Label();
            createdValue = new Label();
            updatedLabel = new Label();
            updatedValue = new Label();

            editorContainer = new Panel();
            editorHeading = new Label();
            titleEditBox = new Solvix.UI.CustomTextBox();
            contentEditBox = new RichTextBox();
            categoryCombo = new ComboBox();
            importantCheckBox = new CheckBox();
            pinnedCheckBox = new CheckBox();
            saveButton = new Solvix.UI.CustomButton();
            cancelButton = new Solvix.UI.OutlineButton();

            SuspendLayout();

            // =========================================================
            // MAIN
            // =========================================================

            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Solvix.UI.AppTheme.Background;
            mainPanel.Padding = new Padding(28, 24, 28, 24);
            mainPanel.RightToLeft = RightToLeft.Yes;

            // =========================================================
            // HEADER
            // =========================================================

            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 86;
            headerPanel.BackColor = Color.Transparent;

            headerAccent.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            headerAccent.BackColor =
                Solvix.UI.AppTheme.Primary;

            headerAccent.Size =
                new Size(5, 58);

            headerAccent.Location =
                new Point(0, 4);

            titleLabel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            titleLabel.AutoSize = false;

            titleLabel.Size =
                new Size(340, 42);

            titleLabel.Location =
                new Point(34, 0);

            titleLabel.Font =
                Solvix.UI.AppTheme.Bold(23F);

            titleLabel.ForeColor =
                Solvix.UI.AppTheme.Text;

            titleLabel.Text =
                "الملاحظات";

            titleLabel.TextAlign =
                ContentAlignment.MiddleRight;

            titleLabel.RightToLeft =
                RightToLeft.Yes;

            subtitleLabel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            subtitleLabel.AutoSize = false;

            subtitleLabel.Size =
                new Size(470, 28);

            subtitleLabel.Location =
                new Point(34, 44);

            subtitleLabel.Font =
                Solvix.UI.AppTheme.Regular(9F);

            subtitleLabel.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            subtitleLabel.Text =
                "إدارة الملاحظات ومتابعتها من مكان واحد.";

            subtitleLabel.TextAlign =
                ContentAlignment.MiddleRight;

            subtitleLabel.RightToLeft =
                RightToLeft.Yes;

            headerPanel.Controls.Add(headerAccent);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(subtitleLabel);

            // =========================================================
            // TOOLBAR
            // =========================================================

            toolbarPanel.Dock =
                DockStyle.Top;

            toolbarPanel.Height =
                64;

            toolbarPanel.BackColor =
                Color.Transparent;

            searchBox.Size =
                new Size(420, 44);

            searchBox.Location =
                new Point(0, 8);

            searchBox.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            searchBox.PlaceholderText =
                "ابحث في الملاحظات...";

            searchBox.RightToLeft =
                RightToLeft.Yes;

            addNoteButton.Size =
                new Size(188, 44);

            addNoteButton.Location =
                new Point(0, 8);

            addNoteButton.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            addNoteButton.Text =
                "إضافة ملاحظة";

            addNoteButton.Font =
                Solvix.UI.AppTheme.Bold(9.5F);

            toolbarPanel.Controls.Add(addNoteButton);
            toolbarPanel.Controls.Add(searchBox);

            toolbarPanel.Resize += (_, _) =>
            {
                int right =
                    toolbarPanel.ClientSize.Width;

                addNoteButton.Left =
                    right - addNoteButton.Width;

                searchBox.Left =
                    addNoteButton.Left
                    - searchBox.Width
                    - 14;
            };

            // =========================================================
            // STATS
            // =========================================================

            statsPanel.Dock =
                DockStyle.Top;

            statsPanel.Height =
                112;

            statsPanel.BackColor =
                Color.Transparent;

            statsPanel.Padding =
                new Padding(0, 6, 0, 8);

            ConfigureStat(
                totalCard,
                "إجمالي الملاحظات",
                "0",
                "جميع الملاحظات الحالية",
                Solvix.UI.AppTheme.Primary);

            ConfigureStat(
                importantCard,
                "ملاحظات مهمة",
                "0",
                "تحتاج انتباهك",
                Solvix.UI.AppTheme.PrimaryHover);

            ConfigureStat(
                pinnedCard,
                "المثبتة",
                "0",
                "تظهر في الأعلى",
                Solvix.UI.AppTheme.Primary);

            ConfigureStat(
                todayCard,
                "ملاحظات اليوم",
                "0",
                "تم تعديلها أو إضافتها اليوم",
                Solvix.UI.AppTheme.Warning);

            statsPanel.Controls.Add(todayCard);
            statsPanel.Controls.Add(pinnedCard);
            statsPanel.Controls.Add(importantCard);
            statsPanel.Controls.Add(totalCard);

            statsPanel.Resize +=
                (_, _) => LayoutStats();

            // =========================================================
            // CONTENT
            // =========================================================

            contentPanel.Dock =
                DockStyle.Fill;

            contentPanel.BackColor =
                Color.Transparent;

            contentPanel.Padding =
                new Padding(0, 8, 0, 0);

            // =========================================================
            // LIST PANEL
            // =========================================================

            listPanel.Dock =
                DockStyle.Left;

            listPanel.Width =
                430;

            listPanel.FillColor =
                Color.FromArgb(11, 20, 33);

            listPanel.BorderColor =
                Solvix.UI.AppTheme.Border;

            listPanel.BorderThickness =
                1;

            listPanel.CornerRadius =
                15;

            // ---------------------------------------------------------
            // LIST HEADER
            // ---------------------------------------------------------

            listHeaderPanel.Dock =
                DockStyle.Top;

            listHeaderPanel.Height =
                78;

            listHeaderPanel.BackColor =
                Color.FromArgb(14, 27, 45);

            listHeaderPanel.RightToLeft =
                RightToLeft.Yes;

            listAccent.Dock =
                DockStyle.Top;

            listAccent.Height =
                3;

            listAccent.BackColor =
                Solvix.UI.AppTheme.Primary;

            listTitleLabel.AutoSize =
                false;

            listTitleLabel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            listTitleLabel.Size =
                new Size(220, 30);

            listTitleLabel.Location =
                new Point(170, 10);

            listTitleLabel.Font =
                Solvix.UI.AppTheme.Bold(11F);

            listTitleLabel.ForeColor =
                Solvix.UI.AppTheme.Text;

            listTitleLabel.Text =
                "قائمة الملاحظات";

            listTitleLabel.TextAlign =
                ContentAlignment.MiddleRight;

            listTitleLabel.RightToLeft =
                RightToLeft.Yes;

            listCountLabel.AutoSize =
                false;

            listCountLabel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            listCountLabel.Size =
                new Size(220, 24);

            listCountLabel.Location =
                new Point(170, 40);

            listCountLabel.Font =
                Solvix.UI.AppTheme.Regular(8F);

            listCountLabel.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            listCountLabel.Text =
                "0 ملاحظات";

            listCountLabel.TextAlign =
                ContentAlignment.MiddleRight;

            listCountLabel.RightToLeft =
                RightToLeft.Yes;

            filterButton.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left;

            filterButton.Size =
                new Size(88, 38);

            filterButton.Location =
                new Point(18, 20);

            filterButton.Text =
                "الكل";

            filterButton.Font =
                Solvix.UI.AppTheme.Bold(8.5F);

            listHeaderPanel.Controls.Add(filterButton);
            listHeaderPanel.Controls.Add(listCountLabel);
            listHeaderPanel.Controls.Add(listTitleLabel);
            listHeaderPanel.Controls.Add(listAccent);

            listHeaderPanel.Resize += (_, _) =>
            {
                int right =
                    listHeaderPanel.ClientSize.Width;

                listTitleLabel.Left =
                    right - 242;

                listCountLabel.Left =
                    right - 242;

                listTitleLabel.Width =
                    222;

                listCountLabel.Width =
                    222;

                filterButton.Left =
                    18;

                filterButton.Top =
                    20;
            };

            // ---------------------------------------------------------
            // NOTES SCROLL
            // ---------------------------------------------------------

            notesScrollPanel.Dock =
                DockStyle.Fill;

            notesScrollPanel.BackColor =
                Color.FromArgb(7, 14, 24);

            notesScrollPanel.AutoScroll =
                true;

            notesScrollPanel.Padding =
                new Padding(8);

            notesScrollPanel.RightToLeft =
                RightToLeft.No;

            notesScrollPanel.AutoSize =
                false;

            listPanel.Controls.Add(
                notesScrollPanel);

            listPanel.Controls.Add(
                listHeaderPanel);

            // =========================================================
            // DETAIL PANEL
            // =========================================================

            detailPanel.Dock =
                DockStyle.Fill;

            detailPanel.FillColor =
                Color.FromArgb(14, 24, 39);

            detailPanel.BorderColor =
                Solvix.UI.AppTheme.Border;

            detailPanel.BorderThickness =
                1;

            detailPanel.CornerRadius =
                15;

            // =========================================================
            // DETAIL HEADER
            // =========================================================

            detailHeaderPanel.Dock =
                DockStyle.Top;

            detailHeaderPanel.Height =
                70;

            detailHeaderPanel.BackColor =
                Color.FromArgb(14, 27, 45);

            detailHeaderPanel.RightToLeft =
                RightToLeft.Yes;

            detailAccent.Dock =
                DockStyle.Top;

            detailAccent.Height =
                3;

            detailAccent.BackColor =
                Solvix.UI.AppTheme.Primary;

            detailHeaderLabel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            detailHeaderLabel.AutoSize =
                false;

            detailHeaderLabel.Size =
                new Size(210, 38);

            detailHeaderLabel.Location =
                new Point(28, 20);

            detailHeaderLabel.Font =
                Solvix.UI.AppTheme.Bold(10.5F);

            detailHeaderLabel.ForeColor =
                Solvix.UI.AppTheme.Text;

            detailHeaderLabel.Text =
                "تفاصيل الملاحظة";

            detailHeaderLabel.TextAlign =
                ContentAlignment.MiddleRight;

            detailHeaderLabel.RightToLeft =
                RightToLeft.Yes;

            deleteButton.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            deleteButton.Size =
                new Size(40, 40);

            deleteButton.Text =
                "⌫";

            deleteButton.BackColor =
                Color.Transparent;

            editButton.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            editButton.Size =
                new Size(40, 40);

            editButton.Text =
                "✎";

            editButton.BackColor =
                Color.Transparent;

            pinButton.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            pinButton.Size =
                new Size(40, 40);

            pinButton.Text =
                "⚐";

            pinButton.BackColor =
                Color.Transparent;

            noteBadge.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            noteBadge.Size =
                new Size(76, 28);

            noteBadge.Style =
                Solvix.UI.BadgeStyle.Primary;

            noteBadge.Text =
                "ملاحظة";

            detailHeaderPanel.Controls.Add(
                deleteButton);

            detailHeaderPanel.Controls.Add(
                editButton);

            detailHeaderPanel.Controls.Add(
                pinButton);

            detailHeaderPanel.Controls.Add(
                noteBadge);

            detailHeaderPanel.Controls.Add(
                detailHeaderLabel);

            detailHeaderPanel.Controls.Add(
                detailAccent);

            detailHeaderPanel.Resize +=
                (_, _) => LayoutDetailHeader();

            // =========================================================
            // DISPLAY
            // =========================================================

            displayContainer.Dock =
                DockStyle.Fill;

            displayContainer.BackColor =
                Color.Transparent;

            displayContainer.Padding =
                new Padding(0);

            detailTitleLabel.Dock =
                DockStyle.Top;

            detailTitleLabel.Height =
                76;

            detailTitleLabel.Padding =
                new Padding(28, 12, 28, 0);

            detailTitleLabel.Font =
                Solvix.UI.AppTheme.Bold(20F);

            detailTitleLabel.ForeColor =
                Solvix.UI.AppTheme.Text;

            detailTitleLabel.Text =
                "لا توجد ملاحظة";

            detailTitleLabel.TextAlign =
                ContentAlignment.MiddleRight;

            detailTitleLabel.RightToLeft =
                RightToLeft.Yes;

            detailTitleLabel.AutoEllipsis =
                true;

            detailDateLabel.Dock =
                DockStyle.Top;

            detailDateLabel.Height =
                34;

            detailDateLabel.Padding =
                new Padding(28, 0, 28, 0);

            detailDateLabel.Font =
                Solvix.UI.AppTheme.Regular(8.5F);

            detailDateLabel.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            detailDateLabel.TextAlign =
                ContentAlignment.MiddleRight;

            detailDateLabel.RightToLeft =
                RightToLeft.Yes;

            detailDateLabel.AutoEllipsis =
                true;

            // =========================================================
            // INFO PANEL
            // =========================================================

            infoPanel.Dock =
                DockStyle.Bottom;

            infoPanel.Height =
                114;

            infoPanel.Padding =
                new Padding(16);

            infoPanel.FillColor =
                Color.FromArgb(17, 35, 58);

            infoPanel.BorderColor =
                Color.FromArgb(38, 72, 112);

            infoPanel.BorderThickness =
                1;

            infoPanel.CornerRadius =
                12;

            ConfigureInfo(
                categoryLabel,
                categoryValue,
                "التصنيف",
                "-");

            ConfigureInfo(
                createdLabel,
                createdValue,
                "تاريخ الإنشاء",
                "-");

            ConfigureInfo(
                updatedLabel,
                updatedValue,
                "آخر تحديث",
                "-");

            infoPanel.Controls.Add(
                updatedValue);

            infoPanel.Controls.Add(
                updatedLabel);

            infoPanel.Controls.Add(
                createdValue);

            infoPanel.Controls.Add(
                createdLabel);

            infoPanel.Controls.Add(
                categoryValue);

            infoPanel.Controls.Add(
                categoryLabel);

            infoPanel.Resize +=
                (_, _) => LayoutInfoPanel();

            // =========================================================
            // DETAIL CONTENT
            // =========================================================

            detailContentLabel.Dock =
                DockStyle.Fill;

            detailContentLabel.Padding =
                new Padding(28, 22, 28, 18);

            detailContentLabel.Font =
                Solvix.UI.AppTheme.Regular(10F);

            detailContentLabel.ForeColor =
                Color.FromArgb(213, 222, 234);

            detailContentLabel.Text =
                "اختر ملاحظة من القائمة أو اضغط «إضافة ملاحظة» للبدء.";

            detailContentLabel.TextAlign =
                ContentAlignment.TopRight;

            detailContentLabel.RightToLeft =
                RightToLeft.Yes;

            displayContainer.Controls.Add(
                detailContentLabel);

            displayContainer.Controls.Add(
                detailDateLabel);

            displayContainer.Controls.Add(
                detailTitleLabel);

            displayContainer.Controls.Add(
                infoPanel);

            // =========================================================
            // EDITOR
            // =========================================================

            editorContainer.Dock =
                DockStyle.Fill;

            editorContainer.BackColor =
                Color.Transparent;

            editorContainer.Padding =
                new Padding(24);

            editorContainer.Visible =
                false;

            editorHeading.Dock =
                DockStyle.Top;

            editorHeading.Height =
                44;

            editorHeading.Font =
                Solvix.UI.AppTheme.Bold(15F);

            editorHeading.ForeColor =
                Solvix.UI.AppTheme.Text;

            editorHeading.Text =
                "محرر الملاحظة";

            editorHeading.TextAlign =
                ContentAlignment.MiddleRight;

            editorHeading.RightToLeft =
                RightToLeft.Yes;

            // ---------------------------------------------------------
            // TITLE
            // ---------------------------------------------------------

            titleEditBox.Size =
                new Size(400, 44);

            titleEditBox.PlaceholderText =
                "عنوان الملاحظة";

            titleEditBox.RightToLeft =
                RightToLeft.Yes;

            titleEditBox.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // ---------------------------------------------------------
            // CONTENT
            // ---------------------------------------------------------

            contentEditBox.BackColor =
                Solvix.UI.AppTheme.SurfaceAlt;

            contentEditBox.ForeColor =
                Solvix.UI.AppTheme.Text;

            contentEditBox.BorderStyle =
                BorderStyle.FixedSingle;

            contentEditBox.Font =
                Solvix.UI.AppTheme.Regular(10F);

            contentEditBox.RightToLeft =
                RightToLeft.Yes;

            contentEditBox.Multiline =
                true;

            contentEditBox.ScrollBars =
                RichTextBoxScrollBars.Vertical;

            contentEditBox.DetectUrls =
                false;

            contentEditBox.WordWrap =
                true;

            contentEditBox.HideSelection =
                false;

            contentEditBox.AcceptsTab =
                true;

            // ---------------------------------------------------------
            // CATEGORY
            // ---------------------------------------------------------

            categoryCombo.Size =
                new Size(210, 38);

            categoryCombo.DropDownStyle =
                ComboBoxStyle.DropDown;

            categoryCombo.DrawMode =
                DrawMode.OwnerDrawFixed;

            categoryCombo.ItemHeight =
                32;

            categoryCombo.BackColor =
                Solvix.UI.AppTheme.SurfaceAlt;

            categoryCombo.ForeColor =
                Solvix.UI.AppTheme.Text;

            categoryCombo.FlatStyle =
                FlatStyle.Flat;

            categoryCombo.Font =
                Solvix.UI.AppTheme.Regular(9F);

            categoryCombo.RightToLeft =
                RightToLeft.Yes;

            categoryCombo.Items.AddRange(
                new object[]
                {
                    "عام",
                    "مشروع",
                    "اجتماع",
                    "مهمة",
                    "فكرة",
                    "تطوير"
                });

            // ---------------------------------------------------------
            // IMPORTANT
            // ---------------------------------------------------------

            importantCheckBox.AutoSize =
                false;

            importantCheckBox.Size =
                new Size(120, 32);

            importantCheckBox.Text =
                "ملاحظة مهمة";

            importantCheckBox.ForeColor =
                Solvix.UI.AppTheme.Text;

            importantCheckBox.BackColor =
                Color.Transparent;

            importantCheckBox.Font =
                Solvix.UI.AppTheme.Regular(8.5F);

            importantCheckBox.RightToLeft =
                RightToLeft.Yes;

            importantCheckBox.TextAlign =
                ContentAlignment.MiddleRight;

            importantCheckBox.CheckAlign =
                ContentAlignment.MiddleLeft;

            importantCheckBox.FlatStyle =
                FlatStyle.Flat;

            // ---------------------------------------------------------
            // PINNED
            // ---------------------------------------------------------

            pinnedCheckBox.AutoSize =
                false;

            pinnedCheckBox.Size =
                new Size(125, 32);

            pinnedCheckBox.Text =
                "تثبيت الملاحظة";

            pinnedCheckBox.ForeColor =
                Solvix.UI.AppTheme.Text;

            pinnedCheckBox.BackColor =
                Color.Transparent;

            pinnedCheckBox.Font =
                Solvix.UI.AppTheme.Regular(8.5F);

            pinnedCheckBox.RightToLeft =
                RightToLeft.Yes;

            pinnedCheckBox.TextAlign =
                ContentAlignment.MiddleRight;

            pinnedCheckBox.CheckAlign =
                ContentAlignment.MiddleLeft;

            pinnedCheckBox.FlatStyle =
                FlatStyle.Flat;

            // ---------------------------------------------------------
            // SAVE
            // ---------------------------------------------------------

            saveButton.Size =
                new Size(140, 42);

            saveButton.Text =
                "حفظ الملاحظة";

            saveButton.Font =
                Solvix.UI.AppTheme.Bold(9F);

            // ---------------------------------------------------------
            // CANCEL
            // ---------------------------------------------------------

            cancelButton.Size =
                new Size(100, 42);

            cancelButton.Text =
                "إلغاء";

            // ---------------------------------------------------------
            // EDITOR CONTROLS
            // ---------------------------------------------------------

            editorContainer.Controls.Add(
                saveButton);

            editorContainer.Controls.Add(
                cancelButton);

            editorContainer.Controls.Add(
                pinnedCheckBox);

            editorContainer.Controls.Add(
                importantCheckBox);

            editorContainer.Controls.Add(
                categoryCombo);

            editorContainer.Controls.Add(
                contentEditBox);

            editorContainer.Controls.Add(
                titleEditBox);

            editorContainer.Controls.Add(
                editorHeading);

            // =========================================================
            // PANEL HIERARCHY
            // =========================================================

            detailPanel.Controls.Add(
                editorContainer);

            detailPanel.Controls.Add(
                displayContainer);

            detailPanel.Controls.Add(
                detailHeaderPanel);

            contentPanel.Controls.Add(
                detailPanel);

            contentPanel.Controls.Add(
                listPanel);

            mainPanel.Controls.Add(
                contentPanel);

            mainPanel.Controls.Add(
                statsPanel);

            mainPanel.Controls.Add(
                toolbarPanel);

            mainPanel.Controls.Add(
                headerPanel);

            // =========================================================
            // FORM
            // =========================================================

            AutoScaleMode =
                AutoScaleMode.Dpi;

            AutoScaleDimensions =
                new SizeF(96F, 96F);

            BackColor =
                Solvix.UI.AppTheme.Background;

            ClientSize =
                new Size(1440, 900);

            Controls.Add(
                mainPanel);

            Font =
                Solvix.UI.AppTheme.Regular(9.5F);

            ForeColor =
                Solvix.UI.AppTheme.Text;

            MinimumSize =
                new Size(1100, 700);

            Name =
                "Notes";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "الملاحظات";

            RightToLeft =
                RightToLeft.Yes;

            RightToLeftLayout =
                true;

            WindowState =
                FormWindowState.Maximized;

            Shown += (_, _) =>
            {
                LayoutStats();
                LayoutDetailHeader();
                LayoutInfoPanel();
            };

            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfigureStat(
            Solvix.UI.StatCard card,
            string title,
            string value,
            string subtitle,
            Color accent)
        {
            card.Width = 200;
            card.Height = 98;

            card.FillColor =
                Solvix.UI.AppTheme.Surface;

            card.BorderColor =
                Solvix.UI.AppTheme.Border;

            card.BorderThickness = 1;
            card.CornerRadius = 12;

            card.Title = title;
            card.Value = value;
            card.Subtitle = subtitle;
            card.AccentColor = accent;
        }

        private void ConfigureInfo(
            Label label,
            Label value,
            string caption,
            string initialValue)
        {
            label.AutoSize = false;
            label.Size = new Size(160, 22);

            label.Font =
                Solvix.UI.AppTheme.Regular(8F);

            label.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            label.Text =
                caption;

            label.TextAlign =
                ContentAlignment.MiddleRight;

            label.RightToLeft =
                RightToLeft.Yes;

            value.AutoSize = false;
            value.Size = new Size(160, 30);

            value.Font =
                Solvix.UI.AppTheme.Bold(9.5F);

            value.ForeColor =
                Solvix.UI.AppTheme.Text;

            value.Text =
                initialValue;

            value.TextAlign =
                ContentAlignment.MiddleRight;

            value.RightToLeft =
                RightToLeft.Yes;
        }

        private void LayoutStats()
        {
            if (statsPanel == null ||
                statsPanel.ClientSize.Width <= 0)
            {
                return;
            }

            int width =
                statsPanel.ClientSize.Width;

            int gap = 14;

            int cardWidth =
                Math.Max(
                    180,
                    (width - gap * 3) / 4);

            totalCard.Width =
                cardWidth;

            importantCard.Width =
                cardWidth;

            pinnedCard.Width =
                cardWidth;

            todayCard.Width =
                cardWidth;

            totalCard.Left =
                0;

            importantCard.Left =
                cardWidth + gap;

            pinnedCard.Left =
                (cardWidth + gap) * 2;

            todayCard.Left =
                (cardWidth + gap) * 3;

            totalCard.Top = 6;
            importantCard.Top = 6;
            pinnedCard.Top = 6;
            todayCard.Top = 6;
        }

        private void LayoutDetailHeader()
        {
            if (detailHeaderPanel == null)
                return;

            int right =
                detailHeaderPanel.ClientSize.Width;

            deleteButton.Left =
                right -
                deleteButton.Width -
                18;

            deleteButton.Top =
                16;

            editButton.Left =
                deleteButton.Left -
                editButton.Width -
                8;

            editButton.Top =
                16;

            pinButton.Left =
                editButton.Left -
                pinButton.Width -
                8;

            pinButton.Top =
                16;

            noteBadge.Left =
                Math.Max(
                    18,
                    pinButton.Left -
                    noteBadge.Width -
                    12);

            noteBadge.Top =
                22;

            detailHeaderLabel.Left =
                Math.Max(
                    18,
                    noteBadge.Left -
                    245);

            detailHeaderLabel.Top =
                18;

            detailHeaderLabel.Width =
                Math.Max(
                    150,
                    noteBadge.Left -
                    detailHeaderLabel.Left -
                    20);
        }

        private void LayoutInfoPanel()
        {
            if (infoPanel == null ||
                infoPanel.ClientSize.Width <= 0)
            {
                return;
            }

            int width =
                infoPanel.ClientSize.Width;

            int gap = 18;

            int itemWidth =
                Math.Max(
                    130,
                    (width - 32 - gap * 2) / 3);

            categoryLabel.Left =
                width -
                itemWidth -
                16;

            categoryValue.Left =
                categoryLabel.Left;

            createdLabel.Left =
                categoryLabel.Left -
                itemWidth -
                gap;

            createdValue.Left =
                createdLabel.Left;

            updatedLabel.Left =
                createdLabel.Left -
                itemWidth -
                gap;

            updatedValue.Left =
                updatedLabel.Left;

            categoryLabel.Width =
                itemWidth;

            categoryValue.Width =
                itemWidth;

            createdLabel.Width =
                itemWidth;

            createdValue.Width =
                itemWidth;

            updatedLabel.Width =
                itemWidth;

            updatedValue.Width =
                itemWidth;

            categoryLabel.Top = 17;
            categoryValue.Top = 43;

            createdLabel.Top = 17;
            createdValue.Top = 43;

            updatedLabel.Top = 17;
            updatedValue.Top = 43;
        }
    }
}