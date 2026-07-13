namespace CSharpFundamental3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DIRECTORY & DIRECTORYINFO
            Directory.CreateDirectory(@"c:\temp\folder1");

            //var folders = Directory.GetFiles(@"c:\Users\USER-PC\Documents\Udemy\Udemy\CSharpFundamental3", "*Program.cs", SearchOption.AllDirectories);
            //foreach (var folder in folders)
            //{
            //    Console.WriteLine(folder);
            //}
                        
            var directories = Directory.GetDirectories(@"c:\Users\USER-PC\Documents\Udemy\Udemy", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
