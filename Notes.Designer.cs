namespace SOLVIX
{
    partial class Notes
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainCard = new MaterialSkin.Controls.MaterialCard();
            headerCard = new MaterialSkin.Controls.MaterialCard();
            totalCard = new MaterialSkin.Controls.MaterialCard();
            importantCard = new MaterialSkin.Controls.MaterialCard();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pageTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            pageSubtitleLabel = new MaterialSkin.Controls.MaterialLabel();
            searchTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            addNoteButton = new MaterialSkin.Controls.MaterialButton();
            filterButton = new MaterialSkin.Controls.MaterialButton();
            pinnedCard = new MaterialSkin.Controls.MaterialCard();
            todayCard = new MaterialSkin.Controls.MaterialCard();
            todayValueLabel = new MaterialSkin.Controls.MaterialLabel();
            pinnedValueLabel = new MaterialSkin.Controls.MaterialLabel();
            importantValueLabel = new MaterialSkin.Controls.MaterialLabel();
            totalValueLabel = new MaterialSkin.Controls.MaterialLabel();
            notesListBox = new MaterialSkin.Controls.MaterialListBox();
            detailCard = new MaterialSkin.Controls.MaterialCard();
            detailTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            detailContentTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            categoryComboBox = new MaterialSkin.Controls.MaterialComboBox();
            importantCheckBox = new MaterialSkin.Controls.MaterialComboBox();
            pinnedCheckBox = new MaterialSkin.Controls.MaterialComboBox();
            editButton = new MaterialSkin.Controls.MaterialButton();
            cancelButton = new MaterialSkin.Controls.MaterialButton();
            saveButton = new MaterialSkin.Controls.MaterialButton();
            pinButton = new MaterialSkin.Controls.MaterialButton();
            deleteButton = new MaterialSkin.Controls.MaterialButton();
            contentDivider = new MaterialSkin.Controls.MaterialDivider();
            SuspendLayout();
            // 
            // mainCard
            // 
            mainCard.BackColor = Color.FromArgb(255, 255, 255);
            mainCard.Depth = 0;
            mainCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mainCard.Location = new Point(639, 36);
            mainCard.Margin = new Padding(14);
            mainCard.MouseState = MaterialSkin.MouseState.HOVER;
            mainCard.Name = "mainCard";
            mainCard.Padding = new Padding(14);
            mainCard.Size = new Size(573, 227);
            mainCard.TabIndex = 0;
            // 
            // headerCard
            // 
            headerCard.BackColor = Color.FromArgb(255, 255, 255);
            headerCard.Depth = 0;
            headerCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            headerCard.Location = new Point(59, 36);
            headerCard.Margin = new Padding(14);
            headerCard.MouseState = MaterialSkin.MouseState.HOVER;
            headerCard.Name = "headerCard";
            headerCard.Padding = new Padding(14);
            headerCard.Size = new Size(573, 227);
            headerCard.TabIndex = 1;
            // 
            // totalCard
            // 
            totalCard.BackColor = Color.FromArgb(255, 255, 255);
            totalCard.Depth = 0;
            totalCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            totalCard.Location = new Point(1222, 36);
            totalCard.Margin = new Padding(14);
            totalCard.MouseState = MaterialSkin.MouseState.HOVER;
            totalCard.Name = "totalCard";
            totalCard.Padding = new Padding(14);
            totalCard.Size = new Size(573, 227);
            totalCard.TabIndex = 3;
            // 
            // importantCard
            // 
            importantCard.BackColor = Color.FromArgb(255, 255, 255);
            importantCard.Depth = 0;
            importantCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            importantCard.Location = new Point(1802, 36);
            importantCard.Margin = new Padding(14);
            importantCard.MouseState = MaterialSkin.MouseState.HOVER;
            importantCard.Name = "importantCard";
            importantCard.Padding = new Padding(14);
            importantCard.Size = new Size(573, 227);
            importantCard.TabIndex = 2;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(0, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(107, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "materialLabel1";
            // 
            // pageTitleLabel
            // 
            pageTitleLabel.AutoSize = true;
            pageTitleLabel.Depth = 0;
            pageTitleLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            pageTitleLabel.Location = new Point(215, 397);
            pageTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            pageTitleLabel.Name = "pageTitleLabel";
            pageTitleLabel.Size = new Size(106, 19);
            pageTitleLabel.TabIndex = 5;
            pageTitleLabel.Text = "pageTitleLabel";
            // 
            // pageSubtitleLabel
            // 
            pageSubtitleLabel.AutoSize = true;
            pageSubtitleLabel.Depth = 0;
            pageSubtitleLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            pageSubtitleLabel.Location = new Point(215, 448);
            pageSubtitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            pageSubtitleLabel.Name = "pageSubtitleLabel";
            pageSubtitleLabel.Size = new Size(106, 19);
            pageSubtitleLabel.TabIndex = 6;
            pageSubtitleLabel.Text = "pageTitleLabel";
            // 
            // searchTextBox
            // 
            searchTextBox.AnimateReadOnly = false;
            searchTextBox.BackgroundImageLayout = ImageLayout.None;
            searchTextBox.CharacterCasing = CharacterCasing.Normal;
            searchTextBox.Depth = 0;
            searchTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchTextBox.HideSelection = true;
            searchTextBox.LeadingIcon = null;
            searchTextBox.Location = new Point(215, 523);
            searchTextBox.MaxLength = 32767;
            searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.PrefixSuffixText = null;
            searchTextBox.ReadOnly = false;
            searchTextBox.RightToLeft = RightToLeft.No;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.ShortcutsEnabled = true;
            searchTextBox.Size = new Size(625, 48);
            searchTextBox.TabIndex = 7;
            searchTextBox.TabStop = false;
            searchTextBox.Text = "materialTextBox21";
            searchTextBox.TextAlign = HorizontalAlignment.Left;
            searchTextBox.TrailingIcon = null;
            searchTextBox.UseSystemPasswordChar = false;
            searchTextBox.Click += searchTextBox_Click;
            // 
            // addNoteButton
            // 
            addNoteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addNoteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addNoteButton.Depth = 0;
            addNoteButton.HighEmphasis = true;
            addNoteButton.Icon = null;
            addNoteButton.Location = new Point(215, 602);
            addNoteButton.Margin = new Padding(4, 6, 4, 6);
            addNoteButton.MouseState = MaterialSkin.MouseState.HOVER;
            addNoteButton.Name = "addNoteButton";
            addNoteButton.NoAccentTextColor = Color.Empty;
            addNoteButton.Size = new Size(158, 36);
            addNoteButton.TabIndex = 8;
            addNoteButton.Text = "materialButton1";
            addNoteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addNoteButton.UseAccentColor = false;
            addNoteButton.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            filterButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filterButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            filterButton.Depth = 0;
            filterButton.HighEmphasis = true;
            filterButton.Icon = null;
            filterButton.Location = new Point(215, 673);
            filterButton.Margin = new Padding(4, 6, 4, 6);
            filterButton.MouseState = MaterialSkin.MouseState.HOVER;
            filterButton.Name = "filterButton";
            filterButton.NoAccentTextColor = Color.Empty;
            filterButton.Size = new Size(158, 36);
            filterButton.TabIndex = 9;
            filterButton.Text = "materialButton2";
            filterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            filterButton.UseAccentColor = false;
            filterButton.UseVisualStyleBackColor = true;
            // 
            // pinnedCard
            // 
            pinnedCard.BackColor = Color.FromArgb(255, 255, 255);
            pinnedCard.Depth = 0;
            pinnedCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pinnedCard.Location = new Point(1231, 331);
            pinnedCard.Margin = new Padding(14);
            pinnedCard.MouseState = MaterialSkin.MouseState.HOVER;
            pinnedCard.Name = "pinnedCard";
            pinnedCard.Padding = new Padding(14);
            pinnedCard.Size = new Size(573, 227);
            pinnedCard.TabIndex = 11;
            // 
            // todayCard
            // 
            todayCard.BackColor = Color.FromArgb(255, 255, 255);
            todayCard.Depth = 0;
            todayCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            todayCard.Location = new Point(1811, 331);
            todayCard.Margin = new Padding(14);
            todayCard.MouseState = MaterialSkin.MouseState.HOVER;
            todayCard.Name = "todayCard";
            todayCard.Padding = new Padding(14);
            todayCard.Size = new Size(573, 227);
            todayCard.TabIndex = 10;
            // 
            // todayValueLabel
            // 
            todayValueLabel.AutoSize = true;
            todayValueLabel.Depth = 0;
            todayValueLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            todayValueLabel.Location = new Point(545, 448);
            todayValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            todayValueLabel.Name = "todayValueLabel";
            todayValueLabel.Size = new Size(106, 19);
            todayValueLabel.TabIndex = 13;
            todayValueLabel.Text = "pageTitleLabel";
            // 
            // pinnedValueLabel
            // 
            pinnedValueLabel.AutoSize = true;
            pinnedValueLabel.Depth = 0;
            pinnedValueLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            pinnedValueLabel.Location = new Point(545, 397);
            pinnedValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            pinnedValueLabel.Name = "pinnedValueLabel";
            pinnedValueLabel.Size = new Size(107, 19);
            pinnedValueLabel.TabIndex = 12;
            pinnedValueLabel.Text = "materialLabel3";
            // 
            // importantValueLabel
            // 
            importantValueLabel.AutoSize = true;
            importantValueLabel.Depth = 0;
            importantValueLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            importantValueLabel.Location = new Point(391, 448);
            importantValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            importantValueLabel.Name = "importantValueLabel";
            importantValueLabel.Size = new Size(106, 19);
            importantValueLabel.TabIndex = 15;
            importantValueLabel.Text = "pageTitleLabel";
            // 
            // totalValueLabel
            // 
            totalValueLabel.AutoSize = true;
            totalValueLabel.Depth = 0;
            totalValueLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            totalValueLabel.Location = new Point(391, 397);
            totalValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            totalValueLabel.Name = "totalValueLabel";
            totalValueLabel.Size = new Size(107, 19);
            totalValueLabel.TabIndex = 14;
            totalValueLabel.Text = "materialLabel5";
            // 
            // notesListBox
            // 
            notesListBox.BackColor = Color.White;
            notesListBox.BorderColor = Color.LightGray;
            notesListBox.Depth = 0;
            notesListBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            notesListBox.Location = new Point(215, 752);
            notesListBox.MouseState = MaterialSkin.MouseState.HOVER;
            notesListBox.Name = "notesListBox";
            notesListBox.SelectedIndex = -1;
            notesListBox.SelectedItem = null;
            notesListBox.Size = new Size(236, 95);
            notesListBox.TabIndex = 16;
            // 
            // detailCard
            // 
            detailCard.BackColor = Color.FromArgb(255, 255, 255);
            detailCard.Depth = 0;
            detailCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            detailCard.Location = new Point(1540, 619);
            detailCard.Margin = new Padding(14);
            detailCard.MouseState = MaterialSkin.MouseState.HOVER;
            detailCard.Name = "detailCard";
            detailCard.Padding = new Padding(14);
            detailCard.Size = new Size(500, 250);
            detailCard.TabIndex = 17;
            // 
            // detailTitleLabel
            // 
            detailTitleLabel.AutoSize = true;
            detailTitleLabel.Depth = 0;
            detailTitleLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            detailTitleLabel.Location = new Point(689, 397);
            detailTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            detailTitleLabel.Name = "detailTitleLabel";
            detailTitleLabel.Size = new Size(106, 19);
            detailTitleLabel.TabIndex = 18;
            detailTitleLabel.Text = "pageTitleLabel";
            detailTitleLabel.Click += materialLabel2_Click;
            // 
            // detailContentTextBox
            // 
            detailContentTextBox.AnimateReadOnly = false;
            detailContentTextBox.BackgroundImageLayout = ImageLayout.None;
            detailContentTextBox.CharacterCasing = CharacterCasing.Normal;
            detailContentTextBox.Depth = 0;
            detailContentTextBox.HideSelection = true;
            detailContentTextBox.Location = new Point(215, 869);
            detailContentTextBox.MaxLength = 32767;
            detailContentTextBox.MouseState = MaterialSkin.MouseState.OUT;
            detailContentTextBox.Name = "detailContentTextBox";
            detailContentTextBox.PasswordChar = '\0';
            detailContentTextBox.ReadOnly = false;
            detailContentTextBox.ScrollBars = ScrollBars.None;
            detailContentTextBox.SelectedText = "";
            detailContentTextBox.SelectionLength = 0;
            detailContentTextBox.SelectionStart = 0;
            detailContentTextBox.ShortcutsEnabled = true;
            detailContentTextBox.Size = new Size(625, 250);
            detailContentTextBox.TabIndex = 19;
            detailContentTextBox.TabStop = false;
            detailContentTextBox.Text = "materialMultiLineTextBox21";
            detailContentTextBox.TextAlign = HorizontalAlignment.Left;
            detailContentTextBox.UseSystemPasswordChar = false;
            // 
            // categoryComboBox
            // 
            categoryComboBox.AutoResize = false;
            categoryComboBox.BackColor = Color.FromArgb(255, 255, 255);
            categoryComboBox.Depth = 0;
            categoryComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            categoryComboBox.DropDownHeight = 174;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.DropDownWidth = 121;
            categoryComboBox.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            categoryComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.IntegralHeight = false;
            categoryComboBox.ItemHeight = 43;
            categoryComboBox.Location = new Point(215, 1137);
            categoryComboBox.MaxDropDownItems = 4;
            categoryComboBox.MouseState = MaterialSkin.MouseState.OUT;
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(302, 49);
            categoryComboBox.StartIndex = 0;
            categoryComboBox.TabIndex = 20;
            // 
            // importantCheckBox
            // 
            importantCheckBox.AutoResize = false;
            importantCheckBox.BackColor = Color.FromArgb(255, 255, 255);
            importantCheckBox.Depth = 0;
            importantCheckBox.DrawMode = DrawMode.OwnerDrawVariable;
            importantCheckBox.DropDownHeight = 174;
            importantCheckBox.DropDownStyle = ComboBoxStyle.DropDownList;
            importantCheckBox.DropDownWidth = 121;
            importantCheckBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            importantCheckBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            importantCheckBox.FormattingEnabled = true;
            importantCheckBox.IntegralHeight = false;
            importantCheckBox.ItemHeight = 43;
            importantCheckBox.Location = new Point(538, 1137);
            importantCheckBox.MaxDropDownItems = 4;
            importantCheckBox.MouseState = MaterialSkin.MouseState.OUT;
            importantCheckBox.Name = "importantCheckBox";
            importantCheckBox.Size = new Size(302, 49);
            importantCheckBox.StartIndex = 0;
            importantCheckBox.TabIndex = 21;
            // 
            // pinnedCheckBox
            // 
            pinnedCheckBox.AutoResize = false;
            pinnedCheckBox.BackColor = Color.FromArgb(255, 255, 255);
            pinnedCheckBox.Depth = 0;
            pinnedCheckBox.DrawMode = DrawMode.OwnerDrawVariable;
            pinnedCheckBox.DropDownHeight = 174;
            pinnedCheckBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pinnedCheckBox.DropDownWidth = 121;
            pinnedCheckBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            pinnedCheckBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pinnedCheckBox.FormattingEnabled = true;
            pinnedCheckBox.IntegralHeight = false;
            pinnedCheckBox.ItemHeight = 43;
            pinnedCheckBox.Location = new Point(226, 1224);
            pinnedCheckBox.MaxDropDownItems = 4;
            pinnedCheckBox.MouseState = MaterialSkin.MouseState.OUT;
            pinnedCheckBox.Name = "pinnedCheckBox";
            pinnedCheckBox.Size = new Size(302, 49);
            pinnedCheckBox.StartIndex = 0;
            pinnedCheckBox.TabIndex = 22;
            // 
            // editButton
            // 
            editButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            editButton.Depth = 0;
            editButton.HighEmphasis = true;
            editButton.Icon = null;
            editButton.Location = new Point(411, 602);
            editButton.Margin = new Padding(4, 6, 4, 6);
            editButton.MouseState = MaterialSkin.MouseState.HOVER;
            editButton.Name = "editButton";
            editButton.NoAccentTextColor = Color.Empty;
            editButton.Size = new Size(158, 36);
            editButton.TabIndex = 23;
            editButton.Text = "materialButton1";
            editButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            editButton.UseAccentColor = false;
            editButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelButton.Depth = 0;
            cancelButton.HighEmphasis = true;
            cancelButton.Icon = null;
            cancelButton.Location = new Point(803, 602);
            cancelButton.Margin = new Padding(4, 6, 4, 6);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = Color.Empty;
            cancelButton.Size = new Size(158, 36);
            cancelButton.TabIndex = 25;
            cancelButton.Text = "materialButton3";
            cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelButton.UseAccentColor = false;
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveButton.Depth = 0;
            saveButton.HighEmphasis = true;
            saveButton.Icon = null;
            saveButton.Location = new Point(627, 673);
            saveButton.Margin = new Padding(4, 6, 4, 6);
            saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            saveButton.Name = "saveButton";
            saveButton.NoAccentTextColor = Color.Empty;
            saveButton.Size = new Size(158, 36);
            saveButton.TabIndex = 26;
            saveButton.Text = "materialButton4";
            saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            saveButton.UseAccentColor = false;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += materialButton4_Click;
            // 
            // pinButton
            // 
            pinButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pinButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            pinButton.Depth = 0;
            pinButton.HighEmphasis = true;
            pinButton.Icon = null;
            pinButton.Location = new Point(607, 602);
            pinButton.Margin = new Padding(4, 6, 4, 6);
            pinButton.MouseState = MaterialSkin.MouseState.HOVER;
            pinButton.Name = "pinButton";
            pinButton.NoAccentTextColor = Color.Empty;
            pinButton.Size = new Size(158, 36);
            pinButton.TabIndex = 27;
            pinButton.Text = "materialButton5";
            pinButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pinButton.UseAccentColor = false;
            pinButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteButton.Depth = 0;
            deleteButton.HighEmphasis = true;
            deleteButton.Icon = null;
            deleteButton.Location = new Point(421, 673);
            deleteButton.Margin = new Padding(4, 6, 4, 6);
            deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            deleteButton.Name = "deleteButton";
            deleteButton.NoAccentTextColor = Color.Empty;
            deleteButton.Size = new Size(158, 36);
            deleteButton.TabIndex = 28;
            deleteButton.Text = "materialButton6";
            deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteButton.UseAccentColor = false;
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // contentDivider
            // 
            contentDivider.BackColor = Color.FromArgb(30, 0, 0, 0);
            contentDivider.Depth = 0;
            contentDivider.Location = new Point(1383, 992);
            contentDivider.MouseState = MaterialSkin.MouseState.HOVER;
            contentDivider.Name = "contentDivider";
            contentDivider.Size = new Size(188, 58);
            contentDivider.TabIndex = 29;
            contentDivider.Text = "materialDivider1";
            // 
            // Notes
            // 
            ClientSize = new Size(2965, 1439);
            Controls.Add(contentDivider);
            Controls.Add(deleteButton);
            Controls.Add(pinButton);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(editButton);
            Controls.Add(pinnedCheckBox);
            Controls.Add(importantCheckBox);
            Controls.Add(categoryComboBox);
            Controls.Add(detailContentTextBox);
            Controls.Add(detailTitleLabel);
            Controls.Add(detailCard);
            Controls.Add(notesListBox);
            Controls.Add(importantValueLabel);
            Controls.Add(totalValueLabel);
            Controls.Add(todayValueLabel);
            Controls.Add(pinnedValueLabel);
            Controls.Add(pinnedCard);
            Controls.Add(todayCard);
            Controls.Add(filterButton);
            Controls.Add(addNoteButton);
            Controls.Add(searchTextBox);
            Controls.Add(pageSubtitleLabel);
            Controls.Add(pageTitleLabel);
            Controls.Add(materialLabel1);
            Controls.Add(totalCard);
            Controls.Add(importantCard);
            Controls.Add(headerCard);
            Controls.Add(mainCard);
            Name = "Notes";
            Load += Notes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialCard mainCard;
        private MaterialSkin.Controls.MaterialCard headerCard;
        private MaterialSkin.Controls.MaterialCard totalCard;
        private MaterialSkin.Controls.MaterialCard importantCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel pageTitleLabel;
        private MaterialSkin.Controls.MaterialLabel pageSubtitleLabel;
        private MaterialSkin.Controls.MaterialTextBox2 searchTextBox;
        private MaterialSkin.Controls.MaterialButton addNoteButton;
        private MaterialSkin.Controls.MaterialButton filterButton;
        private MaterialSkin.Controls.MaterialCard pinnedCard;
        private MaterialSkin.Controls.MaterialCard todayCard;
        private MaterialSkin.Controls.MaterialLabel todayValueLabel;
        private MaterialSkin.Controls.MaterialLabel pinnedValueLabel;
        private MaterialSkin.Controls.MaterialLabel importantValueLabel;
        private MaterialSkin.Controls.MaterialLabel totalValueLabel;
        private MaterialSkin.Controls.MaterialListBox notesListBox;
        private MaterialSkin.Controls.MaterialCard detailCard;
        private MaterialSkin.Controls.MaterialLabel detailTitleLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 detailContentTextBox;
        private MaterialSkin.Controls.MaterialComboBox categoryComboBox;
        private MaterialSkin.Controls.MaterialComboBox importantCheckBox;
        private MaterialSkin.Controls.MaterialComboBox pinnedCheckBox;
        private MaterialSkin.Controls.MaterialButton editButton;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialButton pinButton;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialDivider contentDivider;
    }
}
