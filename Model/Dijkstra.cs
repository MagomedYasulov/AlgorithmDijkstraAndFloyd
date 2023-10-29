using System.Collections.Generic;

namespace AlgorithmDijkstra.Model
{
    public class Dijkstra : AlgorithmBase
    {
        public Dijkstra(double[,] graphMartix) : base(graphMartix) { }

        public override (double, List<int>) GetMinLenght(int FromVertex, int ToVertex)
        {
            var ConsiderVertex = new List<int>();
            var VertexCount = GraphMatrix.GetLength(0);
            var path = new int[VertexCount];
            var LenghtToVertexes = new double[VertexCount];
            ConsiderVertex.Add(FromVertex);

            for(int i=0; i < VertexCount; i++)
            {
                path[i] = FromVertex;
            }

            for (int i = 0; i < VertexCount; i++)
            {
                LenghtToVertexes[i] = GraphMatrix[FromVertex, i];
            }
           
            
            while (ConsiderVertex.Count != VertexCount)
            {
                var w = -1;
                for (int i = 0; i < VertexCount; i++)
                {
                    if (!ConsiderVertex.Contains(i) && LenghtToVertexes[i] < double.PositiveInfinity && (w == -1 || LenghtToVertexes[i] < LenghtToVertexes[w]))
                    {
                        w = i;
                    }
                }
                ConsiderVertex.Add(w);

                for (int v = 0; v < VertexCount; v++)
                {
                    if (LenghtToVertexes[v] > LenghtToVertexes[w] + GraphMatrix[w, v])
                    {
                        LenghtToVertexes[v] = LenghtToVertexes[w] + GraphMatrix[w, v];
                        path[v] = w;
                    }
                }
            }

            var realPath = DecodoingPath(path, FromVertex, ToVertex);
            var minLenght = LenghtToVertexes[ToVertex];

            var tuple = (minLenght, realPath);
           
            return tuple;
        }

        //Построение кратчайшего маршрута
        private List<int> DecodoingPath(int[] path, int from, int  to)
        {
            var realPath = new List<int>();
            realPath.Add(to);
            while(true)
            {
                realPath.Add(path[to]);
                if(path[to] == from)
                {
                    break;
                }
                to = path[to];
            }

            realPath.Reverse();
            return realPath;
        }

        //выбираем вершину до которой меньше всего расстояние из не расмотренных еще вершин
        private int SelectVertex(List<int> ConsiderVertex, double[] LenghtToVertex)
        {

            var NotConsiderVertex = new List<int>();
            for (int i = 0; i < GraphMatrix.GetLength(0); i++)
            {
                if (!ConsiderVertex.Contains(i))
                {
                    NotConsiderVertex.Add(i);
                }
            }

            //Вершина до которой меньше всего расстояние
            int w = NotConsiderVertex[0];

            for (int i = 0; i < NotConsiderVertex.Count; i++)
            {
                if (LenghtToVertex[NotConsiderVertex[i]] < LenghtToVertex[w]) 
                {
                    w = NotConsiderVertex[i];
                }
            }
            return w;
        }
    }
}
