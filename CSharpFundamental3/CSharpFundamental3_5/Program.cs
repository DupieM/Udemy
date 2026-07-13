namespace CSharpFundamental3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PATH 
            var path = @"C:\Users\USER-PC\Documents\Udemy\Udemy\CSharpFundamental3\CSharpFundamental3\Program.cs";

            var dotIndex = path.IndexOf(".");
            var extensi = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
