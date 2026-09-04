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
        private Panel listHeaderPanel;
        private Panel listAccent;
        private Label listTitleLabel;
        private Label listCountLabel;
        private Solvix.UI.OutlineButton filterButton;
        private Panel notesScrollPanel;

        private Solvix.UI.RoundedPanel detailPanel;

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
            components =
                new System.ComponentModel.Container();

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
            listHeaderPanel = new Panel();
            listAccent = new Panel();
            listTitleLabel = new Label();
            listCountLabel = new Label();
            filterButton = new Solvix.UI.OutlineButton();
            notesScrollPanel = new Panel();

            detailPanel = new Solvix.UI.RoundedPanel();

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

            contentEditBox =
                new Notes.DarkRichTextBox();

            editorBottomPanel = new Panel();

            categoryCaption = new Label();

            categoryCombo = new ComboBox();

            importantCheckBox =
                new Notes.DarkCheckBox();

            pinnedCheckBox =
                new Notes.DarkCheckBox();

            saveButton =
                new Solvix.UI.CustomButton();

            cancelButton =
                new Solvix.UI.OutlineButton();

            SuspendLayout();

            // =========================================================
            // MAIN
            // =========================================================

            mainPanel.Dock =
                DockStyle.Fill;

            mainPanel.BackColor =
                Solvix.UI.AppTheme.Background;

            mainPanel.Padding =
                new Padding(
                    30,
                    24,
                    30,
                    24);

            mainPanel.RightToLeft =
                RightToLeft.Yes;

            // =========================================================
            // HEADER
            // =========================================================

            headerPanel.Dock =
                DockStyle.Top;

            headerPanel.Height =
                82;

            headerPanel.BackColor =
                Color.Transparent;

            headerAccent.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            headerAccent.BackColor =
                Solvix.UI.AppTheme.Primary;

            headerAccent.Width =
                4;

            headerAccent.Height =
                56;

            headerAccent.Left =
                0;

            headerAccent.Top =
                2;

            titleLabel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            titleLabel.AutoSize =
                false;

            titleLabel.Width =
                360;

            titleLabel.Height =
                40;

            titleLabel.Top =
                0;

            titleLabel.Left =
                18;

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

            subtitleLabel.AutoSize =
                false;

            subtitleLabel.Width =
                440;

            subtitleLabel.Height =
                26;

            subtitleLabel.Top =
                42;

            subtitleLabel.Left =
                18;

            subtitleLabel.Font =
                Solvix.UI.AppTheme.Regular(9F);

            subtitleLabel.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            subtitleLabel.Text =
                "إدارة ملاحظاتك وتنظيم أفكارك من مكان واحد.";

            subtitleLabel.TextAlign =
                ContentAlignment.MiddleRight;

            subtitleLabel.RightToLeft =
                RightToLeft.Yes;

            headerPanel.Controls.Add(
                headerAccent);

            headerPanel.Controls.Add(
                subtitleLabel);

            headerPanel.Controls.Add(
                titleLabel);

            // =========================================================
            // TOOLBAR
            // =========================================================

            toolbarPanel.Dock =
                DockStyle.Top;

            toolbarPanel.Height =
                58;

            toolbarPanel.BackColor =
                Color.Transparent;

            addNoteButton.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            addNoteButton.Width =
                182;

            addNoteButton.Height =
                44;

            addNoteButton.Top =
                5;

            addNoteButton.Text =
                "إضافة ملاحظة";

            addNoteButton.Font =
                Solvix.UI.AppTheme.Bold(9.5F);

            searchBox.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            searchBox.Width =
                390;

            searchBox.Height =
                44;

            searchBox.Top =
                5;

            searchBox.PlaceholderText =
                "ابحث في الملاحظات...";

            searchBox.RightToLeft =
                RightToLeft.Yes;

            toolbarPanel.Controls.Add(
                addNoteButton);

            toolbarPanel.Controls.Add(
                searchBox);

            toolbarPanel.Resize += (_, _) =>
            {
                int width =
                    toolbarPanel.ClientSize.Width;

                addNoteButton.Left =
                    width -
                    addNoteButton.Width;

                searchBox.Left =
                    addNoteButton.Left -
                    searchBox.Width -
                    12;
            };

            // =========================================================
            // STATS
            // =========================================================

            statsPanel.Dock =
                DockStyle.Top;

            statsPanel.Height =
                108;

            statsPanel.BackColor =
                Color.Transparent;

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
                Solvix.UI.AppTheme.Warning);

            ConfigureStat(
                pinnedCard,
                "المثبتة",
                "0",
                "تظهر في أعلى القائمة",
                Solvix.UI.AppTheme.PrimaryHover);

            ConfigureStat(
                todayCard,
                "ملاحظات اليوم",
                "0",
                "تمت إضافتها أو تعديلها اليوم",
                Solvix.UI.AppTheme.Success);

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
                new Padding(
                    0,
                    10,
                    0,
                    0);

            // =========================================================
            // LIST
            // =========================================================

            listPanel.Dock =
                DockStyle.Left;

            listPanel.Width =
                430;

            listPanel.FillColor =
                Color.FromArgb(
                    10,
                    20,
                    33);

            listPanel.BorderColor =
                Solvix.UI.AppTheme.Border;

            listPanel.BorderThickness =
                1;

            listPanel.CornerRadius =
                15;

            listHeaderPanel.Dock =
                DockStyle.Top;

            listHeaderPanel.Height =
                78;

            listHeaderPanel.BackColor =
                Color.FromArgb(
                    14,
                    28,
                    47);

            listHeaderPanel.RightToLeft =
                RightToLeft.Yes;

            listAccent.Dock =
                DockStyle.Top;

            listAccent.Height =
                3;

            listAccent.BackColor =
                Solvix.UI.AppTheme.Primary;

            listTitleLabel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            listTitleLabel.AutoSize =
                false;

            listTitleLabel.Width =
                240;

            listTitleLabel.Height =
                31;

            listTitleLabel.Top =
                10;

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

            listCountLabel.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            listCountLabel.AutoSize =
                false;

            listCountLabel.Width =
                240;

            listCountLabel.Height =
                22;

            listCountLabel.Top =
                41;

            listCountLabel.Font =
                Solvix.UI.AppTheme.Regular(8F);

            listCountLabel.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            listCountLabel.Text =
                "لا توجد ملاحظات";

            listCountLabel.TextAlign =
                ContentAlignment.MiddleRight;

            listCountLabel.RightToLeft =
                RightToLeft.Yes;

            filterButton.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left;

            filterButton.Width =
                88;

            filterButton.Height =
                36;

            filterButton.Top =
                21;

            filterButton.Text =
                "الكل";

            filterButton.Font =
                Solvix.UI.AppTheme.Bold(8.5F);

            listHeaderPanel.Controls.Add(
                filterButton);

            listHeaderPanel.Controls.Add(
                listCountLabel);

            listHeaderPanel.Controls.Add(
                listTitleLabel);

            listHeaderPanel.Controls.Add(
                listAccent);

            listHeaderPanel.Resize += (_, _) =>
            {
                int width =
                    listHeaderPanel.ClientSize.Width;

                listTitleLabel.Left =
                    width -
                    listTitleLabel.Width -
                    18;

                listCountLabel.Left =
                    width -
                    listCountLabel.Width -
                    18;

                filterButton.Left =
                    18;
            };

            notesScrollPanel.Dock =
                DockStyle.Fill;

            notesScrollPanel.BackColor =
                Color.FromArgb(
                    7,
                    14,
                    24);

            notesScrollPanel.AutoScroll =
                true;

            notesScrollPanel.Padding =
                new Padding(
                    8,
                    8,
                    8,
                    12);

            notesScrollPanel.RightToLeft =
                RightToLeft.No;

            listPanel.Controls.Add(
                notesScrollPanel);

            listPanel.Controls.Add(
                listHeaderPanel);

            // =========================================================
            // DETAIL
            // =========================================================

            detailPanel.Dock =
                DockStyle.Fill;

            detailPanel.FillColor =
                Color.FromArgb(
                    13,
                    24,
                    39);

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
                Color.FromArgb(
                    14,
                    28,
                    47);

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

            detailHeaderLabel.Height =
                40;

            detailHeaderLabel.Width =
                260;

            detailHeaderLabel.Top =
                17;

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

            deleteButton.Size =
                new Size(
                    38,
                    38);

            deleteButton.Text =
                "⌫";

            deleteButton.BackColor =
                Color.Transparent;

            editButton.Size =
                new Size(
                    38,
                    38);

            editButton.Text =
                "✎";

            editButton.BackColor =
                Color.Transparent;

            pinButton.Size =
                new Size(
                    38,
                    38);

            pinButton.Text =
                "⚐";

            pinButton.BackColor =
                Color.Transparent;

            noteBadge.Size =
                new Size(
                    76,
                    28);

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

            detailHeaderPanel.Resize += (_, _) =>
            {
                int width =
                    detailHeaderPanel.ClientSize.Width;

                deleteButton.Left =
                    width -
                    deleteButton.Width -
                    18;

                deleteButton.Top = 16;

                editButton.Left =
                    deleteButton.Left -
                    editButton.Width -
                    8;

                editButton.Top = 16;

                pinButton.Left =
                    editButton.Left -
                    pinButton.Width -
                    8;

                pinButton.Top = 16;

                noteBadge.Left =
                    Math.Max(
                        18,
                        pinButton.Left -
                        noteBadge.Width -
                        12);

                noteBadge.Top = 21;

                detailHeaderLabel.Left =
                    18;

                detailHeaderLabel.Width =
                    Math.Max(
                        180,
                        noteBadge.Left -
                        28);
            };

            // =========================================================
            // DISPLAY
            // =========================================================

            displayContainer.Dock =
                DockStyle.Fill;

            displayContainer.BackColor =
                Color.Transparent;

            detailTitleLabel.Dock =
                DockStyle.Top;

            detailTitleLabel.Height =
                72;

            detailTitleLabel.Padding =
                new Padding(
                    28,
                    12,
                    28,
                    0);

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
                31;

            detailDateLabel.Padding =
                new Padding(
                    28,
                    0,
                    28,
                    0);

            detailDateLabel.Font =
                Solvix.UI.AppTheme.Regular(8.2F);

            detailDateLabel.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            detailDateLabel.TextAlign =
                ContentAlignment.MiddleRight;

            detailDateLabel.RightToLeft =
                RightToLeft.Yes;

            detailContentLabel.Dock =
                DockStyle.Fill;

            detailContentLabel.Padding =
                new Padding(
                    28,
                    20,
                    28,
                    18);

            detailContentLabel.Font =
                Solvix.UI.AppTheme.Regular(10F);

            detailContentLabel.ForeColor =
                Color.FromArgb(
                    215,
                    223,
                    235);

            detailContentLabel.Text =
                "اختر ملاحظة من القائمة أو أضف ملاحظة جديدة.";

            detailContentLabel.TextAlign =
                ContentAlignment.TopRight;

            detailContentLabel.RightToLeft =
                RightToLeft.Yes;

            detailContentLabel.AutoEllipsis =
                false;

            // =========================================================
            // INFO
            // =========================================================

            infoPanel.Dock =
                DockStyle.Bottom;

            infoPanel.Height =
                104;

            infoPanel.Margin =
                new Padding(
                    20);

            infoPanel.Padding =
                new Padding(
                    16);

            infoPanel.FillColor =
                Color.FromArgb(
                    17,
                    36,
                    59);

            infoPanel.BorderColor =
                Color.FromArgb(
                    39,
                    76,
                    116);

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
                categoryLabel);

            infoPanel.Controls.Add(
                categoryValue);

            infoPanel.Controls.Add(
                createdLabel);

            infoPanel.Controls.Add(
                createdValue);

            infoPanel.Controls.Add(
                updatedLabel);

            infoPanel.Controls.Add(
                updatedValue);

            infoPanel.Resize +=
                (_, _) => LayoutInfoPanel();

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
                new Padding(
                    26,
                    22,
                    26,
                    20);

            editorContainer.Visible =
                false;

            editorHeading.Dock =
                DockStyle.Top;

            editorHeading.Height =
                34;

            editorHeading.Font =
                Solvix.UI.AppTheme.Bold(16F);

            editorHeading.ForeColor =
                Solvix.UI.AppTheme.Text;

            editorHeading.Text =
                "إضافة ملاحظة جديدة";

            editorHeading.TextAlign =
                ContentAlignment.MiddleRight;

            editorHeading.RightToLeft =
                RightToLeft.Yes;

            editorSubHeading.Dock =
                DockStyle.Top;

            editorSubHeading.Height =
                27;

            editorSubHeading.Font =
                Solvix.UI.AppTheme.Regular(8F);

            editorSubHeading.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            editorSubHeading.Text =
                "أنشئ ملاحظتك واختَر التصنيف والحالة قبل الحفظ.";

            editorSubHeading.TextAlign =
                ContentAlignment.MiddleRight;

            editorSubHeading.RightToLeft =
                RightToLeft.Yes;

            // =========================================================
            // TITLE FRAME
            // =========================================================

            titleFrame.Dock =
                DockStyle.Top;

            titleFrame.Height =
                70;

            titleFrame.Padding =
                new Padding(
                    12,
                    26,
                    12,
                    0);

            titleFrame.BackColor =
                Solvix.UI.AppTheme.SurfaceAlt;

            titleFrame.BorderStyle =
                BorderStyle.FixedSingle;

            titleCaption.AutoSize =
                false;

            titleCaption.Height =
                22;

            titleCaption.Dock =
                DockStyle.Top;

            titleCaption.Text =
                "عنوان الملاحظة";

            titleCaption.Font =
                Solvix.UI.AppTheme.Bold(8.5F);

            titleCaption.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            titleCaption.TextAlign =
                ContentAlignment.MiddleRight;

            titleCaption.RightToLeft =
                RightToLeft.Yes;

            titleEditBox.Dock =
                DockStyle.Fill;

            titleEditBox.BorderStyle =
                BorderStyle.None;

            titleEditBox.BackColor =
                Solvix.UI.AppTheme.SurfaceAlt;

            titleEditBox.ForeColor =
                Solvix.UI.AppTheme.Text;

            titleEditBox.Font =
                Solvix.UI.AppTheme.Bold(10F);

            titleEditBox.TextAlign =
                HorizontalAlignment.Right;

            titleEditBox.RightToLeft =
                RightToLeft.Yes;

            titleEditBox.Multiline =
                false;

            titleFrame.Controls.Add(
                titleEditBox);

            titleFrame.Controls.Add(
                titleCaption);

            // =========================================================
            // CONTENT FRAME
            // =========================================================

            contentFrame.Dock =
                DockStyle.Fill;

            contentFrame.Padding =
                new Padding(
                    12,
                    29,
                    12,
                    10);

            contentFrame.BackColor =
                Solvix.UI.AppTheme.SurfaceAlt;

            contentFrame.BorderStyle =
                BorderStyle.FixedSingle;

            contentCaption.Dock =
                DockStyle.Top;

            contentCaption.Height =
                26;

            contentCaption.Text =
                "محتوى الملاحظة";

            contentCaption.Font =
                Solvix.UI.AppTheme.Bold(8.5F);

            contentCaption.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            contentCaption.TextAlign =
                ContentAlignment.MiddleRight;

            contentCaption.RightToLeft =
                RightToLeft.Yes;

            contentEditBox.Dock =
                DockStyle.Fill;

            contentEditBox.BackColor =
                Solvix.UI.AppTheme.SurfaceAlt;

            contentEditBox.ForeColor =
                Solvix.UI.AppTheme.Text;

            contentEditBox.BorderStyle =
                BorderStyle.None;

            contentEditBox.Font =
                Solvix.UI.AppTheme.Regular(10F);

            contentEditBox.RightToLeft =
                RightToLeft.Yes;

            contentEditBox.Multiline =
                true;

            contentEditBox.ScrollBars =
                RichTextBoxScrollBars.Vertical;

            contentEditBox.WordWrap =
                true;

            contentEditBox.DetectUrls =
                false;

            contentEditBox.HideSelection =
                false;

            contentFrame.Controls.Add(
                contentEditBox);

            contentFrame.Controls.Add(
                contentCaption);

            // =========================================================
            // EDITOR BOTTOM
            // =========================================================

            editorBottomPanel.Dock =
                DockStyle.Bottom;

            editorBottomPanel.Height =
                76;

            editorBottomPanel.BackColor =
                Color.Transparent;

            categoryCaption.AutoSize =
                false;

            categoryCaption.Width =
                80;

            categoryCaption.Height =
                28;

            categoryCaption.Top =
                5;

            categoryCaption.Text =
                "التصنيف";

            categoryCaption.Font =
                Solvix.UI.AppTheme.Regular(8F);

            categoryCaption.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            categoryCaption.TextAlign =
                ContentAlignment.MiddleRight;

            categoryCaption.RightToLeft =
                RightToLeft.Yes;

            categoryCombo.Width =
                155;

            categoryCombo.Height =
                38;

            categoryCombo.Top =
                33;

            categoryCombo.DropDownStyle =
                ComboBoxStyle.DropDown;

            categoryCombo.BackColor =
                Solvix.UI.AppTheme.SurfaceAlt;

            categoryCombo.ForeColor =
                Solvix.UI.AppTheme.Text;

            categoryCombo.Font =
                Solvix.UI.AppTheme.Regular(8.5F);

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

            importantCheckBox.Width =
                125;

            importantCheckBox.Height =
                34;

            importantCheckBox.Text =
                "ملاحظة مهمة";

            importantCheckBox.RightToLeft =
                RightToLeft.Yes;

            pinnedCheckBox.Width =
                125;

            pinnedCheckBox.Height =
                34;

            pinnedCheckBox.Text =
                "تثبيت الملاحظة";

            pinnedCheckBox.RightToLeft =
                RightToLeft.Yes;

            saveButton.Width =
                142;

            saveButton.Height =
                42;

            saveButton.Text =
                "حفظ الملاحظة";

            saveButton.Font =
                Solvix.UI.AppTheme.Bold(9F);

            cancelButton.Width =
                92;

            cancelButton.Height =
                42;

            cancelButton.Text =
                "إلغاء";

            editorBottomPanel.Controls.Add(
                categoryCaption);

            editorBottomPanel.Controls.Add(
                categoryCombo);

            editorBottomPanel.Controls.Add(
                importantCheckBox);

            editorBottomPanel.Controls.Add(
                pinnedCheckBox);

            editorBottomPanel.Controls.Add(
                cancelButton);

            editorBottomPanel.Controls.Add(
                saveButton);

            editorBottomPanel.Resize +=
                (_, _) => LayoutEditorBottom();

            // =========================================================
            // EDITOR HIERARCHY
            // =========================================================

            editorContainer.Controls.Add(
                contentFrame);

            editorContainer.Controls.Add(
                titleFrame);

            editorContainer.Controls.Add(
                editorBottomPanel);

            editorContainer.Controls.Add(
                editorSubHeading);

            editorContainer.Controls.Add(
                editorHeading);

            // =========================================================
            // DETAIL HIERARCHY
            // =========================================================

            detailPanel.Controls.Add(
                editorContainer);

            detailPanel.Controls.Add(
                displayContainer);

            detailPanel.Controls.Add(
                detailHeaderPanel);

            // =========================================================
            // CONTENT HIERARCHY
            // =========================================================

            contentPanel.Controls.Add(
                detailPanel);

            contentPanel.Controls.Add(
                listPanel);

            // =========================================================
            // MAIN HIERARCHY
            // =========================================================

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
                new SizeF(
                    96F,
                    96F);

            BackColor =
                Solvix.UI.AppTheme.Background;

            ForeColor =
                Solvix.UI.AppTheme.Text;

            ClientSize =
                new Size(
                    1440,
                    900);

            MinimumSize =
                new Size(
                    1120,
                    720);

            Controls.Add(
                mainPanel);

            Font =
                Solvix.UI.AppTheme.Regular(9.5F);

            Name =
                "Notes";

            Text =
                "الملاحظات";

            RightToLeft =
                RightToLeft.Yes;

            RightToLeftLayout =
                true;

            StartPosition =
                FormStartPosition.CenterScreen;

            WindowState =
                FormWindowState.Maximized;

            Shown += (_, _) =>
            {
                LayoutStats();
                LayoutInfoPanel();
                LayoutDetailHeader();
                LayoutEditorBottom();
            };

            ResumeLayout(false);
            PerformLayout();
        }

        // =============================================================
        // LAYOUT
        // =============================================================

        private void LayoutStats()
        {
            if (statsPanel == null)
                return;

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

            totalCard.Top =
                5;

            importantCard.Top =
                5;

            pinnedCard.Top =
                5;

            todayCard.Top =
                5;
        }

        private void LayoutDetailHeader()
        {
            if (detailHeaderPanel == null)
                return;

            int width =
                detailHeaderPanel.ClientSize.Width;

            deleteButton.Left =
                width -
                deleteButton.Width -
                18;

            editButton.Left =
                deleteButton.Left -
                editButton.Width -
                8;

            pinButton.Left =
                editButton.Left -
                pinButton.Width -
                8;

            noteBadge.Left =
                Math.Max(
                    18,
                    pinButton.Left -
                    noteBadge.Width -
                    12);

            detailHeaderLabel.Left =
                18;

            detailHeaderLabel.Width =
                Math.Max(
                    180,
                    noteBadge.Left -
                    30);

            deleteButton.Top = 16;
            editButton.Top = 16;
            pinButton.Top = 16;
            noteBadge.Top = 21;
            detailHeaderLabel.Top = 17;
        }

        private void LayoutInfoPanel()
        {
            if (infoPanel == null)
                return;

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

            categoryLabel.Top = 14;
            createdLabel.Top = 14;
            updatedLabel.Top = 14;

            categoryValue.Top = 40;
            createdValue.Top = 40;
            updatedValue.Top = 40;
        }

        private void LayoutEditorBottom()
        {
            if (editorBottomPanel == null)
                return;

            int width =
                editorBottomPanel.ClientSize.Width;

            saveButton.Top = 27;

            cancelButton.Top = 27;

            saveButton.Left =
                width -
                saveButton.Width;

            cancelButton.Left =
                saveButton.Left -
                cancelButton.Width -
                10;

            pinnedCheckBox.Left =
                Math.Max(
                    8,
                    cancelButton.Left -
                    pinnedCheckBox.Width -
                    18);

            pinnedCheckBox.Top = 25;

            importantCheckBox.Left =
                Math.Max(
                    8,
                    pinnedCheckBox.Left -
                    importantCheckBox.Width -
                    10);

            importantCheckBox.Top = 25;

            categoryCombo.Left =
                Math.Max(
                    8,
                    importantCheckBox.Left -
                    categoryCombo.Width -
                    18);

            categoryCaption.Left =
                categoryCombo.Left;

            categoryCombo.Top = 32;
            categoryCaption.Top = 4;
        }

        // =============================================================
        // DESIGN HELPERS
        // =============================================================

        private void ConfigureStat(
            Solvix.UI.StatCard card,
            string title,
            string value,
            string subtitle,
            Color accent)
        {
            card.Height =
                92;

            card.FillColor =
                Solvix.UI.AppTheme.Surface;

            card.BorderColor =
                Solvix.UI.AppTheme.Border;

            card.BorderThickness =
                1;

            card.CornerRadius =
                12;

            card.Title =
                title;

            card.Value =
                value;

            card.Subtitle =
                subtitle;

            card.AccentColor =
                accent;
        }

        private void ConfigureInfo(
            Label label,
            Label value,
            string title,
            string initialValue)
        {
            label.AutoSize = false;

            label.Height = 21;

            label.Font =
                Solvix.UI.AppTheme.Regular(7.8F);

            label.ForeColor =
                Solvix.UI.AppTheme.MutedText;

            label.Text =
                title;

            label.TextAlign =
                ContentAlignment.MiddleRight;

            label.RightToLeft =
                RightToLeft.Yes;

            value.AutoSize = false;

            value.Height = 28;

            value.Font =
                Solvix.UI.AppTheme.Bold(9F);

            value.ForeColor =
                Solvix.UI.AppTheme.Text;

            value.Text =
                initialValue;

            value.TextAlign =
                ContentAlignment.MiddleRight;

            value.RightToLeft =
                RightToLeft.Yes;
        }
    }
}