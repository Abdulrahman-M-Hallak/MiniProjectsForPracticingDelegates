namespace SortingAlgorithms
{
    public delegate IEnumerable<int> SortCollection(IEnumerable<int> Collection);
    internal class Program
    {

        static void Main(string[] args)
        {
            IList<int> list = new List<int>() { 1, 2, 3, 4, 5, 5, 6, 7, 8 };
            Dictionary<int, SortCollection> Algorithms = new Dictionary<int, SortCollection>()
            {
                {1 , SortingAlgorithms.QuickSort },
                {2 , SortingAlgorithms.BubbleSort },
                {3 , SortingAlgorithms.MergeSort },
            };

            Console.WriteLine("How do you want to sort the array?");
            Console.WriteLine("For quicksort enter 1");
            Console.WriteLine("For bubblesort enter 2");
            Console.WriteLine("For Mergesort enter 3");

            IEnumerable<int> sortedCollection;
            var algorithmNumber = int.Parse(Console.ReadLine());
            if (Algorithms.TryGetValue(algorithmNumber, out SortCollection algorithm))
            {
                sortedCollection = PerformSorting(list, algorithm);

                foreach (var item in sortedCollection)
                {
                    Console.WriteLine(item);
                }
            }


        }
        // You should probably come up with a method that does something on a sorted collection instead of this.
        // So you just give the collection and the delegate to sort the collection, does some thing on it and return some thing.
        // This way, are encapsulating away the sorting from the main purpose of the funtion that i am yet to come up with lol.
        static IEnumerable<int> PerformSorting(IEnumerable<int> Collection, SortCollection sortCollection)
        {
            return sortCollection(Collection);
        }
    }
}