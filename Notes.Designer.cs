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
        private Notes.DarkComboBox categoryCombo;
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
            categoryCombo = new Notes.DarkComboBox();
            importantCheckBox = new Notes.DarkCheckBox();
            pinnedCheckBox = new Notes.DarkCheckBox();
            saveButton = new Solvix.UI.CustomButton();
            cancelButton = new Solvix.UI.OutlineButton();

            SuspendLayout();

            // FORM
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Solvix.UI.AppTheme.Background;
            ClientSize = new Size(1500, 900);
            Font = Solvix.UI.AppTheme.Regular(9F);
            ForeColor = Solvix.UI.AppTheme.Text;
            MinimumSize = new Size(1100, 720);
            Name = "Notes";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الملاحظات";

            // MAIN
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Solvix.UI.AppTheme.Background;
            mainPanel.Padding = new Padding(28, 22, 28, 22);
            mainPanel.RightToLeft = RightToLeft.Yes;

            // HEADER
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 72;
            headerPanel.BackColor = Color.Transparent;
            headerPanel.RightToLeft = RightToLeft.Yes;

            headerAccent.Size = new Size(4, 52);
            headerAccent.Top = 1;
            headerAccent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            headerAccent.BackColor = Solvix.UI.AppTheme.Primary;

            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            titleLabel.AutoSize = false;
            titleLabel.Width = 360;
            titleLabel.Height = 40;
            titleLabel.Top = 0;
            titleLabel.Right = 14;
            titleLabel.Font = Solvix.UI.AppTheme.Bold(21F);
            titleLabel.ForeColor = Solvix.UI.AppTheme.Text;
            titleLabel.Text = "الملاحظات";
            titleLabel.TextAlign = ContentAlignment.MiddleRight;
            titleLabel.RightToLeft = RightToLeft.Yes;

            subtitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            subtitleLabel.AutoSize = false;
            subtitleLabel.Width = 500;
            subtitleLabel.Height = 25;
            subtitleLabel.Top = 42;
            subtitleLabel.Right = 14;
            subtitleLabel.Font = Solvix.UI.AppTheme.Regular(8.5F);
            subtitleLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            subtitleLabel.Text = "نظّم أفكارك وملاحظاتك من مكان واحد.";
            subtitleLabel.TextAlign = ContentAlignment.MiddleRight;
            subtitleLabel.RightToLeft = RightToLeft.Yes;

            headerPanel.Controls.Add(headerAccent);
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(titleLabel);

            // TOOLBAR
            toolbarPanel.Dock = DockStyle.Top;
            toolbarPanel.Height = 56;
            toolbarPanel.BackColor = Color.Transparent;
            toolbarPanel.RightToLeft = RightToLeft.Yes;

            addNoteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addNoteButton.Size = new Size(178, 42);
            addNoteButton.Top = 5;
            addNoteButton.Right = 0;
            addNoteButton.Text = "إضافة ملاحظة";
            addNoteButton.Font = Solvix.UI.AppTheme.Bold(9.2F);

            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBox.Size = new Size(390, 42);
            searchBox.Top = 5;
            searchBox.Right = 192;
            searchBox.PlaceholderText = "ابحث في الملاحظات...";
            searchBox.RightToLeft = RightToLeft.Yes;

            toolbarPanel.Controls.Add(searchBox);
            toolbarPanel.Controls.Add(addNoteButton);

            // STATS
            statsPanel.Dock = DockStyle.Top;
            statsPanel.Height = 106;
            statsPanel.BackColor = Color.Transparent;

            ConfigureStatCard(totalCard, "إجمالي الملاحظات", "0", "جميع الملاحظات الحالية", Solvix.UI.AppTheme.Primary);
            ConfigureStatCard(importantCard, "ملاحظات مهمة", "0", "تحتاج انتباهك", Solvix.UI.AppTheme.Warning);
            ConfigureStatCard(pinnedCard, "المثبتة", "0", "تظهر في أعلى القائمة", Solvix.UI.AppTheme.PrimaryHover);
            ConfigureStatCard(todayCard, "ملاحظات اليوم", "0", "أضيفت أو عدلت اليوم", Solvix.UI.AppTheme.Success);

            statsPanel.Controls.Add(totalCard);
            statsPanel.Controls.Add(importantCard);
            statsPanel.Controls.Add(pinnedCard);
            statsPanel.Controls.Add(todayCard);

            // CONTENT
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = Color.Transparent;
            contentPanel.Padding = new Padding(0, 10, 0, 0);

            // LIST PANEL
            listPanel.Dock = DockStyle.Left;
            listPanel.Width = 430;
            listPanel.FillColor = Color.FromArgb(10, 19, 32);
            listPanel.BorderColor = Solvix.UI.AppTheme.Border;
            listPanel.BorderThickness = 1;
            listPanel.CornerRadius = 14;
            listPanel.Padding = new Padding(0);

            listHeaderPanel.Dock = DockStyle.Top;
            listHeaderPanel.Height = 72;
            listHeaderPanel.BackColor = Solvix.UI.AppTheme.Surface;
            listHeaderPanel.RightToLeft = RightToLeft.Yes;

            listAccent.Dock = DockStyle.Top;
            listAccent.Height = 3;
            listAccent.BackColor = Solvix.UI.AppTheme.Primary;

            listTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listTitleLabel.AutoSize = false;
            listTitleLabel.Width = 250;
            listTitleLabel.Height = 28;
            listTitleLabel.Top = 8;
            listTitleLabel.Right = 14;
            listTitleLabel.Font = Solvix.UI.AppTheme.Bold(10.5F);
            listTitleLabel.ForeColor = Solvix.UI.AppTheme.Text;
            listTitleLabel.Text = "قائمة الملاحظات";
            listTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            listTitleLabel.RightToLeft = RightToLeft.Yes;

            listCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listCountLabel.AutoSize = false;
            listCountLabel.Width = 250;
            listCountLabel.Height = 21;
            listCountLabel.Top = 37;
            listCountLabel.Right = 14;
            listCountLabel.Font = Solvix.UI.AppTheme.Regular(7.8F);
            listCountLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            listCountLabel.Text = "";
            listCountLabel.TextAlign = ContentAlignment.MiddleRight;
            listCountLabel.RightToLeft = RightToLeft.Yes;

            filterButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            filterButton.Size = new Size(88, 34);
            filterButton.Left = 14;
            filterButton.Top = 20;
            filterButton.Text = "الكل";
            filterButton.Font = Solvix.UI.AppTheme.Bold(8.4F);

            listHeaderPanel.Controls.Add(filterButton);
            listHeaderPanel.Controls.Add(listCountLabel);
            listHeaderPanel.Controls.Add(listTitleLabel);
            listHeaderPanel.Controls.Add(listAccent);

            notesScrollPanel.Dock = DockStyle.Fill;
            notesScrollPanel.BackColor = Solvix.UI.AppTheme.Background;
            notesScrollPanel.AutoScroll = true;
            notesScrollPanel.Padding = new Padding(8, 8, 8, 12);
            notesScrollPanel.RightToLeft = RightToLeft.No;

            listPanel.Controls.Add(notesScrollPanel);
            listPanel.Controls.Add(listHeaderPanel);

            // DETAIL PANEL
            detailPanel.Dock = DockStyle.Fill;
            detailPanel.FillColor = Color.FromArgb(13, 24, 39);
            detailPanel.BorderColor = Solvix.UI.AppTheme.Border;
            detailPanel.BorderThickness = 1;
            detailPanel.CornerRadius = 14;
            detailPanel.Padding = new Padding(0);

            detailHeaderPanel.Dock = DockStyle.Top;
            detailHeaderPanel.Height = 68;
            detailHeaderPanel.BackColor = Solvix.UI.AppTheme.Surface;
            detailHeaderPanel.RightToLeft = RightToLeft.Yes;

            detailAccent.Dock = DockStyle.Top;
            detailAccent.Height = 3;
            detailAccent.BackColor = Solvix.UI.AppTheme.Primary;

            detailHeaderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            detailHeaderLabel.AutoSize = false;
            detailHeaderLabel.Width = 250;
            detailHeaderLabel.Height = 38;
            detailHeaderLabel.Top = 15;
            detailHeaderLabel.Right = 18;
            detailHeaderLabel.Font = Solvix.UI.AppTheme.Bold(10.5F);
            detailHeaderLabel.ForeColor = Solvix.UI.AppTheme.Text;
            detailHeaderLabel.Text = "تفاصيل الملاحظة";
            detailHeaderLabel.TextAlign = ContentAlignment.MiddleRight;
            detailHeaderLabel.RightToLeft = RightToLeft.Yes;

            noteBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            noteBadge.Size = new Size(78, 28);
            noteBadge.Top = 20;
            noteBadge.Right = 285;
            noteBadge.Text = "ملاحظة";
            noteBadge.Style = Solvix.UI.BadgeStyle.Primary;

            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            deleteButton.Size = new Size(38, 38);
            deleteButton.Left = 16;
            deleteButton.Top = 15;
            deleteButton.Text = "⌫";
            deleteButton.BackColor = Color.Transparent;

            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            editButton.Size = new Size(38, 38);
            editButton.Left = 60;
            editButton.Top = 15;
            editButton.Text = "✎";
            editButton.BackColor = Color.Transparent;

            pinButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pinButton.Size = new Size(38, 38);
            pinButton.Left = 104;
            pinButton.Top = 15;
            pinButton.Text = "⚐";
            pinButton.BackColor = Color.Transparent;

            detailHeaderPanel.Controls.Add(deleteButton);
            detailHeaderPanel.Controls.Add(editButton);
            detailHeaderPanel.Controls.Add(pinButton);
            detailHeaderPanel.Controls.Add(noteBadge);
            detailHeaderPanel.Controls.Add(detailHeaderLabel);
            detailHeaderPanel.Controls.Add(detailAccent);

            // DISPLAY
            displayContainer.Dock = DockStyle.Fill;
            displayContainer.BackColor = Color.Transparent;
            displayContainer.Padding = new Padding(24, 8, 24, 18);
            displayContainer.RightToLeft = RightToLeft.Yes;

            detailTitleLabel.Dock = DockStyle.Top;
            detailTitleLabel.Height = 64;
            detailTitleLabel.Padding = new Padding(4, 8, 4, 0);
            detailTitleLabel.Font = Solvix.UI.AppTheme.Bold(19F);
            detailTitleLabel.ForeColor = Solvix.UI.AppTheme.Text;
            detailTitleLabel.Text = "لا توجد ملاحظة";
            detailTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            detailTitleLabel.RightToLeft = RightToLeft.Yes;
            detailTitleLabel.AutoEllipsis = true;

            detailDateLabel.Dock = DockStyle.Top;
            detailDateLabel.Height = 30;
            detailDateLabel.Padding = new Padding(4, 0, 4, 0);
            detailDateLabel.Font = Solvix.UI.AppTheme.Regular(8F);
            detailDateLabel.ForeColor = Solvix.UI.AppTheme.MutedText;
            detailDateLabel.Text = "";
            detailDateLabel.TextAlign = ContentAlignment.MiddleRight;
            detailDateLabel.RightToLeft = RightToLeft.Yes;
            detailDateLabel.AutoEllipsis = true;

            detailContentLabel.Dock = DockStyle.Fill;
            detailContentLabel.Padding = new Padding(4, 18, 4, 12);
            detailContentLabel.Font = Solvix.UI.AppTheme.Regular(9.4F);
            detailContentLabel.ForeColor = Solvix.UI.AppTheme.Text;
            detailContentLabel.Text = "";
            detailContentLabel.TextAlign = ContentAlignment.TopRight;
            detailContentLabel.RightToLeft = RightToLeft.Yes;
            detailContentLabel.AutoEllipsis = false;

            infoPanel.Dock = DockStyle.Bottom;
            infoPanel.Height = 92;
            infoPanel.Padding = new Padding(14, 10, 14, 10);
            infoPanel.FillColor = Color.FromArgb(17, 36, 59);
            infoPanel.BorderColor = Color.FromArgb(39, 76, 116);
            infoPanel.BorderThickness = 1;
            infoPanel.CornerRadius = 11;

            ConfigureInfoLabel(categoryLabel, "التصنيف");
            ConfigureInfoLabel(categoryValue, "-");
            ConfigureInfoLabel(createdLabel, "تاريخ الإنشاء");
            ConfigureInfoLabel(createdValue, "-");
            ConfigureInfoLabel(updatedLabel, "آخر تحديث");
            ConfigureInfoLabel(updatedValue, "-");

            categoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categoryLabel.Width = 110;
            categoryLabel.Top = 10;
            categoryLabel.Right = 18;
            categoryValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categoryValue.Width = 170;
            categoryValue.Top = 36;
            categoryValue.Right = 18;

            createdLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createdLabel.Width = 150;
            createdLabel.Top = 10;
            createdLabel.Right = 220;
            createdValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createdValue.Width = 150;
            createdValue.Top = 36;
            createdValue.Right = 220;

            updatedLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updatedLabel.Width = 150;
            updatedLabel.Top = 10;
            updatedLabel.Right = 405;
            updatedValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updatedValue.Width = 150;
            updatedValue.Top = 36;
            updatedValue.Right = 405;

            infoPanel.Controls.Add(updatedValue);
            infoPanel.Controls.Add(updatedLabel);
            infoPanel.Controls.Add(createdValue);
            infoPanel.Controls.Add(createdLabel);
            infoPanel.Controls.Add(categoryValue);
            infoPanel.Controls.Add(categoryLabel);

            displayContainer.Controls.Add(detailContentLabel);
            displayContainer.Controls.Add(detailDateLabel);
            displayContainer.Controls.Add(detailTitleLabel);
            displayContainer.Controls.Add(infoPanel);

            // EDITOR
            editorContainer.Dock = DockStyle.Fill;
            editorContainer.BackColor = Color.Transparent;
            editorContainer.Padding = new Padding(24, 18, 24, 18);
            editorContainer.RightToLeft = RightToLeft.Yes;
            editorContainer.Visible = false;

            editorHeading.Dock = DockStyle.Top;
            editorHeading.Height = 40;
            editorHeading.Font = Solvix.UI.AppTheme.Bold(17F);
            editorHeading.ForeColor = Solvix.UI.AppTheme.Text;
            editorHeading.Text = "إضافة ملاحظة جديدة";
            editorHeading.TextAlign = ContentAlignment.MiddleRight;
            editorHeading.RightToLeft = RightToLeft.Yes;

            editorSubHeading.Dock = DockStyle.Top;
            editorSubHeading.Height = 24;
            editorSubHeading.Font = Solvix.UI.AppTheme.Regular(8F);
            editorSubHeading.ForeColor = Solvix.UI.AppTheme.MutedText;
            editorSubHeading.Text = "";
            editorSubHeading.TextAlign = ContentAlignment.MiddleRight;
            editorSubHeading.RightToLeft = RightToLeft.Yes;

            titleFrame.Dock = DockStyle.Top;
            titleFrame.Height = 82;
            titleFrame.Padding = new Padding(0, 8, 0, 10);
            titleFrame.BackColor = Color.Transparent;

            titleCaption.Dock = DockStyle.Top;
            titleCaption.Height = 22;
            titleCaption.Font = Solvix.UI.AppTheme.Bold(8.4F);
            titleCaption.ForeColor = Solvix.UI.AppTheme.MutedText;
            titleCaption.Text = "العنوان";
            titleCaption.TextAlign = ContentAlignment.MiddleRight;
            titleCaption.RightToLeft = RightToLeft.Yes;

            titleEditBox.Dock = DockStyle.Fill;
            titleEditBox.BackColor = Solvix.UI.AppTheme.SurfaceAlt;
            titleEditBox.ForeColor = Solvix.UI.AppTheme.Text;
            titleEditBox.BorderStyle = BorderStyle.None;
            titleEditBox.Font = Solvix.UI.AppTheme.Regular(9.5F);
            titleEditBox.Multiline = false;
            titleEditBox.RightToLeft = RightToLeft.Yes;
            titleEditBox.Text = "";
            titleEditBox.Margin = new Padding(0);
            titleEditBox.Padding = new Padding(10, 0, 10, 0);

            titleFrame.Controls.Add(titleEditBox);
            titleFrame.Controls.Add(titleCaption);

            contentFrame.Dock = DockStyle.Fill;
            contentFrame.Padding = new Padding(0, 8, 0, 10);
            contentFrame.BackColor = Color.Transparent;

            contentCaption.Dock = DockStyle.Top;
            contentCaption.Height = 22;
            contentCaption.Font = Solvix.UI.AppTheme.Bold(8.4F);
            contentCaption.ForeColor = Solvix.UI.AppTheme.MutedText;
            contentCaption.Text = "المحتوى";
            contentCaption.TextAlign = ContentAlignment.MiddleRight;
            contentCaption.RightToLeft = RightToLeft.Yes;

            contentEditBox.Dock = DockStyle.Fill;
            contentEditBox.BackColor = Solvix.UI.AppTheme.SurfaceAlt;
            contentEditBox.ForeColor = Solvix.UI.AppTheme.Text;
            contentEditBox.Font = Solvix.UI.AppTheme.Regular(9.2F);
            contentEditBox.Text = "";
            contentEditBox.RightToLeft = RightToLeft.Yes;

            contentFrame.Controls.Add(contentEditBox);
            contentFrame.Controls.Add(contentCaption);

            editorBottomPanel.Dock = DockStyle.Bottom;
            editorBottomPanel.Height = 86;
            editorBottomPanel.BackColor = Color.Transparent;

            categoryCaption.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categoryCaption.Width = 100;
            categoryCaption.Height = 24;
            categoryCaption.Top = 0;
            categoryCaption.Right = 0;
            categoryCaption.Font = Solvix.UI.AppTheme.Bold(8.2F);
            categoryCaption.ForeColor = Solvix.UI.AppTheme.MutedText;
            categoryCaption.Text = "التصنيف";
            categoryCaption.TextAlign = ContentAlignment.MiddleRight;
            categoryCaption.RightToLeft = RightToLeft.Yes;

            categoryCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categoryCombo.Size = new Size(190, 32);
            categoryCombo.Top = 26;
            categoryCombo.Right = 0;
            categoryCombo.Text = "";
            categoryCombo.SelectedIndex = -1;
            categoryCombo.Items.AddRange(new object[] { "عام", "عمل", "مشروع", "شخصي", "أفكار" });

            importantCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            importantCheckBox.Width = 120;
            importantCheckBox.Top = 26;
            importantCheckBox.Right = 205;
            importantCheckBox.Text = "مهمة";

            pinnedCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pinnedCheckBox.Width = 120;
            pinnedCheckBox.Top = 26;
            pinnedCheckBox.Right = 330;
            pinnedCheckBox.Text = "تثبيت";

            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            saveButton.Size = new Size(120, 40);
            saveButton.Top = 24;
            saveButton.Left = 0;
            saveButton.Text = "حفظ";
            saveButton.Font = Solvix.UI.AppTheme.Bold(8.8F);

            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cancelButton.Size = new Size(120, 40);
            cancelButton.Top = 24;
            cancelButton.Left = 130;
            cancelButton.Text = "إلغاء";
            cancelButton.Font = Solvix.UI.AppTheme.Bold(8.8F);

            editorBottomPanel.Controls.Add(saveButton);
            editorBottomPanel.Controls.Add(cancelButton);
            editorBottomPanel.Controls.Add(pinnedCheckBox);
            editorBottomPanel.Controls.Add(importantCheckBox);
            editorBottomPanel.Controls.Add(categoryCombo);
            editorBottomPanel.Controls.Add(categoryCaption);

            editorContainer.Controls.Add(contentFrame);
            editorContainer.Controls.Add(editorBottomPanel);
            editorContainer.Controls.Add(titleFrame);
            editorContainer.Controls.Add(editorSubHeading);
            editorContainer.Controls.Add(editorHeading);

            // DETAIL ORDER
            detailPanel.Controls.Add(editorContainer);
            detailPanel.Controls.Add(displayContainer);
            detailPanel.Controls.Add(detailHeaderPanel);

            // ROOT ORDER
            contentPanel.Controls.Add(detailPanel);
            contentPanel.Controls.Add(listPanel);

            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(statsPanel);
            mainPanel.Controls.Add(toolbarPanel);
            mainPanel.Controls.Add(headerPanel);

            Controls.Add(mainPanel);

            ResumeLayout(false);
            PerformLayout();
        }

        private static void ConfigureStatCard(
            Solvix.UI.StatCard card,
            string title,
            string value,
            string subtitle,
            Color accent)
        {
            card.Height = 90;
            card.FillColor = Solvix.UI.AppTheme.Surface;
            card.BorderColor = Solvix.UI.AppTheme.Border;
            card.BorderThickness = 1;
            card.CornerRadius = 12;
            card.Title = title;
            card.Value = value;
            card.Subtitle = subtitle;
            card.AccentColor = accent;
            card.Margin = new Padding(0);
        }

        private static void ConfigureInfoLabel(Label label, string text)
        {
            label.AutoSize = false;
            label.Height = 22;
            label.BackColor = Color.Transparent;
            label.ForeColor = Solvix.UI.AppTheme.MutedText;
            label.Font = Solvix.UI.AppTheme.Regular(7.6F);
            label.Text = text;
            label.TextAlign = ContentAlignment.MiddleRight;
            label.RightToLeft = RightToLeft.Yes;
        }
    }
}
