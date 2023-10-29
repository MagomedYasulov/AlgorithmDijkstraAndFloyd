using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDijkstra.Model
{
    public class Floyd : AlgorithmBase
    {
        public Floyd(double[,] graphMartix) : base(graphMartix) { }

        public override (double, List<int>) GetMinLenght(int FromVertex, int ToVertex)
        {              
            var CountVertex = GraphMatrix.GetLength(0);
            var next = new int[GraphMatrix.GetLength(0), GraphMatrix.GetLength(1)];

            for (int i = 0; i < next.GetLength(0); i++)
            {
                for (int j = 0; j < next.GetLength(1); j++)
                {
                    if (GraphMatrix[i, j] != double.PositiveInfinity)
                    {
                        next[i, j] = j; 
                    }
                    else
                    {
                        next[i, j] = -1;
                    }
                }
            }

            for (int i = 0; i < CountVertex; i++)
            {
                next[i, i] = i;
            }


            for(int i =0; i < CountVertex; i++)
            {
                for(int u = 0; u < CountVertex;u++)
                {
                    for(int v=0; v < CountVertex; v++)
                    {
                        if (GraphMatrix[u, v] > GraphMatrix[u, i] + GraphMatrix[i, v])
                        {
                            GraphMatrix[u, v] = GraphMatrix[u, i] + GraphMatrix[i, v];
                            next[u, v] = next[u, i];
                        }
                    }
                }
            }

            var minLenght = GraphMatrix[FromVertex, ToVertex];

            var path = GetPath(next, FromVertex, ToVertex);

            return (minLenght , path);
            
        }

        private List<int> GetPath(int[,] next,int from, int to)
        {
            var path = new List<int>();
            if(GraphMatrix[from,to] == -1)
            {
                path.Add(from);
                path.Add(to);
                return path;
            }
            var c = from;
            while(c != to)
            {
                path.Add(c);
                c = next[c, to];
            }
            path.Add(c);
            return path;
        }
    }
}
