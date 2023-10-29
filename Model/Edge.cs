﻿using AlgorithmDijkstra.Interfaces;

namespace AlgorithmDijkstra.Model
{
    public class Edge : IEdge<Vertex> 
    {
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        public int Weight { get; set; }

        public Edge(Vertex from, Vertex to, int weight = 1)
        {
            From = from;
            To = to;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Из {From} в {To}";
        }
    }
}
