using AlgorithmDijkstra.Interfaces;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AlgorithmDijkstra.Model
{
    public class VertexView : Control, IVertex
    {
        public int Number { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        private StringFormat SF = new StringFormat();
        public VertexView()
        {
            SetSettings();
        }

        public VertexView(int x, int y) : base()
        {
            X = x;
            Y = y;
            Name = "VertexView" + Number.ToString();
            Location = new Point(X,Y);
            SetSettings();
        }

        private void SetSettings()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer 
                    | ControlStyles.ResizeRedraw 
                    | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(30, 30);
            BackColor = Color.Blue;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            Text = Number.ToString();
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            graph.DrawEllipse(new Pen(BackColor), rect);
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
        }
    }
}
