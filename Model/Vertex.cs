using AlgorithmDijkstra.Interfaces;

namespace AlgorithmDijkstra.Model
{
    public class Vertex : IVertex
    {
        public int Number { get; set; }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
