using System;
using System.Collections.Generic;
using System.Text;

namespace FightSim
{
    class Fighter
    {
        int hp;
        public string name;

        public int Attack()
        {
            int dmg = 5;
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
