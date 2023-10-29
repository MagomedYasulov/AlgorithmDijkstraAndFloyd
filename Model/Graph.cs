using AlgorithmDijkstra.Interfaces;
using System.Collections.Generic;

namespace AlgorithmDijkstra.Model
{
    public class Graph<V,E> where V : IVertex where E : IEdge<V>
    {
        public List<V> Vertexes = new List<V>();
        public List<E> Edges = new List<E>();
        public int VertexCount => Vertexes.Count;
        public int EdgeCount => Edges.Count;

        public void AddVertex(V vertex)
        {
            vertex.Number = Vertexes.Count;
            Vertexes.Add(vertex);
        }

        public void AddEdge(E edge)
        {
            if (VertexCount > edge.From.Number && VertexCount > edge.To.Number)
            {
                Edges.Add(edge);               
            }
        }

        public double[,] GetMatrixGraph()
        {
            var matrix = new double[VertexCount, VertexCount];

            foreach(var edge in Edges)
            {
                var row = edge.From.Number;
                var column = edge.To.Number;
                matrix[row, column] = edge.Weight;
            }

            for(int i=0; i<matrix.GetLength(0); i++)
            {
                for(int j=0; j < matrix.GetLength(1); j++)
                {
                    if(i != j && matrix[i,j] == 0)
                    {
                        matrix[i, j] = double.PositiveInfinity;
                    }
                }
            }
            return matrix;
        }

        public bool IsEdge(int vertex1Number, int vertex2Number)
        {
            if (VertexCount > vertex2Number && VertexCount > vertex1Number)
            {
                foreach (var edge in Edges)
                {
                    if (edge.From.Number == vertex1Number && edge.To.Number == vertex2Number)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
