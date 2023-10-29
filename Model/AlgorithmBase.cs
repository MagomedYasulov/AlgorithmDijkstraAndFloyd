using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDijkstra.Model
{
    public abstract class AlgorithmBase
    {
        public double[,] GraphMatrix { get; set; }

        public AlgorithmBase(double[,] graphMartix)
        {
            GraphMatrix = graphMartix;
        }

        public abstract  (double, List<int>) GetMinLenght(int FromVertex, int ToVertex);

    }
}
