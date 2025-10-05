using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7Firsova_Alekseeva
{
    internal class Player
    {
        private int health = 100;
        public void TakeDamage(int damage)
        {
            if (damage > 0)
            {
                health -= damage;
                Console.WriteLine($"Персонаж получил урона: {damage}. Осталось здоровья: {health}.");

            }
        }
        public int GetHealth()
        {
            return health;
        }
    }
}

