namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            var lastName = "Hamedani";

            // Concatenation
            var fullName = firstName + " " + lastName;

            // String Format
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            // String Join
            var name = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", name);

            //var text = "Hi Jon\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4"; -> Normal String
            //Verbatim Strings
            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4"; 
            Console.WriteLine(text);
        }

    }
}
