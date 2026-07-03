namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var a = 10;
            //var b = 3;
            //Console.WriteLine(a + b); -> 13
            //Console.WriteLine(a / b); -> 3
            //Console.WriteLine((float)a / (float)b); -> 3,3333

            //var a = 1;
            //var b = 2;
            //var c = 3;
            //Console.WriteLine( a + b * c); -> 7
            //Console.WriteLine((a + b) * c); -> 9

            //var a = 1;
            //var b = 2;
            //Console.WriteLine(a > b); -> False
            //Console.WriteLine(a == b); -> False
            //Console.WriteLine(a != b); -> True

            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);
        }
    }
}
