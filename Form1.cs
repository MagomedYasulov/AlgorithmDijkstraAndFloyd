using AlgorithmDijkstra.Model;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AlgorithmDijkstra
{
    public partial class Form1 : Form
    {
        Graph<VertexView,EdgeView> Graph = new Graph<VertexView,EdgeView>();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void Form1_Paint(object sender, PaintEventArgs e) { }

        //Добавлние связи между конкретными вершинами
        private void button1_Click(object sender, EventArgs e)
        {
            var countVertex = Graph.VertexCount;
            var countEdge = Graph.EdgeCount / 2;
            var maxEdge = countVertex * (countVertex - 1) / 2;

            var vertex1 = (int)Vetex1numericUpDown.Value;
            var vertex2 = (int)Vetex2numericUpDown.Value;
            var lenght = (int)LenghtNumericUpDown.Value;

            if(lenght <= 0)
            {
                MessageBox.Show("Не корректная длинна ");
                return;
            }
            else if(vertex1 == vertex2)
            {
                MessageBox.Show("Не корректные данные вершин");
                return;
            }
            else if(countEdge > maxEdge)
            {
                MessageBox.Show("Количество вершин и связей не корректно");
                return;
            }

            CreateEdge(vertex1, vertex2, lenght);
        }

        //Добавление вершины по точным координатам
        private void Button1_Click_1(object sender, EventArgs e)
        {   
            AddVertex(true);
        }

        //Алгоритм Дейкстры нажатие
        private void FindButton_Click(object sender, EventArgs e)
        {
            var algorithm = new Dijkstra(Graph.GetMatrixGraph());
            FindAndSetMinLenght(algorithm);           
        }

        //Алгоритм Флойда нажатие
        private void FloydButton_Click(object sender, EventArgs e)
        {
            var algorithm = new Floyd(Graph.GetMatrixGraph());
            FindAndSetMinLenght(algorithm);
        }

        //Создание случайного графа
        private void AddRandomGraphButton_Click(object sender, EventArgs e)
        {
            int currentCountEdge = 0;
            var countVertex = (int)CountVertexNumericUpDown.Value;
            var countEdge = (int)CountEdgeNumericUpDown.Value;
            //Проверка на корректност количества вершин и связей
            if (!IsCorrectCountVertexAndEdge(countVertex, countEdge))
                return;

            Clear();
            for (int i = 0; i < countVertex; i++)
            {
                AddVertex(false);
                pictureBox1.Refresh();
                Thread.Sleep(1000);
            }

            while (currentCountEdge != countEdge)
            {
                var vertex1 = rnd.Next(Graph.Vertexes.Count);
                var vertex2 = rnd.Next(Graph.Vertexes.Count);
                var lenght = rnd.Next(1, 99);
                if (vertex1 != vertex2 && !Graph.IsEdge(vertex1, vertex2))
                {
                    CreateEdge(vertex1, vertex2, lenght);
                    currentCountEdge++;
                    Thread.Sleep(1000);
                }
            }
        }

        //Очистка панели
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Сброс цветов ребер
        private void ResetColorButton_Click(object sender, EventArgs e)
        {
            ResetColorEdge();
        }

        //Сброс цветов ребер
        private void ResetColorEdge()
        {
            for (int i = 0; i < Graph.EdgeCount; i++)
            {
                if (Graph.Edges[i].Color == Color.Red)
                {
                    DrawEdge(Graph.Edges[i], Color.Green, false);
                }
            }
        }

        //Очистка панели
        private void Clear()
        {
            pictureBox1.Controls.Clear();
            pictureBox1.Image = null;
            Graph = new Graph<VertexView, EdgeView>();
            rnd = new Random();
        }

        //Создание ребра
        private void CreateEdge(int vertex1, int vertex2, int lenght)
        {
            var vertexView1 = GetVerteView(vertex1);
            var vertexView2 = GetVerteView(vertex2);

            var edgeView1 = new EdgeView(vertexView1, vertexView2, lenght);
            var edgeView2 = new EdgeView(vertexView2, vertexView1, lenght);
            Graph.AddEdge(edgeView1);
            Graph.AddEdge(edgeView2);

            DrawEdge(edgeView1, Color.Green, true);
        }

        // Выборка нужных представлений вершин 
        private VertexView GetVerteView(int vertex)
        {
            var vertexView = new VertexView();

            for (int i = 0; i < Graph.VertexCount; i++)
            {
                if (Graph.Vertexes[i].Number == vertex)
                {
                    vertexView = Graph.Vertexes[i];
                }
            }
            return vertexView;
        }

        //Получение предстоавлеи вершины
        private EdgeView GetEdgeView(VertexView vertexView1 , VertexView vertexView2)
        {
            EdgeView edgeView = new EdgeView();
            for(int i=0; i < Graph.EdgeCount; i++)
            {
                if((Graph.Edges[i].From.Number == vertexView1.Number && Graph.Edges[i].To.Number == vertexView2.Number) || 
                    (Graph.Edges[i].From.Number == vertexView2.Number && Graph.Edges[i].To.Number == vertexView1.Number))
                {
                    edgeView = Graph.Edges[i];
                    break;
                }
            }
            return edgeView;
        }

        //Рисование ребра
        private void DrawEdge(EdgeView edgeView, Color color, bool isNewEdge)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            edgeView.Color = color;

            //Рисуем линию
            Pen p = new Pen(color, 2);// цвет линии и ширина
            Point p1 = new Point(edgeView.From.X + 10, edgeView.From.Y + 10);
            Point p2 = new Point(edgeView.To.X + 10, edgeView.To.Y + 10);
            gr.DrawLine(p, p1, p2); // рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой

            if (isNewEdge)
            {
                pictureBox1.Controls.Add(edgeView.label);
            }
        }

        //Метод добавления вершины на форму
        private void AddVertex(bool flag)
        {
            VertexView vertexView = new VertexView();

            if (flag)
            {
                var X = (int)numericUpDownX.Value;
                var Y = (int)numericUpDownY.Value;
                var isCorrect = IsCorrectСoordinates(X, Y);
                if (!isCorrect)
                {
                    MessageBox.Show("Вершина с такими координатами уже есть");
                    return;
                }
                vertexView = new VertexView(X, Y);
            }
            else
            {
                var isCorrect = false;
                while (!isCorrect)
                {
                    var X = rnd.Next(pictureBox1.Width - 50);
                    var Y = rnd.Next(pictureBox1.Height - 50);
                    isCorrect = IsCorrectСoordinates(X, Y);
                    if (!isCorrect)
                        continue;
                    vertexView = new VertexView(X, Y);
                }
            }

            Graph.AddVertex(vertexView);
            pictureBox1.Controls.Add(vertexView);

            Vetex1numericUpDown.Maximum = Graph.VertexCount - 1;
            Vetex2numericUpDown.Maximum = Graph.VertexCount - 1;
        }

        //Проверка на коррекность координат вершин при добавлении
        private bool IsCorrectСoordinates(int X, int Y)
        {
            for(int i =0; i < Graph.VertexCount; i++)
            {
                if(Math.Abs(Graph.Vertexes[i].X - X) < 80 && Math.Abs(Graph.Vertexes[i].Y - Y) < 80)
                {
                    return false;
                }
            }
            return true;
        }

        //Нахождение кратчайшей длинны и путя 
        private void FindAndSetMinLenght(AlgorithmBase algorithm)
        {
            if (Graph.VertexCount == 0)
            {
                MessageBox.Show("Не корректное колиство вершин");
                return;
            }

            ResetColorEdge();

            Stopwatch timer = new Stopwatch();
            var from = (int)ForAlgorithmNumeric1.Value;
            var to = (int)ForAlgorithmNumeric2.Value;

            var result = algorithm.GetMinLenght(from, to);

            var path = result.Item2;
            ResultLabel.Text = "Наименьший путь: " + result.Item1;

            if (result.Item1 != double.PositiveInfinity)
            {
                for (int i = 0; i < path.Count - 1; i++)
                {
                    var vertexView1 = GetVerteView(path[i]);
                    var vertexView2 = GetVerteView(path[i + 1]);
                    var edgeView = GetEdgeView(vertexView1, vertexView2);
                    DrawEdge(edgeView, Color.Red, false);
                }
            }
        }

        //Проверка на корретность количества вершин и связей
        private bool IsCorrectCountVertexAndEdge(int countVertex, int countEdge)
        {
            var maxEdge = countVertex * (countVertex - 1) / 2;

            if (countEdge > maxEdge)
            {
                MessageBox.Show("Количество вершин и связей не корректно");
                return false;
            }
            return true;
        }
    }
}

