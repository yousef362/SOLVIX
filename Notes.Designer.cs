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

            // Form
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1200, 800);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            ForeColor = System.Drawing.Color.Black;
            Name = "Notes";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "الملاحظات";

            // Main container
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.BackColor = System.Drawing.Color.White;
            mainPanel.Padding = new System.Windows.Forms.Padding(20);
            mainPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            // Header
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Height = 70;
            headerPanel.BackColor = System.Drawing.Color.White;

            headerAccent.Location = new System.Drawing.Point(0, 0);
            headerAccent.Size = new System.Drawing.Size(4, 52);

            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(20, 4);
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            titleLabel.Text = "الملاحظات";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            subtitleLabel.AutoSize = true;
            subtitleLabel.Location = new System.Drawing.Point(20, 43);
            subtitleLabel.Text = "";
            subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(headerAccent);

            // Toolbar
            toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            toolbarPanel.Height = 58;
            toolbarPanel.BackColor = System.Drawing.Color.White;

            addNoteButton.Location = new System.Drawing.Point(0, 6);
            addNoteButton.Size = new System.Drawing.Size(170, 42);
            addNoteButton.Text = "إضافة ملاحظة";

            searchBox.Location = new System.Drawing.Point(184, 6);
            searchBox.Size = new System.Drawing.Size(390, 42);
            searchBox.PlaceholderText = "ابحث في الملاحظات...";
            searchBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            toolbarPanel.Controls.Add(searchBox);
            toolbarPanel.Controls.Add(addNoteButton);

            // Statistics
            statsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            statsPanel.Height = 100;
            statsPanel.BackColor = System.Drawing.Color.White;

            totalCard.Location = new System.Drawing.Point(0, 8);
            totalCard.Size = new System.Drawing.Size(240, 84);
            importantCard.Location = new System.Drawing.Point(250, 8);
            importantCard.Size = new System.Drawing.Size(240, 84);
            pinnedCard.Location = new System.Drawing.Point(500, 8);
            pinnedCard.Size = new System.Drawing.Size(240, 84);
            todayCard.Location = new System.Drawing.Point(750, 8);
            todayCard.Size = new System.Drawing.Size(240, 84);

            statsPanel.Controls.Add(todayCard);
            statsPanel.Controls.Add(pinnedCard);
            statsPanel.Controls.Add(importantCard);
            statsPanel.Controls.Add(totalCard);

            // Content
            contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            contentPanel.BackColor = System.Drawing.Color.White;
            contentPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            contentPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            // List
            listPanel.Location = new System.Drawing.Point(0, 10);
            listPanel.Dock = System.Windows.Forms.DockStyle.Left;
            listPanel.Width = 430;
            listPanel.Padding = new System.Windows.Forms.Padding(0);

            listHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            listHeaderPanel.Height = 70;
            listHeaderPanel.BackColor = System.Drawing.Color.White;

            listAccent.Dock = System.Windows.Forms.DockStyle.Top;
            listAccent.Height = 3;

            listTitleLabel.AutoSize = true;
            listTitleLabel.Location = new System.Drawing.Point(18, 8);
            listTitleLabel.Text = "قائمة الملاحظات";

            listCountLabel.AutoSize = true;
            listCountLabel.Location = new System.Drawing.Point(18, 38);
            listCountLabel.Text = "0 ملاحظة";

            filterButton.Location = new System.Drawing.Point(18, 17);
            filterButton.Size = new System.Drawing.Size(88, 34);
            filterButton.Text = "الكل";

            listHeaderPanel.Controls.Add(filterButton);
            listHeaderPanel.Controls.Add(listCountLabel);
            listHeaderPanel.Controls.Add(listTitleLabel);
            listHeaderPanel.Controls.Add(listAccent);

            notesScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            notesScrollPanel.BackColor = System.Drawing.Color.White;
            notesScrollPanel.AutoScroll = true;
            notesScrollPanel.Padding = new System.Windows.Forms.Padding(8);
            notesScrollPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;

            listPanel.Controls.Add(notesScrollPanel);
            listPanel.Controls.Add(listHeaderPanel);

            // Detail
            detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            detailPanel.Padding = new System.Windows.Forms.Padding(0);

            detailHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            detailHeaderPanel.Height = 68;
            detailHeaderPanel.BackColor = System.Drawing.Color.White;
            detailHeaderPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            detailAccent.Dock = System.Windows.Forms.DockStyle.Top;
            detailAccent.Height = 3;

            detailHeaderLabel.AutoSize = true;
            detailHeaderLabel.Location = new System.Drawing.Point(20, 18);
            detailHeaderLabel.Text = "تفاصيل الملاحظة";

            noteBadge.Location = new System.Drawing.Point(280, 19);
            noteBadge.Size = new System.Drawing.Size(76, 28);
            noteBadge.Text = "ملاحظة";

            pinButton.Location = new System.Drawing.Point(370, 15);
            pinButton.Size = new System.Drawing.Size(38, 38);
            pinButton.Text = "⚐";

            editButton.Location = new System.Drawing.Point(414, 15);
            editButton.Size = new System.Drawing.Size(38, 38);
            editButton.Text = "✎";

            deleteButton.Location = new System.Drawing.Point(458, 15);
            deleteButton.Size = new System.Drawing.Size(38, 38);
            deleteButton.Text = "⌫";

            detailHeaderPanel.Controls.Add(deleteButton);
            detailHeaderPanel.Controls.Add(editButton);
            detailHeaderPanel.Controls.Add(pinButton);
            detailHeaderPanel.Controls.Add(noteBadge);
            detailHeaderPanel.Controls.Add(detailHeaderLabel);
            detailHeaderPanel.Controls.Add(detailAccent);

            // Display tools
            displayContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            displayContainer.BackColor = System.Drawing.Color.White;
            displayContainer.Padding = new System.Windows.Forms.Padding(24);
            displayContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            detailTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            detailTitleLabel.Height = 58;
            detailTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            detailDateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            detailDateLabel.Height = 28;
            detailDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            detailContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            detailContentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;

            infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            infoPanel.Height = 90;
            infoPanel.Padding = new System.Windows.Forms.Padding(12);

            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(12, 12);
            categoryLabel.Text = "التصنيف";

            categoryValue.AutoSize = true;
            categoryValue.Location = new System.Drawing.Point(12, 36);
            categoryValue.Text = "-";

            createdLabel.AutoSize = true;
            createdLabel.Location = new System.Drawing.Point(180, 12);
            createdLabel.Text = "تاريخ الإنشاء";

            createdValue.AutoSize = true;
            createdValue.Location = new System.Drawing.Point(180, 36);
            createdValue.Text = "-";

            updatedLabel.AutoSize = true;
            updatedLabel.Location = new System.Drawing.Point(350, 12);
            updatedLabel.Text = "آخر تحديث";

            updatedValue.AutoSize = true;
            updatedValue.Location = new System.Drawing.Point(350, 36);
            updatedValue.Text = "-";

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

            // Editor tools
            editorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            editorContainer.BackColor = System.Drawing.Color.White;
            editorContainer.Padding = new System.Windows.Forms.Padding(24);
            editorContainer.Visible = false;
            editorContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            editorHeading.AutoSize = true;
            editorHeading.Location = new System.Drawing.Point(24, 24);
            editorHeading.Text = "إضافة ملاحظة جديدة";

            titleEditBox.Location = new System.Drawing.Point(24, 70);
            titleEditBox.Size = new System.Drawing.Size(600, 36);

            contentEditBox.Location = new System.Drawing.Point(24, 120);
            contentEditBox.Size = new System.Drawing.Size(600, 300);
            contentEditBox.Multiline = true;
            contentEditBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;

            categoryCombo.Location = new System.Drawing.Point(24, 440);
            categoryCombo.Size = new System.Drawing.Size(220, 32);

            importantCheckBox.AutoSize = true;
            importantCheckBox.Location = new System.Drawing.Point(270, 444);
            importantCheckBox.Text = "مهم";

            pinnedCheckBox.AutoSize = true;
            pinnedCheckBox.Location = new System.Drawing.Point(350, 444);
            pinnedCheckBox.Text = "مثبت";

            saveButton.Location = new System.Drawing.Point(24, 490);
            saveButton.Size = new System.Drawing.Size(150, 40);
            saveButton.Text = "حفظ";

            cancelButton.Location = new System.Drawing.Point(184, 490);
            cancelButton.Size = new System.Drawing.Size(120, 40);
            cancelButton.Text = "إلغاء";

            editorContainer.Controls.Add(cancelButton);
            editorContainer.Controls.Add(saveButton);
            editorContainer.Controls.Add(pinnedCheckBox);
            editorContainer.Controls.Add(importantCheckBox);
            editorContainer.Controls.Add(categoryCombo);
            editorContainer.Controls.Add(contentEditBox);
            editorContainer.Controls.Add(titleEditBox);
            editorContainer.Controls.Add(editorHeading);

            detailPanel.Controls.Add(editorContainer);
            detailPanel.Controls.Add(displayContainer);
            detailPanel.Controls.Add(detailHeaderPanel);

            contentPanel.Controls.Add(detailPanel);
            contentPanel.Controls.Add(listPanel);

            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(statsPanel);
            mainPanel.Controls.Add(toolbarPanel);
            mainPanel.Controls.Add(headerPanel);

            Controls.Add(mainPanel);
            ResumeLayout(false);
        }
    }
}
