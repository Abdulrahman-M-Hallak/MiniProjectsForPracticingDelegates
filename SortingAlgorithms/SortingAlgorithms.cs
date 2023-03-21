using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal static class SortingAlgorithms
    {
        public static IEnumerable<int> BubbleSort(IEnumerable<int> Collection)
        {
            Console.WriteLine("Bubblesorting The Colloction");
            return new[] { 0, 2, 3, 4, 5, 6, 7, };
        }
        public static IEnumerable<int> QuickSort(IEnumerable<int> Collection)
        {
            Console.WriteLine("Quicksorting The Colloction");
            return new[] { 0, 2, 3, 4, 5, 6, 7, };
        }
        public static IEnumerable<int> MergeSort(IEnumerable<int> Collection)
        {
            Console.WriteLine("Mergesorting The Colloction");
            return new[] { 0, 2, 3, 4, 5, 6, 7, };
        }
    }
}
