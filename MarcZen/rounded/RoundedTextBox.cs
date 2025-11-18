using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBoxContainer : Panel
{
    private TextBox textBox = new TextBox();

    public int BorderRadius { get; set; } = 10;
    public Color BorderColor { get; set; } = Color.Black;
    public Color BackColorCustom { get; set; } = Color.White;
    public string TextValue
    {
        get => textBox.Text;
        set => textBox.Text = value;
    }

    public RoundedTextBoxContainer()
    {
        Padding = new Padding(10, 5, 10, 5);
        textBox.BorderStyle = BorderStyle.None;
        textBox.Font = new Font("Segoe UI", 11F);
        textBox.BackColor = Color.White;
        textBox.ForeColor = Color.Black;
        textBox.Dock = DockStyle.Fill;
        Controls.Add(textBox);
        Height = 35;
        BackColor = Color.Transparent;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

        using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
        using (SolidBrush brush = new SolidBrush(BackColorCustom))
        using (Pen pen = new Pen(BorderColor, 1.5f))
        {
            e.Graphics.FillPath(brush, path);
            e.Graphics.DrawPath(pen, path);
            Region = new Region(path); // makes the corners actually rounded
        }

        base.OnPaint(e);
    }

    private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        int d = radius * 2;
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }
}
    