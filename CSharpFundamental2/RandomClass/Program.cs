namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLength = 13;

            char[] buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
                buffer[i] = ((char)('a' + random.Next(0, 26)));

            var password = new string(buffer);

            Console.WriteLine(password);


            //for (int i = 0; i < 10; i++)
            //    Console.Write((char)('a' + random.Next(0, 26)));

            //Console.WriteLine((int)'+');

        }
    }
}
