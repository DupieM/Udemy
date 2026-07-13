namespace CSharpFundamentalFinal
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // DEBUGGING
            var numbers = new List<int> { 1, 2};
            var smallests = GetSmallests(numbers, 3);

                        
            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            // OLD CODE
            //var smallests = new List<int>();

            //while (smallests.Count < count)
            //{
            //    var min = GetSmallest(list);
            //    smallests.Add(min);
            //    list.Remove(min);
            //}

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
                if (list[i] > min)
                {
                    min = list[i];
                }
            }
            return min;
        }
    }
}
