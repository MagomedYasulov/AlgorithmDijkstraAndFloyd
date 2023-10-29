using AlgorithmDijkstra.Interfaces;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorithmDijkstra.Model
{
    class EdgeView : IEdge<VertexView>
    {
        public Label label = new Label();
        public VertexView From { get; set; }
        public VertexView To { get; set; }
        public Color Color { get; set; }
        public int Weight { get; set; }

        public EdgeView(VertexView vertexView1, VertexView vertexView2, int weight)
        {
            From = vertexView1;
            To = vertexView2;

            int X = (vertexView1.X + vertexView2.X) / 2 + 5;
            int Y = (vertexView1.Y + vertexView2.Y) / 2 + 5;
            Weight = weight;

            label.AutoSize = true;
            label.Location = new Point(X, Y);
            label.Name = "Edge_" + From + "_" + To;
            label.Size = new Size(97, 13);
            label.TabIndex = 4;
            label.Text = weight.ToString();
           
        }
        public EdgeView()
        {

        }
    }
}


//Добавление длинны на ребре 
//int X = (vertexView1.X + vertexView2.X) / 2 + 5;
//int Y = (vertexView1.Y + vertexView2.Y) / 2 + 5;
//var label = new Label();

//label.AutoSize = true;
//label.Location = new Point(X, Y);
//label.Name = "label_" + X + "_" + Y;
//label.Size = new Size(97, 13);
//label.TabIndex = 4;
//label.Text = lenght.ToString();
