using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPictureBox : PictureBox
{
    private int cornerRadius = 20;
    private Color borderColor = Color.Black;
    private int borderThickness = 2;

    [Category("Appearance")]
    public int CornerRadius
    {
        get => cornerRadius;
        set { cornerRadius = Math.Max(0, value); Invalidate(); }
    }

    [Category("Appearance")]
    public Color BorderColor
    {
        get => borderColor;
        set { borderColor = value; Invalidate(); }
    }

    [Category("Appearance")]
    public int BorderThickness
    {
        get => borderThickness;
        set { borderThickness = Math.Max(0, value); Invalidate(); }
    }

    public RoundedPictureBox()
    {
        SizeMode = PictureBoxSizeMode.Zoom;
        BackColor = Color.Transparent;
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

        using (GraphicsPath path = GetRoundedRectPath(rect, CornerRadius))
        {
            // Apply clipping to make it actually rounded
            this.Region = new Region(path);

            // Draw image inside rounded region
            if (Image != null)
            {
                e.Graphics.SetClip(path);
                e.Graphics.DrawImage(Image, rect);
                e.Graphics.ResetClip();
            }

            // Draw border
            if (BorderThickness > 0)
            {
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }

    private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
    {
        int d = radius * 2;
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }
}
