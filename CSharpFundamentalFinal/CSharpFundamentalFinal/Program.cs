namespace CSharpFundamentalFinal
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // DEBUGGING
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);
            //var numbers = new List<int>(); -> part 3 (Defensive Programming)
            //var smallests = GetSmallests(null, 1);


            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            // OLD CODE
            //var smallests = new List<int>(); -> part 1 (Debugging Tools)

            //while (smallests.Count < count)
            //{
            //    var min = GetSmallest(list);
            //    smallests.Add(min);
            //    list.Remove(min);
            //}

            //var buffer = new List<int>(list); -> part 2 (Removing Side Effects)
            //var smallests = new List<int>();

            //while (smallests.Count < count)
            //{
            //    var min = GetSmallest(buffer);
            //    smallests.Add(min);
            //    buffer.Remove(min);
            //}

            //if (list == null) -> part 3 (Defensive Programming)
            //    throw new ArgumentNullException("list");
            //if (count > list.Count || count <= 0)
            //    throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list.");

            // NEW CODE
            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count && buffer.Count > 0)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                // changed > to < 
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }
    }
}
