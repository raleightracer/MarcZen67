using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public enum ButtonStyles
    {
        ButtonX,   // Black theme
        ButtonY,   // Blue theme (example)
        ButtonZ    // Red theme (example)
    }

    private ButtonStyles _style = ButtonStyles.ButtonX;
    public ButtonStyles Style
    {
        get => _style;
        set
        {
            _style = value;
            ApplyStyle();   // load colors automatically
            Invalidate();
        }
    }

    public int CornerRadius { get; set; } = 20;

    private bool _isHovering = false;
    private bool _isPressed = false;

    // COLORS (per-style)
    private Color normalBackColor;
    private Color hoverBackColor;
    private Color pressedBackColor;
    private Color normalForeColor;
    private Color pressedForeColor;

    public RoundedButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Font = new Font("Segoe UI", 12, FontStyle.Regular);
        Cursor = Cursors.Hand;
        ResizeRedraw = true;

        ApplyStyle();   // Load default style
    }

    // =============== STYLE PRESETS ===================
    private void ApplyStyle()
    {
        switch (Style)
        {
            case ButtonStyles.ButtonX: // black/white theme
                normalBackColor = Color.Black;
                hoverBackColor = Color.Gray;
                pressedBackColor = Color.White;
                normalForeColor = Color.White;
                pressedForeColor = Color.Black;
                break;

            case ButtonStyles.ButtonY: // blue theme
                normalBackColor = Color.LightCoral;
                hoverBackColor = Color.RosyBrown;
                pressedBackColor = Color.Maroon;
                normalForeColor = Color.White;
                pressedForeColor = Color.Black;
                break;

            case ButtonStyles.ButtonZ: // red theme
                normalBackColor = Color.DarkSeaGreen;
                hoverBackColor = Color.YellowGreen;
                pressedBackColor = Color.ForestGreen;
                normalForeColor = Color.White;
                pressedForeColor = Color.Black;
                break;
        }

        // apply initial colors
        BackColor = normalBackColor;
        ForeColor = normalForeColor;
    }

    // ==================================================

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = GetRoundedRectPath(ClientRectangle, CornerRadius))
        {
            Region = new Region(path);
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillPath(brush, path);
        }

        // text centered
        TextRenderer.DrawText(
            e.Graphics,
            Text,
            Font,
            ClientRectangle,
            ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
        );
    }

    private GraphicsPath GetRoundedRectPath(Rectangle r, int radius)
    {
        int d = radius * 2;
        GraphicsPath path = new GraphicsPath();
        path.AddArc(r.X, r.Y, d, d, 180, 90);
        path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }

    // hovers & click color logic (no change needed)
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        _isHovering = true;

        if (!_isPressed)
        {
            BackColor = hoverBackColor;
            ForeColor = normalForeColor;
            Invalidate();
        }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _isHovering = false;
        _isPressed = false;

        BackColor = normalBackColor;
        ForeColor = normalForeColor;

        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        _isPressed = true;

        BackColor = pressedBackColor;
        ForeColor = pressedForeColor;

        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _isPressed = false;

        if (_isHovering)
        {
            BackColor = hoverBackColor;
            ForeColor = normalForeColor;
        }
        else
        {
            BackColor = normalBackColor;
            ForeColor = normalForeColor;
        }

        Invalidate();
    }
}
