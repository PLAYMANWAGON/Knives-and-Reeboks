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

            string enemy = "";

            int enehealth = 300;

            int player = 300;

            bool fight = false;

            bool allalive = false;


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

            int enemygen = generator.Next(4);

            if (enemygen == 0)
            {

                enemy = "Burger";

            }

            if (enemygen == 1)
            {

                enemy = "Sir Crackpipe CCXVI";
            }

            if (enemygen == 2)
            {

                enemy = "Katia Mannagan from famous webcomic \"Prequel -or- Making A Cat Cry: The Adventure\"";

            }

            if (enemygen == 3)
            {

                enemy = "Famous japanese vocalist, DJ and visual artist Yamataka Eye";
            }

            Console.WriteLine(name + " VS. " + enemy);
            Console.ReadLine();
            Console.WriteLine("FIGHT!");
            Console.ReadLine();
            Console.Clear();

            pturn = true;

            fight = true;

            allalive = true;



            while (fight)
            {

                while (allalive)
                {



                    while (pturn)
                    {

                        int dmg = generator.Next(101);

                        int sum = dmg % 100 + dmg % 5;

                        Console.WriteLine("You deal " + dmg % 100 + " Physical Damage and " + dmg % 5 + " Gamer Damage.");

                        if (sum >= 95)
                        {
                            int crt = generator.Next(25, 50);
                            Console.WriteLine("CRITICAL HIT!");
                            Console.WriteLine("You deal additional " + crt + " damage!");
                            sum = sum + crt;
                        }

                        Console.WriteLine("A total of: " + sum + " damage.");

                        if (sum == 0)
                        {
                            Console.WriteLine("You missed... damn, you suck :/");
                        }

                        enehealth = enehealth - sum;

                        Console.WriteLine(enemy + "'s health: " + enehealth);

                        pturn = false;

                        Console.ReadLine();
                        Console.Clear();

                        if (enehealth <= 0)
                        {
                            allalive = false;
                        }

                        break;

                    }

                    while (!pturn)
                    {

                        int dmg = generator.Next(101);

                        int sum = dmg % 100 + dmg % 5;

                        Console.WriteLine(enemy + " deals " + dmg % 100 + " Physical Damage and " + dmg % 5 + " Cringe Damage.");

                        if (sum >= 95)
                        {
                            int crt = generator.Next(25, 50);
                            Console.WriteLine("CRITICAL HIT!");
                            Console.WriteLine(enemy + " deals additional " + crt + " damage.");
                            sum = sum + crt;
                        }

                        Console.WriteLine("A total of: " + sum + " damage.");

                        if (sum == 0)
                        {
                            Console.WriteLine(enemy + " missed... haha, loser.");
                        }

                        player = player - sum;

                        Console.WriteLine("Your health: " + player);

                        pturn = true;

                        Console.ReadLine();
                        Console.Clear();

                        if (player <= 0)
                        {
                            allalive = false;

                        }

                        break;

                    }

                }

                if (player <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You died, ok.");
                    Console.ReadLine();
                    fight = false;
                }

                if (enehealth <= 0)
                {
                    Console.Clear();
                    Console.WriteLine(enemy + " is dead, nice.");
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

