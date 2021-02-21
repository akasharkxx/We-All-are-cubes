using System;

namespace OurWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Our World";

            Server.Start(50, 26950);

            Console.ReadKey();
        }
    }
}
