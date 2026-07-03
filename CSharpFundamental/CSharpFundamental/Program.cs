using CSharpFundamental.Math;

namespace CSharpFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculater calculater = new Calculater();
            var result = calculater.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
