using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighter
    {
        int hp = 50;
        public string name;
        Random generator = new Random();
        

        public int Attack()
        {
            //Slumpar ett tal mellan 1 och 10 som blir skadan.
            int dmg = generator.Next(0, 11);
            return (dmg);
        }

        public void Hurt(int amount)
        {
            hp -= amount;
        }

        public bool isAlive()
        {
            bool alive;
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

        public int GetHp()
        {
            return (hp);
        }

    }
}
