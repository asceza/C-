using System;

namespace numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------
            Console.WriteLine("Type 1");
            int limit = 5;
            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            //----------------------------------------------
            Console.WriteLine("\nType 2");
            for (int i = 0; i < limit; i++)
            {
                for (int j = limit; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            //----------------------------------------------
            Console.WriteLine("\nType 3");
            for (int i = 0; i < limit; i++)
            {
                for (int j = limit; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            //----------------------------------------------
            Console.WriteLine("\nType 4");
            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = limit; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
