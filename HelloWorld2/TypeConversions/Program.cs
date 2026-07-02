namespace TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 1000;
            //byte b =  (byte) i;
            //Console.WriteLine(b);

            //var number = "1234";
            //int i = Convert.ToInt32(number)
            //Console.WriteLine(i);

            //try
            //{
            //    var number = "1234";
            //    byte b = Convert.ToByte(number);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Ther number could not be converted to a byte.");
            //}

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Ther number could not be converted to a boolean.");
            }

        }
    }
}
