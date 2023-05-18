using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Saga
{
    internal class Character
    {
        protected int health;
        protected int strengh;
        protected int burnDamage;
        protected int statusCount;

        protected string characterName;
        protected string className;

        protected bool statusStan;
        protected bool statusBurn;

        public Character(int health, int strengh)
        {
            this.health = health;
            this.strengh = strengh;

            statusStan = false;
            statusBurn = false;
        }

        public void Burn()
        {
            statusBurn = true;
            statusCount = 3;
        }
        public void Stan()
        {
            statusStan = true;
            statusCount = 1;
        }

        public bool CheckStan()
        {
            return statusStan;
        }
        public bool CheckBurn()
        {
            return statusBurn;
        }
        public void ProckStatus()
        {
            if (statusBurn)
            {
                TakeDamage(burnDamage = 5);
            }
            if (statusStan)
            {
                return;
            }
        }

        public virtual void AttackEnemy(Character enemy)
        {
            Console.WriteLine($"{Info()} атакует {enemy.Info()}");
            enemy.TakeDamage(strengh);
        }
        public virtual void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine($"{Info()} получает {damage} урона\n");
        }
        public bool CheckDeath()
        {
            return health <= 0;
        }
        public string Info()
        {
            return $"[{className}] {characterName} [{health} HP]";
        }
    }
}