using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighter
    {
        //Bas hp för alla fighters är 50
        protected int hp = 50;
        public string name;
        Random generator = new Random();
        

        //Attackerar genom att returna en slumpmässig mängd skada
        public int Attack()
        {
            //Slumpar ett tal mellan 1 och 10 som blir skadan.
            int dmg = generator.Next(0, 11);
            return dmg;
        }

        //Skadar fightern
        public void Hurt(int amount)
        {
            //Tar hp minus parametern amount
            hp -= amount;
        }

        //Kollar om denna fighter är vid liv
        public bool isAlive()
        {
            //Variabel som returneras
            bool alive;
            //Kollar om hp är under 0 och sätter sedan alive till true eller false beroende på svaret
            if(hp > 0)
            {
                alive = true;
            }
            else
            {
                alive = false;
            }
            return alive;
        }

        //Hämtar fighters hp
        public int GetHp()
        {
            return (hp);
        }

    }
}
