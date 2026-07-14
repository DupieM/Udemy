namespace CSharpFundamentalFinal
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // DEBUGGING
            var numbers = new List<int>();
            var smallests = GetSmallests(null, 1);

                        
            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            // OLD CODE
            //var smallests = new List<int>(); -> part 1

            //while (smallests.Count < count)
            //{
            //    var min = GetSmallest(list);
            //    smallests.Add(min);
            //    list.Remove(min);
            //}

            //var buffer = new List<int>(list); -> part 2
            //var smallests = new List<int>();

            //while (smallests.Count < count)
            //{
            //    var min = GetSmallest(buffer);
            //    smallests.Add(min);
            //    buffer.Remove(min);
            //}

            // NEW CODE
            if (list == null)
                throw new ArgumentNullException("list");

            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list.");

            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
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
                if (list[i] > min)
                {
                    min = list[i];
                }
            }
            return min;
        }
    }
}
