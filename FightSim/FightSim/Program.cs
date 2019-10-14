using System;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduktion
            Console.WriteLine("Hello and welcome to this fighting simulator. First you must create two fighters.");
            //Kallar metoden CreateFighter 2 gånger, en för varge fighter. Lagrar resultatet i instanserna fighter 1 och 2.
            Fighter fighter1 = CreateFighter();
            Fighter fighter2 = CreateFighter();
            //Skapar en array att spara dessa fighters i.
            Fighter[] roster = { fighter1, fighter2 };

            Console.WriteLine(roster[0].name);
            Console.WriteLine(roster[1].name);

            //Rensar upp i konsollen
            Console.Clear();

            //Kallar metoden gameround med båda fighters osm parametrar
            GameRound(fighter1, fighter2);

            Console.ReadLine();
        }

        //Metod som tar fighter1 och 2 som parametrar och sparar dessa i f1 och f2
        static void GameRound(Fighter f1, Fighter f2)
        {
            //Loop som körs så länge båda fighters lever
            while (f1.isAlive() == true && f2.isAlive() == true)
            {
                //fighter1 (f1) börjar med att slå fighter2 (f2)
                //Sparar skadan som fighter1 gör i inten dmg1
                int dmg1 = f1.Attack();
                //Kallar metoden Hurt i fighter2 med dmg1 som parameter
                f2.Hurt(dmg1);
                //Skriver ut skadan som sker
                Console.WriteLine(f1.name + " hurt " + f2.name + " for " + dmg1 + " health!");

                //fighter2 (f2) slår sedan fighter1 (f1)
                //Sparar skadan som fighter2 gör i inten dmg2
                int dmg2 = f1.Attack();
                //Kallar metoden Hurt i fighter1 med dmg2 som parameter
                f2.Hurt(dmg2);
                //Skriver ut skadan som sker
                Console.WriteLine(f2.name + " hurt " + f1.name + " for " + dmg2 + " health!");
                //Instruktioner till användaren
                Console.WriteLine("Press enter to continue");
                //Användaren klickar enter för nästa runda
                Console.ReadLine();
                //Rensar upp i konsollen
                Console.Clear();
            }
            //Hämtar hp från båda fighters
            bool living = f1.isAlive();
            if(living == true)
            {
                Console.WriteLine(f1.name + " is the winner!");
            }
            else
            {
                Console.WriteLine(f2.name + " is the winner!");
            }
        }


        //Metod som skapar en fighter
        static Fighter CreateFighter()
        {
            //Skapar en ny fighter
            Fighter fighter = new Fighter();
            //Instruktioner till användaren
            Console.WriteLine("Please type a name for the fighter: ");
            fighter.name = Console.ReadLine().Trim();
            return fighter;
        }
    }
}
