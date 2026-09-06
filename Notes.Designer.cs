using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace SOLVIX
{
    partial class Notes
    {
        private System.ComponentModel.IContainer components = null;

        // Background
        private Panel mainPanel;
        private Panel sidebarPanel;
        private Panel contentPanel;

        // Sidebar
        private Label logoLabel;
        private Label logoSubLabel;
        private Button dashboardButton;
        private Button notesNavButton;
        private Button tasksButton;
        private Button projectsButton;
        private Button developersButton;
        private Button settingsButton;

        // Header
        private Label pageTitleLabel;
        private Label pageSubtitleLabel;
        private MaterialTextBox2 searchTextBox;
        private MaterialButton addNoteButton;
        private MaterialButton filterButton;

        // Statistics
        private Panel totalCard;
        private Panel importantCard;
        private Panel pinnedCard;
        private Panel todayCard;

        private Label totalValueLabel;
        private Label importantValueLabel;
        private Label pinnedValueLabel;
        private Label todayValueLabel;

        private Label totalTitleLabel;
        private Label importantTitleLabel;
        private Label pinnedTitleLabel;
        private Label todayTitleLabel;

        // Notes list
        private Panel notesListPanel;
        private Label notesListTitleLabel;
        private Label notesListSubtitleLabel;
        private MaterialListBox notesListBox;

        // Details
        private Panel detailPanel;
        private Label detailTitleLabel;
        private Label detailMetaLabel;
        private Label contentLabel;

        private MaterialMultiLineTextBox2 detailContentTextBox;
        private MaterialComboBox categoryComboBox;

        private CheckBox importantCheckBox;
        private CheckBox pinnedCheckBox;

        private MaterialButton editButton;
        private MaterialButton cancelButton;
        private MaterialButton saveButton;
        private MaterialButton pinButton;
        private MaterialButton deleteButton;

        private Panel categoryPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            contentPanel = new Panel();
            pageTitleLabel = new Label();
            pageSubtitleLabel = new Label();
            searchTextBox = new MaterialTextBox2();
            filterButton = new MaterialButton();
            addNoteButton = new MaterialButton();
            totalCard = new Panel();
            importantCard = new Panel();
            pinnedCard = new Panel();
            todayCard = new Panel();
            totalValueLabel = new Label();
            totalTitleLabel = new Label();
            importantValueLabel = new Label();
            importantTitleLabel = new Label();
            pinnedValueLabel = new Label();
            pinnedTitleLabel = new Label();
            todayValueLabel = new Label();
            todayTitleLabel = new Label();
            notesListPanel = new Panel();
            notesListTitleLabel = new Label();
            notesListSubtitleLabel = new Label();
            notesListBox = new MaterialListBox();
            detailPanel = new Panel();
            detailTitleLabel = new Label();
            detailMetaLabel = new Label();
            contentLabel = new Label();
            detailContentTextBox = new MaterialMultiLineTextBox2();
            categoryPanel = new Panel();
            categoryComboBox = new MaterialComboBox();
            importantCheckBox = new CheckBox();
            pinnedCheckBox = new CheckBox();
            editButton = new MaterialButton();
            pinButton = new MaterialButton();
            deleteButton = new MaterialButton();
            saveButton = new MaterialButton();
            cancelButton = new MaterialButton();
            sidebarPanel = new Panel();
            logoLabel = new Label();
            logoSubLabel = new Label();
            dashboardButton = new Button();
            notesNavButton = new Button();
            tasksButton = new Button();
            projectsButton = new Button();
            developersButton = new Button();
            settingsButton = new Button();
            mainPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            notesListPanel.SuspendLayout();
            detailPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(9, 15, 27);
            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(sidebarPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1440, 900);
            mainPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(9, 15, 27);
            contentPanel.Controls.Add(pageTitleLabel);
            contentPanel.Controls.Add(pageSubtitleLabel);
            contentPanel.Controls.Add(searchTextBox);
            contentPanel.Controls.Add(filterButton);
            contentPanel.Controls.Add(addNoteButton);
            contentPanel.Controls.Add(totalCard);
            contentPanel.Controls.Add(importantCard);
            contentPanel.Controls.Add(pinnedCard);
            contentPanel.Controls.Add(todayCard);
            contentPanel.Controls.Add(totalValueLabel);
            contentPanel.Controls.Add(totalTitleLabel);
            contentPanel.Controls.Add(importantValueLabel);
            contentPanel.Controls.Add(importantTitleLabel);
            contentPanel.Controls.Add(pinnedValueLabel);
            contentPanel.Controls.Add(pinnedTitleLabel);
            contentPanel.Controls.Add(todayValueLabel);
            contentPanel.Controls.Add(todayTitleLabel);
            contentPanel.Controls.Add(notesListPanel);
            contentPanel.Controls.Add(detailPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(320, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(35);
            contentPanel.Size = new Size(1120, 900);
            contentPanel.TabIndex = 2;
            // 
            // pageTitleLabel
            // 
            pageTitleLabel.AutoSize = true;
            pageTitleLabel.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            pageTitleLabel.ForeColor = Color.FromArgb(241, 245, 249);
            pageTitleLabel.Location = new Point(35, 30);
            pageTitleLabel.Name = "pageTitleLabel";
            pageTitleLabel.Size = new Size(428, 116);
            pageTitleLabel.TabIndex = 3;
            pageTitleLabel.Text = "الملاحظات";
            // 
            // pageSubtitleLabel
            // 
            pageSubtitleLabel.AutoSize = true;
            pageSubtitleLabel.Font = new Font("Segoe UI", 10.5F);
            pageSubtitleLabel.ForeColor = Color.FromArgb(148, 163, 184);
            pageSubtitleLabel.Location = new Point(39, 78);
            pageSubtitleLabel.Name = "pageSubtitleLabel";
            pageSubtitleLabel.Size = new Size(480, 47);
            pageSubtitleLabel.TabIndex = 4;
            pageSubtitleLabel.Text = "إدارة ملاحظات ومعلومات العمل";
            // 
            // searchTextBox
            // 
            searchTextBox.AnimateReadOnly = false;
            searchTextBox.BackgroundImageLayout = ImageLayout.None;
            searchTextBox.CharacterCasing = CharacterCasing.Normal;
            searchTextBox.Depth = 0;
            searchTextBox.Font = new Font("Segoe UI", 12F);
            searchTextBox.HideSelection = true;
            searchTextBox.LeadingIcon = null;
            searchTextBox.Location = new Point(620, 35);
            searchTextBox.MaxLength = 32767;
            searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.PrefixSuffixText = null;
            searchTextBox.ReadOnly = false;
            searchTextBox.RightToLeft = RightToLeft.Yes;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.ShortcutsEnabled = true;
            searchTextBox.Size = new Size(300, 48);
            searchTextBox.TabIndex = 5;
            searchTextBox.TabStop = false;
            searchTextBox.TextAlign = HorizontalAlignment.Right;
            searchTextBox.TrailingIcon = null;
            searchTextBox.UseSystemPasswordChar = false;
            searchTextBox.Click += searchTextBox_Click;
            // 
            // filterButton
            // 
            filterButton.AutoSize = false;
            filterButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filterButton.Density = MaterialButton.MaterialButtonDensity.Default;
            filterButton.Depth = 0;
            filterButton.HighEmphasis = false;
            filterButton.Icon = null;
            filterButton.Location = new Point(935, 40);
            filterButton.Margin = new Padding(0);
            filterButton.MouseState = MaterialSkin.MouseState.HOVER;
            filterButton.Name = "filterButton";
            filterButton.NoAccentTextColor = Color.Empty;
            filterButton.Size = new Size(100, 40);
            filterButton.TabIndex = 6;
            filterButton.Text = "الكل";
            filterButton.Type = MaterialButton.MaterialButtonType.Outlined;
            filterButton.UseAccentColor = false;
            filterButton.UseVisualStyleBackColor = true;
            // 
            // addNoteButton
            // 
            addNoteButton.AutoSize = false;
            addNoteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addNoteButton.Density = MaterialButton.MaterialButtonDensity.Default;
            addNoteButton.Depth = 0;
            addNoteButton.HighEmphasis = true;
            addNoteButton.Icon = null;
            addNoteButton.Location = new Point(1045, 40);
            addNoteButton.Margin = new Padding(0);
            addNoteButton.MouseState = MaterialSkin.MouseState.HOVER;
            addNoteButton.Name = "addNoteButton";
            addNoteButton.NoAccentTextColor = Color.Empty;
            addNoteButton.Size = new Size(135, 40);
            addNoteButton.TabIndex = 7;
            addNoteButton.Text = "إضافة ملاحظة";
            addNoteButton.Type = MaterialButton.MaterialButtonType.Contained;
            addNoteButton.UseAccentColor = true;
            addNoteButton.UseVisualStyleBackColor = true;
            // 
            // totalCard
            // 
            totalCard.Location = new Point(0, 0);
            totalCard.Name = "totalCard";
            totalCard.Size = new Size(200, 100);
            totalCard.TabIndex = 8;
            // 
            // importantCard
            // 
            importantCard.Location = new Point(0, 0);
            importantCard.Name = "importantCard";
            importantCard.Size = new Size(200, 100);
            importantCard.TabIndex = 9;
            // 
            // pinnedCard
            // 
            pinnedCard.Location = new Point(0, 0);
            pinnedCard.Name = "pinnedCard";
            pinnedCard.Size = new Size(200, 100);
            pinnedCard.TabIndex = 10;
            // 
            // todayCard
            // 
            todayCard.Location = new Point(0, 0);
            todayCard.Name = "todayCard";
            todayCard.Size = new Size(200, 100);
            todayCard.TabIndex = 11;
            // 
            // totalValueLabel
            // 
            totalValueLabel.Location = new Point(0, 0);
            totalValueLabel.Name = "totalValueLabel";
            totalValueLabel.Size = new Size(100, 23);
            totalValueLabel.TabIndex = 12;
            // 
            // totalTitleLabel
            // 
            totalTitleLabel.Location = new Point(0, 0);
            totalTitleLabel.Name = "totalTitleLabel";
            totalTitleLabel.Size = new Size(100, 23);
            totalTitleLabel.TabIndex = 13;
            // 
            // importantValueLabel
            // 
            importantValueLabel.Location = new Point(0, 0);
            importantValueLabel.Name = "importantValueLabel";
            importantValueLabel.Size = new Size(100, 23);
            importantValueLabel.TabIndex = 14;
            // 
            // importantTitleLabel
            // 
            importantTitleLabel.Location = new Point(0, 0);
            importantTitleLabel.Name = "importantTitleLabel";
            importantTitleLabel.Size = new Size(100, 23);
            importantTitleLabel.TabIndex = 15;
            // 
            // pinnedValueLabel
            // 
            pinnedValueLabel.Location = new Point(0, 0);
            pinnedValueLabel.Name = "pinnedValueLabel";
            pinnedValueLabel.Size = new Size(100, 23);
            pinnedValueLabel.TabIndex = 16;
            // 
            // pinnedTitleLabel
            // 
            pinnedTitleLabel.Location = new Point(0, 0);
            pinnedTitleLabel.Name = "pinnedTitleLabel";
            pinnedTitleLabel.Size = new Size(100, 23);
            pinnedTitleLabel.TabIndex = 17;
            // 
            // todayValueLabel
            // 
            todayValueLabel.Location = new Point(0, 0);
            todayValueLabel.Name = "todayValueLabel";
            todayValueLabel.Size = new Size(100, 23);
            todayValueLabel.TabIndex = 18;
            // 
            // todayTitleLabel
            // 
            todayTitleLabel.Location = new Point(0, 0);
            todayTitleLabel.Name = "todayTitleLabel";
            todayTitleLabel.Size = new Size(100, 23);
            todayTitleLabel.TabIndex = 19;
            // 
            // notesListPanel
            // 
            notesListPanel.BackColor = Color.FromArgb(17, 27, 43);
            notesListPanel.Controls.Add(notesListTitleLabel);
            notesListPanel.Controls.Add(notesListSubtitleLabel);
            notesListPanel.Controls.Add(notesListBox);
            notesListPanel.Location = new Point(35, 255);
            notesListPanel.Name = "notesListPanel";
            notesListPanel.Size = new Size(455, 570);
            notesListPanel.TabIndex = 20;
            // 
            // notesListTitleLabel
            // 
            notesListTitleLabel.AutoSize = true;
            notesListTitleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            notesListTitleLabel.ForeColor = Color.FromArgb(241, 245, 249);
            notesListTitleLabel.Location = new Point(22, 20);
            notesListTitleLabel.Name = "notesListTitleLabel";
            notesListTitleLabel.Size = new Size(371, 67);
            notesListTitleLabel.TabIndex = 0;
            notesListTitleLabel.Text = "قائمة الملاحظات";
            // 
            // notesListSubtitleLabel
            // 
            notesListSubtitleLabel.AutoSize = true;
            notesListSubtitleLabel.Font = new Font("Segoe UI", 9F);
            notesListSubtitleLabel.ForeColor = Color.FromArgb(148, 163, 184);
            notesListSubtitleLabel.Location = new Point(24, 51);
            notesListSubtitleLabel.Name = "notesListSubtitleLabel";
            notesListSubtitleLabel.Size = new Size(369, 41);
            notesListSubtitleLabel.TabIndex = 1;
            notesListSubtitleLabel.Text = "اختر ملاحظة لعرض تفاصيلها";
            // 
            // notesListBox
            // 
            notesListBox.BackColor = Color.FromArgb(17, 27, 43);
            notesListBox.BorderColor = Color.FromArgb(36, 50, 68);
            notesListBox.Depth = 0;
            notesListBox.Font = new Font("Segoe UI", 11F);
            notesListBox.Location = new Point(15, 82);
            notesListBox.MouseState = MaterialSkin.MouseState.HOVER;
            notesListBox.Name = "notesListBox";
            notesListBox.SelectedIndex = -1;
            notesListBox.SelectedItem = null;
            notesListBox.Size = new Size(425, 465);
            notesListBox.TabIndex = 2;
            // 
            // detailPanel
            // 
            detailPanel.BackColor = Color.FromArgb(17, 27, 43);
            detailPanel.Controls.Add(detailTitleLabel);
            detailPanel.Controls.Add(detailMetaLabel);
            detailPanel.Controls.Add(contentLabel);
            detailPanel.Controls.Add(detailContentTextBox);
            detailPanel.Controls.Add(categoryPanel);
            detailPanel.Controls.Add(categoryComboBox);
            detailPanel.Controls.Add(importantCheckBox);
            detailPanel.Controls.Add(pinnedCheckBox);
            detailPanel.Controls.Add(editButton);
            detailPanel.Controls.Add(pinButton);
            detailPanel.Controls.Add(deleteButton);
            detailPanel.Controls.Add(saveButton);
            detailPanel.Controls.Add(cancelButton);
            detailPanel.Location = new Point(510, 255);
            detailPanel.Name = "detailPanel";
            detailPanel.Size = new Size(670, 570);
            detailPanel.TabIndex = 30;
            // 
            // detailTitleLabel
            // 
            detailTitleLabel.AutoSize = true;
            detailTitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            detailTitleLabel.ForeColor = Color.FromArgb(241, 245, 249);
            detailTitleLabel.Location = new Point(28, 20);
            detailTitleLabel.Name = "detailTitleLabel";
            detailTitleLabel.Size = new Size(457, 81);
            detailTitleLabel.TabIndex = 0;
            detailTitleLabel.Text = "تفاصيل الملاحظة";
            detailTitleLabel.Click += materialLabel2_Click;
            // 
            // detailMetaLabel
            // 
            detailMetaLabel.AutoSize = true;
            detailMetaLabel.Font = new Font("Segoe UI", 9F);
            detailMetaLabel.ForeColor = Color.FromArgb(148, 163, 184);
            detailMetaLabel.Location = new Point(30, 55);
            detailMetaLabel.Name = "detailMetaLabel";
            detailMetaLabel.Size = new Size(369, 41);
            detailMetaLabel.TabIndex = 1;
            detailMetaLabel.Text = "اختر ملاحظة لعرض تفاصيلها";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            contentLabel.ForeColor = Color.FromArgb(148, 163, 184);
            contentLabel.Location = new Point(30, 95);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new Size(134, 46);
            contentLabel.TabIndex = 2;
            contentLabel.Text = "المحتوى";
            // 
            // detailContentTextBox
            // 
            detailContentTextBox.AnimateReadOnly = false;
            detailContentTextBox.BackgroundImageLayout = ImageLayout.None;
            detailContentTextBox.CharacterCasing = CharacterCasing.Normal;
            detailContentTextBox.Depth = 0;
            detailContentTextBox.Font = new Font("Segoe UI", 11F);
            detailContentTextBox.HideSelection = true;
            detailContentTextBox.Location = new Point(30, 120);
            detailContentTextBox.MaxLength = 32767;
            detailContentTextBox.MouseState = MaterialSkin.MouseState.OUT;
            detailContentTextBox.Name = "detailContentTextBox";
            detailContentTextBox.PasswordChar = '\0';
            detailContentTextBox.ReadOnly = false;
            detailContentTextBox.ScrollBars = ScrollBars.Vertical;
            detailContentTextBox.SelectedText = "";
            detailContentTextBox.SelectionLength = 0;
            detailContentTextBox.SelectionStart = 0;
            detailContentTextBox.ShortcutsEnabled = true;
            detailContentTextBox.Size = new Size(610, 215);
            detailContentTextBox.TabIndex = 3;
            detailContentTextBox.TabStop = false;
            detailContentTextBox.TextAlign = HorizontalAlignment.Right;
            detailContentTextBox.UseSystemPasswordChar = false;
            // 
            // categoryPanel
            // 
            categoryPanel.BackColor = Color.FromArgb(21, 33, 52);
            categoryPanel.Location = new Point(30, 355);
            categoryPanel.Name = "categoryPanel";
            categoryPanel.Size = new Size(610, 70);
            categoryPanel.TabIndex = 4;
            // 
            // categoryComboBox
            // 
            categoryComboBox.AutoResize = false;
            categoryComboBox.BackColor = Color.FromArgb(21, 33, 52);
            categoryComboBox.Depth = 0;
            categoryComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            categoryComboBox.DropDownHeight = 217;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.DropDownWidth = 200;
            categoryComboBox.Font = new Font("Segoe UI", 10F);
            categoryComboBox.ForeColor = Color.FromArgb(241, 245, 249);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.IntegralHeight = false;
            categoryComboBox.ItemHeight = 43;
            categoryComboBox.Location = new Point(350, 365);
            categoryComboBox.MaxDropDownItems = 5;
            categoryComboBox.MouseState = MaterialSkin.MouseState.OUT;
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(290, 49);
            categoryComboBox.StartIndex = 0;
            categoryComboBox.TabIndex = 5;
            // 
            // importantCheckBox
            // 
            importantCheckBox.AutoSize = true;
            importantCheckBox.BackColor = Color.FromArgb(21, 33, 52);
            importantCheckBox.FlatStyle = FlatStyle.Flat;
            importantCheckBox.Font = new Font("Segoe UI", 10F);
            importantCheckBox.ForeColor = Color.FromArgb(241, 245, 249);
            importantCheckBox.Location = new Point(55, 380);
            importantCheckBox.Name = "importantCheckBox";
            importantCheckBox.Size = new Size(126, 50);
            importantCheckBox.TabIndex = 6;
            importantCheckBox.Text = "مهمة";
            importantCheckBox.UseVisualStyleBackColor = false;
            // 
            // pinnedCheckBox
            // 
            pinnedCheckBox.AutoSize = true;
            pinnedCheckBox.BackColor = Color.FromArgb(21, 33, 52);
            pinnedCheckBox.FlatStyle = FlatStyle.Flat;
            pinnedCheckBox.Font = new Font("Segoe UI", 10F);
            pinnedCheckBox.ForeColor = Color.FromArgb(241, 245, 249);
            pinnedCheckBox.Location = new Point(155, 380);
            pinnedCheckBox.Name = "pinnedCheckBox";
            pinnedCheckBox.Size = new Size(122, 50);
            pinnedCheckBox.TabIndex = 7;
            pinnedCheckBox.Text = "مثبتة";
            pinnedCheckBox.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editButton.Density = MaterialButton.MaterialButtonDensity.Default;
            editButton.Depth = 0;
            editButton.HighEmphasis = true;
            editButton.Icon = null;
            editButton.Location = new Point(0, 0);
            editButton.Margin = new Padding(4, 6, 4, 6);
            editButton.MouseState = MaterialSkin.MouseState.HOVER;
            editButton.Name = "editButton";
            editButton.NoAccentTextColor = Color.Empty;
            editButton.Size = new Size(64, 36);
            editButton.TabIndex = 8;
            editButton.Type = MaterialButton.MaterialButtonType.Contained;
            editButton.UseAccentColor = false;
            // 
            // pinButton
            // 
            pinButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pinButton.Density = MaterialButton.MaterialButtonDensity.Default;
            pinButton.Depth = 0;
            pinButton.HighEmphasis = true;
            pinButton.Icon = null;
            pinButton.Location = new Point(0, 0);
            pinButton.Margin = new Padding(4, 6, 4, 6);
            pinButton.MouseState = MaterialSkin.MouseState.HOVER;
            pinButton.Name = "pinButton";
            pinButton.NoAccentTextColor = Color.Empty;
            pinButton.Size = new Size(64, 36);
            pinButton.TabIndex = 9;
            pinButton.Type = MaterialButton.MaterialButtonType.Contained;
            pinButton.UseAccentColor = false;
            // 
            // deleteButton
            // 
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.Density = MaterialButton.MaterialButtonDensity.Default;
            deleteButton.Depth = 0;
            deleteButton.HighEmphasis = true;
            deleteButton.Icon = null;
            deleteButton.Location = new Point(0, 0);
            deleteButton.Margin = new Padding(4, 6, 4, 6);
            deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            deleteButton.Name = "deleteButton";
            deleteButton.NoAccentTextColor = Color.Empty;
            deleteButton.Size = new Size(64, 36);
            deleteButton.TabIndex = 10;
            deleteButton.Type = MaterialButton.MaterialButtonType.Contained;
            deleteButton.UseAccentColor = false;
            // 
            // saveButton
            // 
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.Density = MaterialButton.MaterialButtonDensity.Default;
            saveButton.Depth = 0;
            saveButton.HighEmphasis = true;
            saveButton.Icon = null;
            saveButton.Location = new Point(0, 0);
            saveButton.Margin = new Padding(4, 6, 4, 6);
            saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            saveButton.Name = "saveButton";
            saveButton.NoAccentTextColor = Color.Empty;
            saveButton.Size = new Size(64, 36);
            saveButton.TabIndex = 11;
            saveButton.Type = MaterialButton.MaterialButtonType.Contained;
            saveButton.UseAccentColor = false;
            saveButton.Visible = false;
            // 
            // cancelButton
            // 
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Density = MaterialButton.MaterialButtonDensity.Default;
            cancelButton.Depth = 0;
            cancelButton.HighEmphasis = true;
            cancelButton.Icon = null;
            cancelButton.Location = new Point(0, 0);
            cancelButton.Margin = new Padding(4, 6, 4, 6);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = Color.Empty;
            cancelButton.Size = new Size(64, 36);
            cancelButton.TabIndex = 12;
            cancelButton.Type = MaterialButton.MaterialButtonType.Contained;
            cancelButton.UseAccentColor = false;
            cancelButton.Visible = false;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(12, 21, 36);
            sidebarPanel.Controls.Add(logoLabel);
            sidebarPanel.Controls.Add(logoSubLabel);
            sidebarPanel.Controls.Add(dashboardButton);
            sidebarPanel.Controls.Add(notesNavButton);
            sidebarPanel.Controls.Add(tasksButton);
            sidebarPanel.Controls.Add(projectsButton);
            sidebarPanel.Controls.Add(developersButton);
            sidebarPanel.Controls.Add(settingsButton);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(320, 900);
            sidebarPanel.TabIndex = 1;
            // 
            // logoLabel
            // 
            logoLabel.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            logoLabel.ForeColor = Color.FromArgb(241, 245, 249);
            logoLabel.Location = new Point(30, 35);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(160, 63);
            logoLabel.TabIndex = 0;
            logoLabel.Text = "SOLVIX";
            logoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logoSubLabel
            // 
            logoSubLabel.Font = new Font("Segoe UI", 8.5F);
            logoSubLabel.ForeColor = Color.FromArgb(148, 163, 184);
            logoSubLabel.Location = new Point(30, 126);
            logoSubLabel.Name = "logoSubLabel";
            logoSubLabel.Size = new Size(160, 52);
            logoSubLabel.TabIndex = 1;
            logoSubLabel.Text = "Management System";
            // 
            // dashboardButton
            // 
            dashboardButton.Location = new Point(0, 0);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(75, 23);
            dashboardButton.TabIndex = 2;
            // 
            // notesNavButton
            // 
            notesNavButton.Location = new Point(0, 0);
            notesNavButton.Name = "notesNavButton";
            notesNavButton.Size = new Size(75, 23);
            notesNavButton.TabIndex = 3;
            // 
            // tasksButton
            // 
            tasksButton.Location = new Point(0, 0);
            tasksButton.Name = "tasksButton";
            tasksButton.Size = new Size(75, 23);
            tasksButton.TabIndex = 4;
            // 
            // projectsButton
            // 
            projectsButton.Location = new Point(0, 0);
            projectsButton.Name = "projectsButton";
            projectsButton.Size = new Size(75, 23);
            projectsButton.TabIndex = 5;
            // 
            // developersButton
            // 
            developersButton.Location = new Point(0, 0);
            developersButton.Name = "developersButton";
            developersButton.Size = new Size(75, 23);
            developersButton.TabIndex = 6;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(0, 0);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(75, 23);
            settingsButton.TabIndex = 7;
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 15, 27);
            ClientSize = new Size(1440, 900);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(241, 245, 249);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notes";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الملاحظات";
            mainPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            notesListPanel.ResumeLayout(false);
            notesListPanel.PerformLayout();
            detailPanel.ResumeLayout(false);
            detailPanel.PerformLayout();
            sidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        // =============================================================
        // HELPERS
        // =============================================================

        private void ConfigureNavButton(
            Button button,
            string text,
            int y,
            bool selected)
        {
            button.BackColor = selected
                ? Color.FromArgb(24, 79, 170)
                : Color.Transparent;

            button.FlatAppearance.BorderSize = 0;

            if (selected)
                button.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(30, 92, 195);
            else
                button.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(20, 34, 54);

            button.FlatStyle = FlatStyle.Flat;

            button.Font = new Font(
                "Segoe UI",
                10.5F,
                selected
                    ? FontStyle.Bold
                    : FontStyle.Regular,
                GraphicsUnit.Point);

            button.ForeColor = selected
                ? Color.White
                : Color.FromArgb(148, 163, 184);

            button.Location = new Point(15, y);
            button.Name = text;
            button.Size = new Size(190, 45);
            button.TabIndex = y;
            button.Text = text;
            button.TextAlign = ContentAlignment.MiddleRight;
            button.UseVisualStyleBackColor = false;
        }

        private void ConfigureStatCard(
            Panel card,
            Label value,
            Label title,
            string valueText,
            string titleText,
            int x,
            int y,
            int width,
            int height,
            Color valueColor)
        {
            card.BackColor = Color.FromArgb(17, 27, 43);
            card.Location = new Point(x, y);
            card.Name = titleText;
            card.Size = new Size(width, height);
            card.TabIndex = 0;

            value.AutoSize = true;
            value.Font = new Font(
                "Segoe UI",
                25F,
                FontStyle.Bold,
                GraphicsUnit.Point);

            value.ForeColor = valueColor;
            value.Location = new Point(22, 15);
            value.Name = titleText + "Value";
            value.Size = new Size(45, 45);
            value.TabIndex = 0;
            value.Text = valueText;

            title.AutoSize = true;
            title.Font = new Font(
                "Segoe UI",
                9.5F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            title.ForeColor = Color.FromArgb(148, 163, 184);
            title.Location = new Point(25, 65);
            title.Name = titleText + "Title";
            title.Size = new Size(100, 18);
            title.TabIndex = 1;
            title.Text = titleText;
        }

        private void ConfigureActionButton(
            MaterialButton button,
            string text,
            Point location,
            Size size,
            bool accent)
        {
            button.AutoSize = false;

            button.Density =
                MaterialButton.MaterialButtonDensity.Default;

            button.Depth = 0;
            button.HighEmphasis = true;
            button.Icon = null;
            button.Location = location;
            button.Margin = new Padding(0);
            button.MouseState = MaterialSkin.MouseState.HOVER;
            button.NoAccentTextColor = Color.Empty;
            button.Size = size;
            button.Text = text;

            button.Type = accent
                ? MaterialButton.MaterialButtonType.Contained
                : MaterialButton.MaterialButtonType.Outlined;

            button.UseAccentColor = accent;
            button.UseVisualStyleBackColor = true;
        }
    }
}