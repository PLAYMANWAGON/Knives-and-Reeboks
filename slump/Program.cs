using System;

namespace slump
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Knives and Reeboks");

            Random generator = new Random();

            bool alive = true;

            Console.WriteLine("Welcome to Knives and Reeboks");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();




            while (alive)
            {


                int tal = generator.Next(100);

                Console.WriteLine(tal % 10);

                Console.WriteLine(tal % 100);




                Console.ReadLine();
            }
        }
    }
}
