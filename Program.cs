using System;

namespace Kaitlyn
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new Bot();
            bot.RunAsync().GetAwaiter().GetResult();
            Console.WriteLine("Kaitlyn is Online! <3");
        }
    }
}
