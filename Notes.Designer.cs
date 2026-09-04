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
        private Label editorSubHeading;
        private Panel titleFrame;
        private Label titleCaption;
        private TextBox titleEditBox;
        private Panel contentFrame;
        private Label contentCaption;
        private Notes.DarkRichTextBox contentEditBox;
        private Panel editorBottomPanel;
        private Label categoryCaption;
        private ComboBox categoryCombo;
        private Notes.DarkCheckBox importantCheckBox;
        private Notes.DarkCheckBox pinnedCheckBox;
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
            editorSubHeading = new Label();
            titleFrame = new Panel();
            titleCaption = new Label();
            titleEditBox = new TextBox();
            contentFrame = new Panel();
            contentCaption = new Label();
            contentEditBox = new Notes.DarkRichTextBox();
            editorBottomPanel = new Panel();
            categoryCaption = new Label();
            categoryCombo = new ComboBox();
            importantCheckBox = new Notes.DarkCheckBox();
            pinnedCheckBox = new Notes.DarkCheckBox();
            saveButton = new Solvix.UI.CustomButton();
            cancelButton = new Solvix.UI.OutlineButton();

            SuspendLayout();

            // MAIN
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Solvix.UI.AppTheme.Background;
            mainPanel.Padding = new Padding(28, 22, 28, 22);
            mainPanel.RightToLeft = RightToLeft.Yes;

            // HEADER
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 78;
            headerPanel.BackColor = Color.Transparent;

            headerAccent.BackColor = Solvix.UI.AppTheme.Primary;
            headerAccent.Size = new Size(4, 54);
            headerAccent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            headerAccent.Top = 2;
            headerAccent.Left = 0;

            titleLabel.AutoSize = false;
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            titleLabel.Width = 370;
            titleLabel.Height = 40;
            titleLabel.Top = 0;
            titleLabel.Left = 18;
            titleLabel.Font = Solvix.UI.AppTheme.Bold(22F);
            titleLabel.ForeColor = Solvix.UI.AppTheme.Text;
            titleLabel.Text = "الملاحظات";
            titleLabel.TextAlign = ContentAlignment.MiddleRight;
            titleLabel.RightToLeft = RightToLeft.Yes;

            subtitleLabel.AutoSize = false;
            subtitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            subtitleLabel.Width = 500;
            subtitleLabel.Height = 26;
            subtitleLabel.Top = 41;
            subtitleLabel.Left = 18;
            subtitleLabel.Font = Solvix.UI.AppTheme.Regular(8.8F);
            subtitleLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            subtitleLabel.Text = "إدارة ملاحظاتك وتنظيم أفكارك من مكان واحد.";
            subtitleLabel.TextAlign = ContentAlignment.MiddleRight;
            subtitleLabel.RightToLeft = RightToLeft.Yes;

            headerPanel.Controls.Add(headerAccent);
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(titleLabel);

            // TOOLBAR
            toolbarPanel.Dock = DockStyle.Top;
            toolbarPanel.Height = 56;
            toolbarPanel.BackColor = Color.Transparent;

            addNoteButton.Size = new Size(182, 42);
            addNoteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addNoteButton.Top = 5;
            addNoteButton.Text = "إضافة ملاحظة";
            addNoteButton.Font = Solvix.UI.AppTheme.Bold(9.5F);

            searchBox.Size = new Size(390, 42);
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBox.Top = 5;
            searchBox.PlaceholderText = "ابحث في الملاحظات...";
            searchBox.RightToLeft = RightToLeft.Yes;

            toolbarPanel.Controls.Add(addNoteButton);
            toolbarPanel.Controls.Add(searchBox);

            // STATS
            statsPanel.Dock = DockStyle.Top;
            statsPanel.Height = 106;
            statsPanel.BackColor = Color.Transparent;

            totalCard.Height = 90;
            totalCard.FillColor = Solvix.UI.AppTheme.Surface;
            totalCard.BorderColor = Solvix.UI.AppTheme.Border;
            totalCard.BorderThickness = 1;
            totalCard.CornerRadius = 12;
            totalCard.Title = "إجمالي الملاحظات";
            totalCard.Value = "0";
            totalCard.Subtitle = "جميع الملاحظات الحالية";
            totalCard.AccentColor = Solvix.UI.AppTheme.Primary;

            importantCard.Height = 90;
            importantCard.FillColor = Solvix.UI.AppTheme.Surface;
            importantCard.BorderColor = Solvix.UI.AppTheme.Border;
            importantCard.BorderThickness = 1;
            importantCard.CornerRadius = 12;
            importantCard.Title = "ملاحظات مهمة";
            importantCard.Value = "0";
            importantCard.Subtitle = "تحتاج انتباهك";
            importantCard.AccentColor = Solvix.UI.AppTheme.Warning;

            pinnedCard.Height = 90;
            pinnedCard.FillColor = Solvix.UI.AppTheme.Surface;
            pinnedCard.BorderColor = Solvix.UI.AppTheme.Border;
            pinnedCard.BorderThickness = 1;
            pinnedCard.CornerRadius = 12;
            pinnedCard.Title = "المثبتة";
            pinnedCard.Value = "0";
            pinnedCard.Subtitle = "تظهر في أعلى القائمة";
            pinnedCard.AccentColor = Solvix.UI.AppTheme.PrimaryHover;

            todayCard.Height = 90;
            todayCard.FillColor = Solvix.UI.AppTheme.Surface;
            todayCard.BorderColor = Solvix.UI.AppTheme.Border;
            todayCard.BorderThickness = 1;
            todayCard.CornerRadius = 12;
            todayCard.Title = "ملاحظات اليوم";
            todayCard.Value = "0";
            todayCard.Subtitle = "أضيفت أو عدلت اليوم";
            todayCard.AccentColor = Solvix.UI.AppTheme.Success;

            statsPanel.Controls.Add(todayCard);
            statsPanel.Controls.Add(pinnedCard);
            statsPanel.Controls.Add(importantCard);
            statsPanel.Controls.Add(totalCard);

            // CONTENT
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = Color.Transparent;
            contentPanel.Padding = new Padding(0, 10, 0, 0);

            // LIST
            listPanel.Dock = DockStyle.Left;
            listPanel.Width = 410;
            listPanel.FillColor = Color.FromArgb(10, 19, 32);
            listPanel.BorderColor = Solvix.UI.AppTheme.Border;
            listPanel.BorderThickness = 1;
            listPanel.CornerRadius = 14;

            listHeaderPanel.Dock = DockStyle.Top;
            listHeaderPanel.Height = 72;
            listHeaderPanel.BackColor = Color.FromArgb(14, 28, 47);
            listHeaderPanel.RightToLeft = RightToLeft.Yes;

            listAccent.Dock = DockStyle.Top;
            listAccent.Height = 3;
            listAccent.BackColor = Solvix.UI.AppTheme.Primary;

            listTitleLabel.AutoSize = false;
            listTitleLabel.Width = 235;
            listTitleLabel.Height = 29;
            listTitleLabel.Top = 8;
            listTitleLabel.Left = 156;
            listTitleLabel.Font = Solvix.UI.AppTheme.Bold(10.8F);
            listTitleLabel.ForeColor = Solvix.UI.AppTheme.Text;
            listTitleLabel.Text = "قائمة الملاحظات";
            listTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            listTitleLabel.RightToLeft = RightToLeft.Yes;

            listCountLabel.AutoSize = false;
            listCountLabel.Width = 235;
            listCountLabel.Height = 21;
            listCountLabel.Top = 38;
            listCountLabel.Left = 156;
            listCountLabel.Font = Solvix.UI.AppTheme.Regular(7.8F);
            listCountLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            listCountLabel.Text = "لا توجد ملاحظات";
            listCountLabel.TextAlign = ContentAlignment.MiddleRight;
            listCountLabel.RightToLeft = RightToLeft.Yes;

            filterButton.Size = new Size(88, 34);
            filterButton.Left = 16;
            filterButton.Top = 20;
            filterButton.Text = "الكل";
            filterButton.Font = Solvix.UI.AppTheme.Bold(8.5F);

            listHeaderPanel.Controls.Add(filterButton);
            listHeaderPanel.Controls.Add(listCountLabel);
            listHeaderPanel.Controls.Add(listTitleLabel);
            listHeaderPanel.Controls.Add(listAccent);

            notesScrollPanel.Dock = DockStyle.Fill;
            notesScrollPanel.BackColor = Color.FromArgb(7, 14, 24);
            notesScrollPanel.AutoScroll = true;
            notesScrollPanel.Padding = new Padding(8, 8, 8, 12);
            notesScrollPanel.RightToLeft = RightToLeft.No;

            listPanel.Controls.Add(notesScrollPanel);
            listPanel.Controls.Add(listHeaderPanel);

            // DETAIL
            detailPanel.Dock = DockStyle.Fill;
            detailPanel.FillColor = Color.FromArgb(13, 24, 39);
            detailPanel.BorderColor = Solvix.UI.AppTheme.Border;
            detailPanel.BorderThickness = 1;
            detailPanel.CornerRadius = 14;

            detailHeaderPanel.Dock = DockStyle.Top;
            detailHeaderPanel.Height = 68;
            detailHeaderPanel.BackColor = Color.FromArgb(14, 28, 47);
            detailHeaderPanel.RightToLeft = RightToLeft.Yes;

            detailAccent.Dock = DockStyle.Top;
            detailAccent.Height = 3;
            detailAccent.BackColor = Solvix.UI.AppTheme.Primary;

            detailHeaderLabel.AutoSize = false;
            detailHeaderLabel.Width = 260;
            detailHeaderLabel.Height = 38;
            detailHeaderLabel.Top = 16;
            detailHeaderLabel.Left = 18;
            detailHeaderLabel.Font = Solvix.UI.AppTheme.Bold(10.5F);
            detailHeaderLabel.ForeColor = Solvix.UI.AppTheme.Text;
            detailHeaderLabel.Text = "تفاصيل الملاحظة";
            detailHeaderLabel.TextAlign = ContentAlignment.MiddleRight;
            detailHeaderLabel.RightToLeft = RightToLeft.Yes;

            deleteButton.Size = new Size(38, 38);
            deleteButton.Text = "⌫";
            deleteButton.BackColor = Color.Transparent;

            editButton.Size = new Size(38, 38);
            editButton.Text = "✎";
            editButton.BackColor = Color.Transparent;

            pinButton.Size = new Size(38, 38);
            pinButton.Text = "⚐";
            pinButton.BackColor = Color.Transparent;

            noteBadge.Size = new Size(76, 28);
            noteBadge.Text = "ملاحظة";
            noteBadge.Style = Solvix.UI.BadgeStyle.Primary;

            detailHeaderPanel.Controls.Add(deleteButton);
            detailHeaderPanel.Controls.Add(editButton);
            detailHeaderPanel.Controls.Add(pinButton);
            detailHeaderPanel.Controls.Add(noteBadge);
            detailHeaderPanel.Controls.Add(detailHeaderLabel);
            detailHeaderPanel.Controls.Add(detailAccent);

            // DISPLAY
            displayContainer.Dock = DockStyle.Fill;
            displayContainer.BackColor = Color.Transparent;

            detailTitleLabel.Dock = DockStyle.Top;
            detailTitleLabel.Height = 70;
            detailTitleLabel.Padding = new Padding(28, 10, 28, 0);
            detailTitleLabel.Font = Solvix.UI.AppTheme.Bold(19F);
            detailTitleLabel.ForeColor = Solvix.UI.AppTheme.Text;
            detailTitleLabel.Text = "لا توجد ملاحظة";
            detailTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            detailTitleLabel.RightToLeft = RightToLeft.Yes;
            detailTitleLabel.AutoEllipsis = true;

            detailDateLabel.Dock = DockStyle.Top;
            detailDateLabel.Height = 30;
            detailDateLabel.Padding = new Padding(28, 0, 28, 0);
            detailDateLabel.Font = Solvix.UI.AppTheme.Regular(8.2F);
            detailDateLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            detailDateLabel.TextAlign = ContentAlignment.MiddleRight;
            detailDateLabel.RightToLeft = RightToLeft.Yes;
            detailDateLabel.AutoEllipsis = true;

            infoPanel.Dock = DockStyle.Bottom;
            infoPanel.Height = 98;
            infoPanel.Padding = new Padding(14);
            infoPanel.FillColor = Color.FromArgb(17, 36, 59);
            infoPanel.BorderColor = Color.FromArgb(39, 76, 116);
            infoPanel.BorderThickness = 1;
            infoPanel.CornerRadius = 11;

            categoryLabel.AutoSize = false;
            categoryLabel.Width = 180;
            categoryLabel.Height = 20;
            categoryLabel.Top = 13;
            categoryLabel.Font = Solvix.UI.AppTheme.Regular(7.8F);
            categoryLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            categoryLabel.Text = "التصنيف";
            categoryLabel.TextAlign = ContentAlignment.MiddleRight;
            categoryLabel.RightToLeft = RightToLeft.Yes;

            categoryValue.AutoSize = false;
            categoryValue.Width = 180;
            categoryValue.Height = 27;
            categoryValue.Top = 38;
            categoryValue.Font = Solvix.UI.AppTheme.Bold(9F);
            categoryValue.ForeColor = Solvix.UI.AppTheme.Text;
            categoryValue.Text = "-";
            categoryValue.TextAlign = ContentAlignment.MiddleRight;
            categoryValue.RightToLeft = RightToLeft.Yes;

            createdLabel.AutoSize = false;
            createdLabel.Width = 180;
            createdLabel.Height = 20;
            createdLabel.Top = 13;
            createdLabel.Font = Solvix.UI.AppTheme.Regular(7.8F);
            createdLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            createdLabel.Text = "تاريخ الإنشاء";
            createdLabel.TextAlign = ContentAlignment.MiddleRight;
            createdLabel.RightToLeft = RightToLeft.Yes;

            createdValue.AutoSize = false;
            createdValue.Width = 180;
            createdValue.Height = 27;
            createdValue.Top = 38;
            createdValue.Font = Solvix.UI.AppTheme.Bold(9F);
            createdValue.ForeColor = Solvix.UI.AppTheme.Text;
            createdValue.Text = "-";
            createdValue.TextAlign = ContentAlignment.MiddleRight;
            createdValue.RightToLeft = RightToLeft.Yes;

            updatedLabel.AutoSize = false;
            updatedLabel.Width = 180;
            updatedLabel.Height = 20;
            updatedLabel.Top = 13;
            updatedLabel.Font = Solvix.UI.AppTheme.Regular(7.8F);
            updatedLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            updatedLabel.Text = "آخر تحديث";
            updatedLabel.TextAlign = ContentAlignment.MiddleRight;
            updatedLabel.RightToLeft = RightToLeft.Yes;

            updatedValue.AutoSize = false;
            updatedValue.Width = 180;
            updatedValue.Height = 27;
            updatedValue.Top = 38;
            updatedValue.Font = Solvix.UI.AppTheme.Bold(9F);
            updatedValue.ForeColor = Solvix.UI.AppTheme.Text;
            updatedValue.Text = "-";
            updatedValue.TextAlign = ContentAlignment.MiddleRight;
            updatedValue.RightToLeft = RightToLeft.Yes;

            infoPanel.Controls.Add(categoryLabel);
            infoPanel.Controls.Add(categoryValue);
            infoPanel.Controls.Add(createdLabel);
            infoPanel.Controls.Add(createdValue);
            infoPanel.Controls.Add(updatedLabel);
            infoPanel.Controls.Add(updatedValue);

            detailContentLabel.Dock = DockStyle.Fill;
            detailContentLabel.Padding = new Padding(28, 20, 28, 18);
            detailContentLabel.Font = Solvix.UI.AppTheme.Regular(10F);
            detailContentLabel.ForeColor = Color.FromArgb(213, 222, 234);
            detailContentLabel.Text = "اختر ملاحظة من القائمة أو أضف ملاحظة جديدة.";
            detailContentLabel.TextAlign = ContentAlignment.TopRight;
            detailContentLabel.RightToLeft = RightToLeft.Yes;
            detailContentLabel.AutoEllipsis = false;

            displayContainer.Controls.Add(detailContentLabel);
            displayContainer.Controls.Add(detailDateLabel);
            displayContainer.Controls.Add(detailTitleLabel);
            displayContainer.Controls.Add(infoPanel);

            // EDITOR
            editorContainer.Dock = DockStyle.Fill;
            editorContainer.BackColor = Color.Transparent;
            editorContainer.Padding = new Padding(24, 20, 24, 18);
            editorContainer.Visible = false;

            editorHeading.Dock = DockStyle.Top;
            editorHeading.Height = 34;
            editorHeading.Font = Solvix.UI.AppTheme.Bold(15F);
            editorHeading.ForeColor = Solvix.UI.AppTheme.Text;
            editorHeading.Text = "إضافة ملاحظة جديدة";
            editorHeading.TextAlign = ContentAlignment.MiddleRight;
            editorHeading.RightToLeft = RightToLeft.Yes;

            editorSubHeading.Dock = DockStyle.Top;
            editorSubHeading.Height = 25;
            editorSubHeading.Font = Solvix.UI.AppTheme.Regular(8F);
            editorSubHeading.ForeColor = Solvix.UI.AppTheme.MutedText;
            editorSubHeading.Text = "أنشئ ملاحظتك واختَر التصنيف والحالة قبل الحفظ.";
            editorSubHeading.TextAlign = ContentAlignment.MiddleRight;
            editorSubHeading.RightToLeft = RightToLeft.Yes;

            titleFrame.Dock = DockStyle.Top;
            titleFrame.Height = 66;
            titleFrame.BackColor = Solvix.UI.AppTheme.SurfaceAlt;
            titleFrame.Padding = new Padding(12, 23, 12, 5);

            titleCaption.Dock = DockStyle.Top;
            titleCaption.Height = 20;
            titleCaption.Font = Solvix.UI.AppTheme.Bold(8.2F);
            titleCaption.ForeColor = Solvix.UI.AppTheme.MutedText;
            titleCaption.Text = "عنوان الملاحظة";
            titleCaption.TextAlign = ContentAlignment.MiddleRight;
            titleCaption.RightToLeft = RightToLeft.Yes;

            titleEditBox.Dock = DockStyle.Fill;
            titleEditBox.BorderStyle = BorderStyle.None;
            titleEditBox.BackColor = Solvix.UI.AppTheme.SurfaceAlt;
            titleEditBox.ForeColor = Solvix.UI.AppTheme.Text;
            titleEditBox.Font = Solvix.UI.AppTheme.Bold(10F);
            titleEditBox.TextAlign = HorizontalAlignment.Right;
            titleEditBox.RightToLeft = RightToLeft.Yes;
            titleEditBox.Margin = new Padding(0);

            titleFrame.Controls.Add(titleEditBox);
            titleFrame.Controls.Add(titleCaption);

            contentFrame.Dock = DockStyle.Fill;
            contentFrame.BackColor = Solvix.UI.AppTheme.SurfaceAlt;
            contentFrame.Padding = new Padding(12, 27, 12, 10);

            contentCaption.Dock = DockStyle.Top;
            contentCaption.Height = 23;
            contentCaption.Font = Solvix.UI.AppTheme.Bold(8.2F);
            contentCaption.ForeColor = Solvix.UI.AppTheme.MutedText;
            contentCaption.Text = "محتوى الملاحظة";
            contentCaption.TextAlign = ContentAlignment.MiddleRight;
            contentCaption.RightToLeft = RightToLeft.Yes;

            contentEditBox.Dock = DockStyle.Fill;
            contentEditBox.BackColor = Solvix.UI.AppTheme.SurfaceAlt;
            contentEditBox.ForeColor = Solvix.UI.AppTheme.Text;
            contentEditBox.Font = Solvix.UI.AppTheme.Regular(10F);
            contentEditBox.BorderStyle = BorderStyle.None;
            contentEditBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            contentEditBox.WordWrap = true;
            contentEditBox.DetectUrls = false;
            contentEditBox.RightToLeft = RightToLeft.Yes;

            contentFrame.Controls.Add(contentEditBox);
            contentFrame.Controls.Add(contentCaption);

            editorBottomPanel.Dock = DockStyle.Bottom;
            editorBottomPanel.Height = 78;
            editorBottomPanel.BackColor = Color.Transparent;

            categoryCaption.AutoSize = false;
            categoryCaption.Width = 90;
            categoryCaption.Height = 20;
            categoryCaption.Top = 4;
            categoryCaption.Left = 8;
            categoryCaption.Font = Solvix.UI.AppTheme.Regular(7.8F);
            categoryCaption.ForeColor = Solvix.UI.AppTheme.MutedText;
            categoryCaption.Text = "التصنيف";
            categoryCaption.TextAlign = ContentAlignment.MiddleRight;
            categoryCaption.RightToLeft = RightToLeft.Yes;

            categoryCombo.Width = 150;
            categoryCombo.Height = 35;
            categoryCombo.Left = 8;
            categoryCombo.Top = 27;
            categoryCombo.DropDownStyle = ComboBoxStyle.DropDown;
            categoryCombo.BackColor = Solvix.UI.AppTheme.SurfaceAlt;
            categoryCombo.ForeColor = Solvix.UI.AppTheme.Text;
            categoryCombo.FlatStyle = FlatStyle.Flat;
            categoryCombo.Font = Solvix.UI.AppTheme.Regular(8.5F);
            categoryCombo.RightToLeft = RightToLeft.Yes;
            categoryCombo.DrawMode = DrawMode.OwnerDrawFixed;
            categoryCombo.ItemHeight = 31;
            categoryCombo.Items.AddRange(new object[]
            {
                "عام",
                "مشروع",
                "اجتماع",
                "مهمة",
                "فكرة",
                "تطوير"
            });

            importantCheckBox.Width = 125;
            importantCheckBox.Height = 34;
            importantCheckBox.Top = 24;
            importantCheckBox.Text = "ملاحظة مهمة";
            importantCheckBox.RightToLeft = RightToLeft.Yes;
            importantCheckBox.ForeColor = Solvix.UI.AppTheme.Text;
            importantCheckBox.BackColor = Color.Transparent;

            pinnedCheckBox.Width = 125;
            pinnedCheckBox.Height = 34;
            pinnedCheckBox.Top = 24;
            pinnedCheckBox.Text = "تثبيت الملاحظة";
            pinnedCheckBox.RightToLeft = RightToLeft.Yes;
            pinnedCheckBox.ForeColor = Solvix.UI.AppTheme.Text;
            pinnedCheckBox.BackColor = Color.Transparent;

            saveButton.Width = 138;
            saveButton.Height = 42;
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveButton.Top = 22;
            saveButton.Text = "حفظ الملاحظة";
            saveButton.Font = Solvix.UI.AppTheme.Bold(9F);

            cancelButton.Width = 88;
            cancelButton.Height = 42;
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelButton.Top = 22;
            cancelButton.Text = "إلغاء";

            editorBottomPanel.Controls.Add(categoryCaption);
            editorBottomPanel.Controls.Add(categoryCombo);
            editorBottomPanel.Controls.Add(importantCheckBox);
            editorBottomPanel.Controls.Add(pinnedCheckBox);
            editorBottomPanel.Controls.Add(cancelButton);
            editorBottomPanel.Controls.Add(saveButton);

            // HIERARCHY
            detailPanel.Controls.Add(editorContainer);
            detailPanel.Controls.Add(displayContainer);
            detailPanel.Controls.Add(detailHeaderPanel);

            contentPanel.Controls.Add(detailPanel);
            contentPanel.Controls.Add(listPanel);

            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(statsPanel);
            mainPanel.Controls.Add(toolbarPanel);
            mainPanel.Controls.Add(headerPanel);

            // FORM
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScaleDimensions = new SizeF(96F, 96F);
            BackColor = Solvix.UI.AppTheme.Background;
            ForeColor = Solvix.UI.AppTheme.Text;
            ClientSize = new Size(1440, 900);
            MinimumSize = new Size(1120, 720);
            Controls.Add(mainPanel);
            Font = Solvix.UI.AppTheme.Regular(9.5F);
            Name = "Notes";
            Text = "الملاحظات";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;

            // Initial fixed positions. Runtime resize handling lives in Notes.cs.
            addNoteButton.Left = 0;
            searchBox.Left = 0;

            totalCard.Left = 0;
            importantCard.Left = 0;
            pinnedCard.Left = 0;
            todayCard.Left = 0;

            deleteButton.Left = 0;
            editButton.Left = 0;
            pinButton.Left = 0;
            noteBadge.Left = 0;

            categoryLabel.Left = 0;
            categoryValue.Left = 0;
            createdLabel.Left = 0;
            createdValue.Left = 0;
            updatedLabel.Left = 0;
            updatedValue.Left = 0;

            saveButton.Left = 0;
            cancelButton.Left = 0;
            importantCheckBox.Left = 190;
            pinnedCheckBox.Left = 325;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
