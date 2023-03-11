using player;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RandomEnemy
{
    public class Enemy

    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int attackPower { get; set; }

        public int att { get; set; }

        public int GuardValue{ get; set; }

        public Enemy(string Name, int attackpower, int health , int guard)
        {
            Random rand = new Random();
            List<string> enemy = new List<string> { "orc", "theif", "knight", "elf" };

            int enemyType = rand.Next(enemy.Count);
            string name1 = enemy[enemyType];
            string Newname = $"{name1}";


            //int guard = rand.Next(1, 21);
           // int att = rand.Next(1, 21); 

            GuardValue =guard;
           // att = attackMulti;
            this.Name = Newname;
            attackPower = attackpower;
            Health = health;
            // Guard = guard;


        }




        public void Attack(Player enemyToattack)
        {
            int att = Random.Shared.Next(1, 11);
            Console.WriteLine($"player {Name} attacked player {enemyToattack.Name}for {attackPower + att} attackpower");
            enemyToattack.takeDamage(attackPower + att);

        }
      
        public void Guard(Player enemyToguard)
        {
            Random rand = new Random();
          //int GuardValue = rand.Next(1, 21);
            Console.WriteLine($"player {Name} is guarding with a guard value of {GuardValue}");
         //  int guardDamage =Math.Max (attackPower + att - GuardValue, 0);
            enemyToguard.negateDamage;
            
        }

        public void negateDamage(int damage)
        {
            {
                int ndamage = damage - GuardValue;

                if (ndamage <= 0)
                {
                    Console.WriteLine($"{Name} negated damage");
                }
                else
                {
                    Health -= ndamage;
                    Console.WriteLine($"Player {Name} took {ndamage} damage and now has {Health} health remaining");
                }

                if (Health <= 0)
                {
                    Console.WriteLine($"the enemy {Name} has died");
                }
                else if (Health > 0)
                {
                    Console.WriteLine("health remaining {0}", Health);
                }
            }
        }
        public void takeDamage(int damage)
        {
            
            Health -= damage;
            {
                

                //Health -= damage;
                Console.WriteLine($"Player {Name} took {damage} damage amd now has {Health} health remaining");
            }
            if (Health <= 0)
            {
                Console.WriteLine($"the enemy {Name} has died");


                Console.WriteLine("{0} Has been defeated", Name);

            }
            else if (Health > 0)
            {
                Console.WriteLine("health remaining {0}", Health);
            }

            
        }

    }
}

