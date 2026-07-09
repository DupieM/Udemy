namespace DatesandTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DATETIME 
            var dateTime = new DateTime(2003, 05, 12);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            Console.WriteLine("Birthday: " + dateTime);
            Console.WriteLine("Date: " + now);
            Console.WriteLine("Today: " + today);

            Console.WriteLine();

            // MODIFY DATETIME
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("Tommorow: " + tomorrow);
            Console.WriteLine("Yesterday: " + yesterday);

            Console.WriteLine();

            // CONVERT TO STRINGS
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-mm-dd HH:mm"));

        }
    }
}
