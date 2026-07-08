using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            // ADD() & ADDRANGE()
            numbers.Add(1);
            numbers.AddRange(new int[3] {5, 6, 7});
            
            foreach (int number in numbers)
                Console.WriteLine(number);

            Console.WriteLine(); //-> Make space between writes on console

            // INDEXOF() & LASTINDEXOF()
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); // -> want to start at front of list
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1)); // -> want to somewhere else in list

            // COUNT()
            Console.WriteLine("Count: " + numbers.Count);

            Console.WriteLine();

            // REMOVE()
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                numbers.Remove(numbers[i]);
            }

            foreach (int number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();

            // CLEAR()
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}
