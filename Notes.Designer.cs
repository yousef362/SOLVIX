namespace SOLVIX
{
    partial class Notes
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerAccent;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel totalCard;
        private System.Windows.Forms.Panel importantCard;
        private System.Windows.Forms.Panel pinnedCard;
        private System.Windows.Forms.Panel todayCard;
        private System.Windows.Forms.Label totalTitleLabel;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Label importantTitleLabel;
        private System.Windows.Forms.Label importantValueLabel;
        private System.Windows.Forms.Label pinnedTitleLabel;
        private System.Windows.Forms.Label pinnedValueLabel;
        private System.Windows.Forms.Label todayTitleLabel;
        private System.Windows.Forms.Label todayValueLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Panel listHeaderPanel;
        private System.Windows.Forms.Label listTitleLabel;
        private System.Windows.Forms.Label listCountLabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Panel notesScrollPanel;
        private System.Windows.Forms.Panel detailHeaderPanel;
        private System.Windows.Forms.Label detailAccent;
        private System.Windows.Forms.Label detailHeaderLabel;
        private System.Windows.Forms.Button pinButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label noteBadge;
        private System.Windows.Forms.Panel displayContainer;
        private System.Windows.Forms.Label detailTitleLabel;
        private System.Windows.Forms.Label detailDateLabel;
        private System.Windows.Forms.Label detailContentLabel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label categoryValue;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label createdValue;
        private System.Windows.Forms.Label updatedLabel;
        private System.Windows.Forms.Label updatedValue;
        private System.Windows.Forms.Panel editorContainer;
        private System.Windows.Forms.Label editorHeading;
        private System.Windows.Forms.Label titleCaption;
        private System.Windows.Forms.TextBox titleEditBox;
        private System.Windows.Forms.Label contentCaption;
        private System.Windows.Forms.RichTextBox contentEditBox;
        private System.Windows.Forms.Label categoryCaption;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.CheckBox importantCheckBox;
        private System.Windows.Forms.CheckBox pinnedCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;

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
            headerAccent = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            subtitleLabel = new System.Windows.Forms.Label();
            toolbarPanel = new System.Windows.Forms.Panel();
            searchBox = new System.Windows.Forms.TextBox();
            addNoteButton = new System.Windows.Forms.Button();
            statsPanel = new System.Windows.Forms.Panel();
            totalCard = CreateCard();
            importantCard = CreateCard();
            pinnedCard = CreateCard();
            todayCard = CreateCard();
            totalTitleLabel = CreateCardTitle();
            totalValueLabel = CreateCardValue();
            importantTitleLabel = CreateCardTitle();
            importantValueLabel = CreateCardValue();
            pinnedTitleLabel = CreateCardTitle();
            pinnedValueLabel = CreateCardValue();
            todayTitleLabel = CreateCardTitle();
            todayValueLabel = CreateCardValue();
            contentPanel = new System.Windows.Forms.Panel();
            listPanel = new System.Windows.Forms.Panel();
            detailPanel = new System.Windows.Forms.Panel();
            listHeaderPanel = new System.Windows.Forms.Panel();
            listTitleLabel = new System.Windows.Forms.Label();
            listCountLabel = new System.Windows.Forms.Label();
            filterButton = new System.Windows.Forms.Button();
            notesScrollPanel = new System.Windows.Forms.Panel();
            detailHeaderPanel = new System.Windows.Forms.Panel();
            detailAccent = new System.Windows.Forms.Label();
            detailHeaderLabel = new System.Windows.Forms.Label();
            pinButton = new System.Windows.Forms.Button();
            editButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            noteBadge = new System.Windows.Forms.Label();
            displayContainer = new System.Windows.Forms.Panel();
            detailTitleLabel = new System.Windows.Forms.Label();
            detailDateLabel = new System.Windows.Forms.Label();
            detailContentLabel = new System.Windows.Forms.Label();
            infoPanel = new System.Windows.Forms.Panel();
            categoryLabel = new System.Windows.Forms.Label();
            categoryValue = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            createdValue = new System.Windows.Forms.Label();
            updatedLabel = new System.Windows.Forms.Label();
            updatedValue = new System.Windows.Forms.Label();
            editorContainer = new System.Windows.Forms.Panel();
            editorHeading = new System.Windows.Forms.Label();
            titleCaption = new System.Windows.Forms.Label();
            titleEditBox = new System.Windows.Forms.TextBox();
            contentCaption = new System.Windows.Forms.Label();
            contentEditBox = new System.Windows.Forms.RichTextBox();
            categoryCaption = new System.Windows.Forms.Label();
            categoryCombo = new System.Windows.Forms.ComboBox();
            importantCheckBox = new System.Windows.Forms.CheckBox();
            pinnedCheckBox = new System.Windows.Forms.CheckBox();
            saveButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();

            SuspendLayout();

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

            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.BackColor = System.Drawing.Color.White;
            mainPanel.Padding = new System.Windows.Forms.Padding(20);
            mainPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Height = 72;
            headerPanel.BackColor = System.Drawing.Color.White;
            headerAccent.BackColor = System.Drawing.Color.DodgerBlue;
            headerAccent.Location = new System.Drawing.Point(0, 2);
            headerAccent.Size = new System.Drawing.Size(4, 52);
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(18, 2);
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            titleLabel.Text = "الملاحظات";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            subtitleLabel.AutoSize = true;
            subtitleLabel.Location = new System.Drawing.Point(20, 44);
            subtitleLabel.Text = "";
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(headerAccent);

            toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            toolbarPanel.Height = 58;
            toolbarPanel.BackColor = System.Drawing.Color.White;
            searchBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            searchBox.Location = new System.Drawing.Point(390, 7);
            searchBox.Size = new System.Drawing.Size(390, 32);
            searchBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            addNoteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            addNoteButton.Location = new System.Drawing.Point(210, 6);
            addNoteButton.Size = new System.Drawing.Size(170, 36);
            addNoteButton.Text = "إضافة ملاحظة";
            toolbarPanel.Controls.Add(addNoteButton);
            toolbarPanel.Controls.Add(searchBox);

            statsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            statsPanel.Height = 100;
            statsPanel.BackColor = System.Drawing.Color.White;
            ConfigureCard(totalCard, totalTitleLabel, totalValueLabel, "إجمالي الملاحظات", 0);
            ConfigureCard(importantCard, importantTitleLabel, importantValueLabel, "ملاحظات مهمة", 250);
            ConfigureCard(pinnedCard, pinnedTitleLabel, pinnedValueLabel, "المثبتة", 500);
            ConfigureCard(todayCard, todayTitleLabel, todayValueLabel, "ملاحظات اليوم", 750);

            contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            contentPanel.BackColor = System.Drawing.Color.White;
            contentPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);

            listPanel.Dock = System.Windows.Forms.DockStyle.Left;
            listPanel.Width = 430;
            listPanel.BackColor = System.Drawing.Color.White;
            listPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            listHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            listHeaderPanel.Height = 70;
            listHeaderPanel.BackColor = System.Drawing.Color.White;
            listTitleLabel.AutoSize = true;
            listTitleLabel.Location = new System.Drawing.Point(18, 10);
            listTitleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            listTitleLabel.Text = "قائمة الملاحظات";
            listCountLabel.AutoSize = true;
            listCountLabel.Location = new System.Drawing.Point(18, 40);
            listCountLabel.ForeColor = System.Drawing.Color.Gray;
            listCountLabel.Text = "0 ملاحظة";
            filterButton.Location = new System.Drawing.Point(18, 18);
            filterButton.Size = new System.Drawing.Size(88, 32);
            filterButton.Text = "الكل";
            listHeaderPanel.Controls.Add(filterButton);
            listHeaderPanel.Controls.Add(listCountLabel);
            listHeaderPanel.Controls.Add(listTitleLabel);
            notesScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            notesScrollPanel.AutoScroll = true;
            notesScrollPanel.BackColor = System.Drawing.Color.White;
            notesScrollPanel.Padding = new System.Windows.Forms.Padding(8);
            notesScrollPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            listPanel.Controls.Add(notesScrollPanel);
            listPanel.Controls.Add(listHeaderPanel);

            detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            detailPanel.BackColor = System.Drawing.Color.White;
            detailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            detailHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            detailHeaderPanel.Height = 68;
            detailHeaderPanel.BackColor = System.Drawing.Color.White;
            detailAccent.BackColor = System.Drawing.Color.DodgerBlue;
            detailAccent.Location = new System.Drawing.Point(0, 0);
            detailAccent.Size = new System.Drawing.Size(4, 52);
            detailHeaderLabel.AutoSize = true;
            detailHeaderLabel.Location = new System.Drawing.Point(20, 18);
            detailHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            detailHeaderLabel.Text = "تفاصيل الملاحظة";
            noteBadge.Location = new System.Drawing.Point(280, 18);
            noteBadge.Size = new System.Drawing.Size(76, 28);
            noteBadge.Text = "ملاحظة";
            pinButton.Location = new System.Drawing.Point(370, 14);
            pinButton.Size = new System.Drawing.Size(38, 38);
            pinButton.Text = "⚐";
            editButton.Location = new System.Drawing.Point(414, 14);
            editButton.Size = new System.Drawing.Size(38, 38);
            editButton.Text = "✎";
            deleteButton.Location = new System.Drawing.Point(458, 14);
            deleteButton.Size = new System.Drawing.Size(38, 38);
            deleteButton.Text = "⌫";
            detailHeaderPanel.Controls.Add(deleteButton);
            detailHeaderPanel.Controls.Add(editButton);
            detailHeaderPanel.Controls.Add(pinButton);
            detailHeaderPanel.Controls.Add(noteBadge);
            detailHeaderPanel.Controls.Add(detailHeaderLabel);
            detailHeaderPanel.Controls.Add(detailAccent);

            displayContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            displayContainer.BackColor = System.Drawing.Color.White;
            displayContainer.Padding = new System.Windows.Forms.Padding(24);
            detailTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            detailTitleLabel.Height = 58;
            detailTitleLabel.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            detailTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            detailDateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            detailDateLabel.Height = 28;
            detailDateLabel.ForeColor = System.Drawing.Color.Gray;
            detailDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            detailContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            detailContentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            detailContentLabel.AutoEllipsis = false;
            infoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            infoPanel.Height = 90;
            infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ConfigureInfo(categoryLabel, categoryValue, "التصنيف", 12);
            ConfigureInfo(createdLabel, createdValue, "تاريخ الإنشاء", 180);
            ConfigureInfo(updatedLabel, updatedValue, "آخر تحديث", 350);
            displayContainer.Controls.Add(detailContentLabel);
            displayContainer.Controls.Add(detailDateLabel);
            displayContainer.Controls.Add(detailTitleLabel);
            displayContainer.Controls.Add(infoPanel);

            editorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            editorContainer.BackColor = System.Drawing.Color.White;
            editorContainer.Padding = new System.Windows.Forms.Padding(24);
            editorContainer.Visible = false;
            editorHeading.AutoSize = true;
            editorHeading.Location = new System.Drawing.Point(24, 24);
            editorHeading.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            editorHeading.Text = "إضافة ملاحظة جديدة";
            titleCaption.AutoSize = true;
            titleCaption.Location = new System.Drawing.Point(24, 68);
            titleCaption.Text = "العنوان";
            titleEditBox.Location = new System.Drawing.Point(24, 90);
            titleEditBox.Size = new System.Drawing.Size(700, 32);
            titleEditBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            contentCaption.AutoSize = true;
            contentCaption.Location = new System.Drawing.Point(24, 135);
            contentCaption.Text = "المحتوى";
            contentEditBox.Location = new System.Drawing.Point(24, 157);
            contentEditBox.Size = new System.Drawing.Size(700, 280);
            contentEditBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            contentEditBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            categoryCaption.AutoSize = true;
            categoryCaption.Location = new System.Drawing.Point(24, 455);
            categoryCaption.Text = "التصنيف";
            categoryCombo.Location = new System.Drawing.Point(24, 477);
            categoryCombo.Size = new System.Drawing.Size(220, 32);
            categoryCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            importantCheckBox.AutoSize = true;
            importantCheckBox.Location = new System.Drawing.Point(270, 480);
            importantCheckBox.Text = "مهم";
            pinnedCheckBox.AutoSize = true;
            pinnedCheckBox.Location = new System.Drawing.Point(350, 480);
            pinnedCheckBox.Text = "مثبت";
            saveButton.Location = new System.Drawing.Point(24, 525);
            saveButton.Size = new System.Drawing.Size(150, 40);
            saveButton.Text = "حفظ";
            cancelButton.Location = new System.Drawing.Point(184, 525);
            cancelButton.Size = new System.Drawing.Size(120, 40);
            cancelButton.Text = "إلغاء";
            editorContainer.Controls.Add(cancelButton);
            editorContainer.Controls.Add(saveButton);
            editorContainer.Controls.Add(pinnedCheckBox);
            editorContainer.Controls.Add(importantCheckBox);
            editorContainer.Controls.Add(categoryCombo);
            editorContainer.Controls.Add(categoryCaption);
            editorContainer.Controls.Add(contentEditBox);
            editorContainer.Controls.Add(contentCaption);
            editorContainer.Controls.Add(titleEditBox);
            editorContainer.Controls.Add(titleCaption);
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

        private static Panel CreateCard() => new Panel { BackColor = System.Drawing.Color.White, BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle, Height = 84 };
        private static Label CreateCardTitle() => new Label { AutoSize = false, Width = 200, Height = 24, TextAlign = System.Drawing.ContentAlignment.MiddleRight, ForeColor = System.Drawing.Color.Gray };
        private static Label CreateCardValue() => new Label { AutoSize = false, Width = 200, Height = 42, TextAlign = System.Drawing.ContentAlignment.MiddleRight, Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold) };

        private void ConfigureCard(Panel card, Label title, Label value, string text, int left)
        {
            card.Location = new System.Drawing.Point(left, 8);
            card.Width = 240;
            title.Location = new System.Drawing.Point(18, 8);
            title.Text = text;
            value.Location = new System.Drawing.Point(18, 32);
            value.Text = "0";
            card.Controls.Add(value);
            card.Controls.Add(title);
            statsPanel.Controls.Add(card);
        }

        private static void ConfigureInfo(Label label, Label value, string text, int left)
        {
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(left, 12);
            label.Text = text;
            value.AutoSize = true;
            value.Location = new System.Drawing.Point(left, 38);
            value.Text = "-";
            value.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        }
    }
}
