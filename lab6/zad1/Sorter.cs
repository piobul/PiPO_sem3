using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class Sorter
    {
        private SortingAlgorithm algorithm;

        public void SetAlgorithm(SortingAlgorithm newAlgorithm)
        {
            algorithm = newAlgorithm;
        }

        public List<int> Sort(List<int> list)
        {
            if (algorithm == null)
                throw new InvalidOperationException("Nie ustawiono algorytmu sortowania (uzyj SetAlgorithm).");
            return algorithm.Sort(list);
        }
    }
}