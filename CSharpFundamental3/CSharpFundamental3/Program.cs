namespace CSharpFundamental3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Marine du Plessis ";

            // TRIM & UPPER
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            Console.WriteLine();

            // BREAK INTO FIRST AND LAST NAME   
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            Console.WriteLine();

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            Console.WriteLine();

            // REPLACE
            Console.WriteLine(fullName.Replace("Marine", "marine"));

            Console.WriteLine();

            // METHODS TO USE WITH NULL OR EMPTY STRINGS
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            Console.WriteLine();

            // CONVERT NUMBER TO STRING & STRING TO NUMBER
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
