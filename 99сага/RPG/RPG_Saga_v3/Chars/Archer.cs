using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Saga
{
    internal class Archer : Character
    {
        Random random = new Random();
        public Archer(int health, int strengh, string characterName) : base(health, strengh)
        {
            this.health = health;
            this.strengh = strengh;
            this.characterName = characterName;

            burnDamage = 0;

            className = "ЛУЧНИК";
        }
        public override void AttackEnemy(Character enemy)
        {
            enemy.CheckBurn();
            enemy.ProckStatus();

            if (random.Next(100) >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Info()} оджигает {enemy.Info()}");
                enemy.Burn();
                base.AttackEnemy(enemy);
                Console.ResetColor();
            }
            else
            {
                base.AttackEnemy(enemy);
            }
        }
    }
}
