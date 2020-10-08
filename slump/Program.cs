using System;

namespace slump
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Knives and Reeboks");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            Random generator = new Random();

            bool alive = false;

            bool pturn = false;

            string story = "";

            string name = "";

            int devart = 1000;

            int player = 1000;


            Console.WriteLine("Write your name:");
            name = Console.ReadLine();
            Console.Clear();



            Console.WriteLine("Do you want to read the story? (y/n):");
            story = Console.ReadLine();
            Console.Clear();


            if (story == "Y" || story == "y")
            {
                Console.WriteLine("The year is 2052, you wake up in a dark room.");
                Console.WriteLine("It smells musty and you hear a crowd cheering.");
                Console.WriteLine("Suddenly, a gate opens up okay i cant bother writing this shit anymore");
                Console.ReadLine();
            }

            Console.WriteLine(name + " VS. DeviantArt");
            Console.ReadLine();
            Console.WriteLine("FIGHT!");
            Console.ReadLine();
            Console.Clear();

            alive = true;

            pturn = true;


            while (pturn)
            {

                int dmg = generator.Next(100);

                Console.WriteLine("You deal " + dmg % 100 + " Physical Damage and " + dmg % 10 + " Rage Damage.");

                /* SKRIV EN KOD SOM BERÄKNAR DAMAGE OVAN*/

                Console.WriteLine("Enemy's health: " + devart);

                pturn = false;

                Console.ReadLine();
            }

            if (alive == false)
            {
                Console.WriteLine("You died, sucks to be you!");
            }
        }
    }
}

