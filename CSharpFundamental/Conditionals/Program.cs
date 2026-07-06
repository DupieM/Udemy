namespace Conditionals
{

    class Program
    {
        static void Main(string[] args)
        {
            // If / Else Statement
            //int hour = 15;
            //if (hour > 0 && hour <12)
            //{
            //    Console.WriteLine("It's morning.");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("It's afternoon.");
            //}
            //else
            //{
            //    Console.WriteLine("It's evening");
            //}

            // Conditional Opperator
            //bool isGoldCustomer = true;
            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f
            //}
            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                //case Season.Autumn:
                //    Console.WriteLine("It's Autumn and a beautiful season.");
                //    break;

                case Season.Autumn:
                case Season.Summer:
                    //Console.WriteLine("It's perfect to go to beach.");
                    Console.WriteLine("We've got promotion.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }
        }
    }
}
