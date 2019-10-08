using System;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array som samlar de båda fighters.

            Console.WriteLine("Hello planet");
            //Kallar metoden CreateFighter 2 gånger, en för varge fighter. Lagrar resultatet i instanserna fighter 1 och 2.
            Fighter fighter1 = CreateFighter();
            Fighter fighter2 = CreateFighter();
            //Skapar en array att spara dessa fighters i.
            Fighter[] roster = { fighter1, fighter2 };



            Console.ReadLine();
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
