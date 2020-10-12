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

            bool pturn = false;

            string story = "";

            string name = "";

            int devart = 500;

            int player = 500;

            bool fight = false;


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

            pturn = true;

            fight = true;



            while (fight)
            {
                while (pturn)
                {

                    int dmg = generator.Next(101);

                    int sum = dmg % 100 + dmg % 10;

                    Console.WriteLine("You deal " + dmg % 100 + " Physical Damage and " + dmg % 10 + " Gamer Damage.");

                    Console.WriteLine("A total of: " + sum + " damage.");

                    devart = devart - sum;

                    Console.WriteLine("Enemy's health: " + devart);

                    pturn = false;

                    Console.ReadLine();
                    Console.Clear();
                }

                while (!pturn)
                {

                    int dmg = generator.Next(101);

                    int sum = dmg % 100 + dmg % 10;

                    Console.WriteLine("DeviantArt deals " + dmg % 100 + " Physical Damage and " + dmg % 10 + " Cringe Damage.");

                    Console.WriteLine("A total of: " + sum + " damage.");

                    player = player - sum;

                    Console.WriteLine("Your health: " + player);

                    pturn = true;

                    Console.ReadLine();
                    Console.Clear();
                }

                if (player <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You died, ok.");
                    Console.ReadLine();
                    fight = false;
                }

                if (devart <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("DeviantArt is dead, nice.");
                    Console.ReadLine();
                    fight = false;
                }

            }

            Console.Clear();

            Console.WriteLine("THe End");

            Console.ReadLine();

        }
    }
}

