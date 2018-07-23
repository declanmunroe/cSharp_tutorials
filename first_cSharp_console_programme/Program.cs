using System;

namespace first_cSharp_console_programme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
            }
            Console.ReadLine();

        }
    }
}
