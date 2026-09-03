using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Solvix.UI
{
    public static class AppTheme
    {
        public static Color Background => Color.FromArgb(7, 15, 27);
        public static Color Surface => Color.FromArgb(14, 27, 46);
        public static Color SurfaceAlt => Color.FromArgb(19, 34, 56);
        public static Color Card => Color.FromArgb(24, 39, 61);
        public static Color CardSelected => Color.FromArgb(28, 57, 92);
        public static Color Border => Color.FromArgb(35, 59, 88);
        public static Color BorderStrong => Color.FromArgb(46, 92, 145);
        public static Color Text => Color.FromArgb(244, 247, 252);
        public static Color MutedText => Color.FromArgb(145, 162, 184);
        public static Color Primary => Color.FromArgb(48, 130, 242);
        public static Color PrimaryHover => Color.FromArgb(68, 148, 255);
        public static Color PrimaryPressed => Color.FromArgb(34, 101, 200);
        public static Color Success => Color.FromArgb(55, 184, 132);
        public static Color Warning => Color.FromArgb(224, 177, 71);
        public static Color Danger => Color.FromArgb(220, 81, 92);

        public static Font Regular(float size = 9.5f) =>
            new Font("Segoe UI", size, FontStyle.Regular);

        public static Font Medium(float size = 9.5f) =>
            new Font("Segoe UI Semibold", size, FontStyle.Regular);

        public static Font Bold(float size = 9.5f) =>
            new Font("Segoe UI", size, FontStyle.Bold);
    }

    public static class UiHelper
    {
        public static GraphicsPath RoundedPath(Rectangle bounds, int radius)
        {
            int r = Math.Max(0, Math.Min(radius, Math.Min(bounds.Width, bounds.Height) / 2));

            if (r == 0)
            {
                GraphicsPath square = new GraphicsPath();
                square.AddRectangle(bounds);
                return square;
            }

            int d = r * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        public static void EnableDoubleBuffer(Control control)
        {
            try
            {
                typeof(Control)
                    .GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.Instance |
                        System.Reflection.BindingFlags.NonPublic)
                    ?.SetValue(control, true);
            }
            catch
            {
            }
        }

        public static void ApplyDoubleBuffer(Control control)
        {
            EnableDoubleBuffer(control);
        }
    }

    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class RoundedPanel : Panel
    {
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CornerRadius { get; set; } = 14;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color FillColor { get; set; } = AppTheme.Surface;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor { get; set; } = AppTheme.Border;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderThickness { get; set; } = 1;

        public RoundedPanel()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);

            BackColor = AppTheme.Surface;
            ForeColor = AppTheme.Text;
            Margin = Padding.Empty;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width <= 0 || Height <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0,
                0,
                Math.Max(1, Width - 1),
                Math.Max(1, Height - 1));

            using GraphicsPath path = UiHelper.RoundedPath(rect, CornerRadius);
            using SolidBrush brush = new SolidBrush(FillColor);

            e.Graphics.FillPath(brush, path);

            if (BorderThickness > 0)
            {
                using Pen pen = new Pen(BorderColor, BorderThickness);
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class CustomButton : Button
    {
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color PrimaryColor { get; set; } = AppTheme.Primary;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverColor { get; set; } = AppTheme.PrimaryHover;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color PressedColor { get; set; } = AppTheme.PrimaryPressed;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CornerRadius { get; set; } = 9;

        private bool _hover;
        private bool _pressed;

        public CustomButton()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;
            BackColor = AppTheme.Primary;
            ForeColor = Color.White;
            Font = AppTheme.Medium(9.5f);
            Cursor = Cursors.Hand;
            Height = 42;
            TextAlign = ContentAlignment.MiddleCenter;

            MouseEnter += (_, _) =>
            {
                _hover = true;
                Invalidate();
            };

            MouseLeave += (_, _) =>
            {
                _hover = false;
                _pressed = false;
                Invalidate();
            };

            MouseDown += (_, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    _pressed = true;
                    Invalidate();
                }
            };

            MouseUp += (_, _) =>
            {
                _pressed = false;
                Invalidate();
            };
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color color = _pressed
                ? PressedColor
                : _hover
                    ? HoverColor
                    : PrimaryColor;

            Rectangle rect = new Rectangle(
                0,
                0,
                Math.Max(1, Width - 1),
                Math.Max(1, Height - 1));

            using GraphicsPath path = UiHelper.RoundedPath(rect, CornerRadius);
            using SolidBrush brush = new SolidBrush(color);

            e.Graphics.FillPath(brush, path);

            TextRenderer.DrawText(
                e.Graphics,
                Text ?? string.Empty,
                Font,
                ClientRectangle,
                ForeColor,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.NoPrefix);
        }
    }

    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class OutlineButton : CustomButton
    {
        public OutlineButton()
        {
            PrimaryColor = AppTheme.SurfaceAlt;
            HoverColor = Color.FromArgb(29, 48, 76);
            PressedColor = Color.FromArgb(36, 59, 90);
            ForeColor = AppTheme.Text;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            bool hover = ClientRectangle.Contains(PointToClient(Cursor.Position));
            Color fill = hover ? HoverColor : PrimaryColor;

            Rectangle rect = new Rectangle(
                0,
                0,
                Math.Max(1, Width - 1),
                Math.Max(1, Height - 1));

            using GraphicsPath path = UiHelper.RoundedPath(rect, CornerRadius);
            using SolidBrush brush = new SolidBrush(fill);
            using Pen pen = new Pen(AppTheme.Border, 1);

            e.Graphics.FillPath(brush, path);
            e.Graphics.DrawPath(pen, path);

            TextRenderer.DrawText(
                e.Graphics,
                Text ?? string.Empty,
                Font,
                ClientRectangle,
                ForeColor,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.NoPrefix);
        }
    }

    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class CustomTextBox : UserControl
    {
        private readonly TextBox _textBox;
        private string _placeholder = "اكتب هنا...";
        private bool _focused;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PlaceholderText
        {
            get => _placeholder;
            set
            {
                _placeholder = value ?? string.Empty;
                Invalidate();
            }
        }

        [Category("Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text
        {
            get => _textBox.Text;
            set => _textBox.Text = value ?? string.Empty;
        }

        [Category("Behavior")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool UsePasswordChar
        {
            get => _textBox.UseSystemPasswordChar;
            set => _textBox.UseSystemPasswordChar = value;
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CornerRadius { get; set; } = 9;

        public CustomTextBox()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);

            Height = 42;
            BackColor = AppTheme.SurfaceAlt;
            ForeColor = AppTheme.Text;

            _textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = AppTheme.SurfaceAlt,
                ForeColor = AppTheme.Text,
                Font = AppTheme.Regular(9.5f),
                Location = new Point(12, 10),
                Width = Math.Max(20, Width - 24),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                RightToLeft = RightToLeft.Yes
            };

            Controls.Add(_textBox);

            _textBox.Enter += (_, _) =>
            {
                _focused = true;
                Invalidate();
            };

            _textBox.Leave += (_, _) =>
            {
                _focused = false;
                Invalidate();
            };

            _textBox.TextChanged += (_, _) =>
            {
                base.OnTextChanged(EventArgs.Empty);
                Invalidate();
            };

            Resize += (_, _) =>
            {
                _textBox.Width = Math.Max(20, Width - 24);
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0,
                0,
                Math.Max(1, Width - 1),
                Math.Max(1, Height - 1));

            using GraphicsPath path = UiHelper.RoundedPath(rect, CornerRadius);
            using SolidBrush brush = new SolidBrush(AppTheme.SurfaceAlt);
            using Pen pen = new Pen(
                _focused ? AppTheme.Primary : AppTheme.Border,
                _focused ? 1.5f : 1f);

            e.Graphics.FillPath(brush, path);
            e.Graphics.DrawPath(pen, path);

            if (!_focused && string.IsNullOrWhiteSpace(_textBox.Text))
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    _placeholder,
                    Font,
                    new Rectangle(12, 0, Math.Max(20, Width - 24), Height),
                    AppTheme.MutedText,
                    TextFormatFlags.Right |
                    TextFormatFlags.VerticalCenter |
                    TextFormatFlags.NoPrefix);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _textBox.Focus();
        }
    }

    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class SearchBox : CustomTextBox
    {
        public SearchBox()
        {
            PlaceholderText = "ابحث في الملاحظات...";
        }
    }

    public enum BadgeStyle
    {
        Neutral,
        Success,
        Warning,
        Danger,
        Primary
    }

    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class StatusBadge : Label
    {
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public BadgeStyle Style { get; set; } = BadgeStyle.Neutral;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CornerRadius { get; set; } = 8;

        public StatusBadge()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);

            AutoSize = false;
            Height = 28;
            BackColor = Color.Transparent;
            Font = AppTheme.Medium(8.5f);
            TextAlign = ContentAlignment.MiddleCenter;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Color accent = Style switch
            {
                BadgeStyle.Success => AppTheme.Success,
                BadgeStyle.Warning => AppTheme.Warning,
                BadgeStyle.Danger => AppTheme.Danger,
                BadgeStyle.Primary => AppTheme.Primary,
                _ => AppTheme.MutedText
            };

            Rectangle rect = new Rectangle(
                0,
                0,
                Math.Max(1, Width - 1),
                Math.Max(1, Height - 1));

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using GraphicsPath path = UiHelper.RoundedPath(rect, CornerRadius);
            using SolidBrush brush = new SolidBrush(Color.FromArgb(28, accent));
            using Pen pen = new Pen(Color.FromArgb(85, accent), 1);

            e.Graphics.FillPath(brush, path);
            e.Graphics.DrawPath(pen, path);

            TextRenderer.DrawText(
                e.Graphics,
                Text ?? string.Empty,
                Font,
                ClientRectangle,
                accent,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.NoPrefix);
        }
    }

    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class StatCard : RoundedPanel
    {
        private readonly Label _title;
        private readonly Label _value;
        private readonly Label _subtitle;
        private readonly Panel _accent;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title
        {
            get => _title.Text;
            set => _title.Text = value ?? string.Empty;
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Value
        {
            get => _value.Text;
            set => _value.Text = value ?? string.Empty;
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Subtitle
        {
            get => _subtitle.Text;
            set => _subtitle.Text = value ?? string.Empty;
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color AccentColor
        {
            get => _accent.BackColor;
            set => _accent.BackColor = value;
        }

        public StatCard()
        {
            FillColor = AppTheme.Surface;
            BorderColor = AppTheme.Border;
            BorderThickness = 1;
            CornerRadius = 13;
            Padding = new Padding(18, 11, 18, 11);

            _accent = new Panel
            {
                Dock = DockStyle.Right,
                Width = 4,
                BackColor = AppTheme.Primary
            };

            _title = new Label
            {
                Dock = DockStyle.Top,
                Height = 22,
                BackColor = Color.Transparent,
                ForeColor = AppTheme.MutedText,
                Font = AppTheme.Medium(8.5f),
                Text = "العنوان",
                TextAlign = ContentAlignment.MiddleRight
            };

            _value = new Label
            {
                Dock = DockStyle.Top,
                Height = 34,
                BackColor = Color.Transparent,
                ForeColor = AppTheme.Text,
                Font = new Font("Segoe UI", 17f, FontStyle.Bold),
                Text = "0",
                TextAlign = ContentAlignment.MiddleRight
            };

            _subtitle = new Label
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                ForeColor = AppTheme.MutedText,
                Font = AppTheme.Regular(7.5f),
                Text = "الوصف",
                TextAlign = ContentAlignment.MiddleRight
            };

            Controls.Add(_accent);
            Controls.Add(_subtitle);
            Controls.Add(_value);
            Controls.Add(_title);
        }
    }

    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class IconButton : Button
    {
        public IconButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;
            BackColor = Color.Transparent;
            ForeColor = AppTheme.MutedText;
            Font = new Font("Segoe UI Symbol", 13f);
            Width = 40;
            Height = 40;
            Cursor = Cursors.Hand;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = AppTheme.SurfaceAlt;
            ForeColor = AppTheme.Text;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.Transparent;
            ForeColor = AppTheme.MutedText;
        }
    }
    public class Sidebar : Panel
    {
        private readonly FlowLayoutPanel _items;

        public Sidebar()
        {
            BackColor = AppTheme.Surface;
            Width = 240;
            Dock = DockStyle.Left;
            Padding = new Padding(12, 18, 12, 12);

            _items = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                BackColor = Color.Transparent
            };

            Controls.Add(_items);
            UiHelper.EnableDoubleBuffer(_items);
        }

        public SidebarButton AddItem(string text, string key, string icon = "")
        {
            var item = new SidebarButton
            {
                Text = string.IsNullOrWhiteSpace(icon) ? text : $"{icon}   {text}",
                Key = key,
                Width = Math.Max(180, ClientSize.Width - 24),
                Margin = new Padding(0, 3, 0, 3)
            };

            item.Click += (_, _) =>
            {
                foreach (Control control in _items.Controls)
                {
                    if (control is SidebarButton button)
                        button.IsActive = ReferenceEquals(button, item);
                }
            };

            _items.Controls.Add(item);
            return item;
        }
    }

    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class SidebarButton : Button
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Key { get; set; } = string.Empty;

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsActive { get; set; }

        private bool _hovered;

        public SidebarButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;
            BackColor = Color.Transparent;
            ForeColor = AppTheme.MutedText;
            Font = AppTheme.Medium(9.5f);
            TextAlign = ContentAlignment.MiddleLeft;
            Padding = new Padding(14, 0, 12, 0);
            Height = 44;
            Cursor = Cursors.Hand;

            MouseEnter += (_, _) => { _hovered = true; Invalidate(); };
            MouseLeave += (_, _) => { _hovered = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color fill = IsActive
                ? Color.FromArgb(24, 61, 104)
                : _hovered
                    ? AppTheme.SurfaceAlt
                    : Color.Transparent;

            using var path = UiHelper.RoundedPath(
                new Rectangle(0, 0, Math.Max(1, Width - 1), Math.Max(1, Height - 1)), 9);
            using var brush = new SolidBrush(fill);

            e.Graphics.FillPath(brush, path);

            TextRenderer.DrawText(
                e.Graphics,
                Text ?? string.Empty,
                Font,
                ClientRectangle,
                IsActive ? AppTheme.PrimaryHover : ForeColor,
                TextFormatFlags.Left |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.NoPrefix);
        }
    }

    public class PageHeader : Panel
    {
        public Label TitleLabel { get; } = new Label();
        public Label SubtitleLabel { get; } = new Label();

        public PageHeader()
        {
            Height = 80;
            Dock = DockStyle.Top;
            BackColor = Color.Transparent;

            TitleLabel.AutoSize = true;
            TitleLabel.Font = AppTheme.Bold(20f);
            TitleLabel.ForeColor = AppTheme.Text;

            SubtitleLabel.AutoSize = true;
            SubtitleLabel.Font = AppTheme.Regular(9f);
            SubtitleLabel.ForeColor = AppTheme.MutedText;

            Controls.Add(SubtitleLabel);
            Controls.Add(TitleLabel);
        }
    }
}
