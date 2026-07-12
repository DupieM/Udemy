using System.Collections.Generic;

namespace CSharpFundamental3._1
{
   class Program
    {
        static void Main(string[] args)
        {
            // SUMMARISING TEXT
            var sentence = "this is going to be a really really really really long text.";
            var summary = StringUtility.SummarizeText(sentence);
            Console.WriteLine(summary);
        }
    }
}
