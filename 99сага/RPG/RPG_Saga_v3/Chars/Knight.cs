using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Saga
{
    internal class Knight : Character
    {
        Random random = new Random();
        public Knight(int health, int strengh, string characterName) : base(health, strengh)
        {
            this.health = health;
            this.strengh = strengh;
            this.characterName = characterName;

            className = "РЫЦАРЬ";
        }
        public override void AttackEnemy(Character enemy)
        {
            enemy.CheckBurn();
            enemy.ProckStatus();

            if (random.Next(100) >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{Info()} Использует возвратный удар на {enemy.Info()}");
                enemy.TakeDamage(strengh + strengh * 50 / 100);
                Console.ResetColor();
            }
            else
            {
                base.AttackEnemy(enemy);
            }
        }
    }
}
