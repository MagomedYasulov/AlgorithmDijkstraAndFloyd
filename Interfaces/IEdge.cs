
namespace AlgorithmDijkstra.Interfaces
{
    public interface IEdge<T> where T : IVertex
    {
        int Weight { get; set; }
        T From { get; set; }
        T To { get; set; }

    }
}
