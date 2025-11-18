using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int CornerRadius { get; set; } = 15;
    public Color BorderColor { get; set; } = Color.Black;
    public int BorderThickness { get; set; } = 1;

    public RoundedPanel()
    {
        // Make painting smoother and avoid flicker
        this.SetStyle(ControlStyles.UserPaint |
                      ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.OptimizedDoubleBuffer, true);

        ResizeRedraw = true;
        // default fill color (change in designer if needed)
        BackColor = Color.White;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        // Do nothing here to prevent the default rectangular background painting.
        // We will paint the rounded background in OnPaint.
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
        using (GraphicsPath path = GetRoundedRectPath(rect, CornerRadius))
        {
            // Clip the control to this rounded path so everything is actually rounded
            // (this prevents the rectangle "white corners" you saw).
            try
            {
                this.Region = new Region(path);
            }
            catch
            {
                // ignore region exceptions in designer-time
            }

            // fill rounded background
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // draw border (if thickness > 0)
            if (BorderThickness > 0)
            {
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    // draw the path inset by half the pen width to avoid clipping
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        // Do not call base.OnPaint(e) because it can draw a rectangular background.
    }

    protected override void OnResize(EventArgs eventargs)
    {
        base.OnResize(eventargs);
        // Update region when resized (so clipping remains correct)
        Invalidate();
    }

    private GraphicsPath GetRoundedRectPath(Rectangle r, int radius)
    {
        int d = Math.Max(0, radius) * 2;
        GraphicsPath path = new GraphicsPath();
        if (d <= 0)
        {
            path.AddRectangle(r);
            return path;
        }

        // Ensure the radius does not exceed control size
        int w = r.Width;
        int h = r.Height;
        int effectiveRadius = Math.Min(radius, Math.Min(w, h) / 2);
        int dd = effectiveRadius * 2;

        path.StartFigure();
        path.AddArc(r.X, r.Y, dd, dd, 180, 90); // top-left
        path.AddArc(r.Right - dd, r.Y, dd, dd, 270, 90); // top-right
        path.AddArc(r.Right - dd, r.Bottom - dd, dd, dd, 0, 90); // bottom-right
        path.AddArc(r.X, r.Bottom - dd, dd, dd, 90, 90); // bottom-left
        path.CloseFigure();
        return path;
    }
}
