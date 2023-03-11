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
        
        public int guardDuration { get; set; }

        public bool isguarding { get; set; }


        public Enemy(string Name, int attackpower, int health)
        {
            Random rand = new Random();
            List<string> enemy = new List<string> { "orc", "theif", "knight", "elf" };

            int enemyType = rand.Next(enemy.Count);
            string name1 = enemy[enemyType];
            string Newname = $"{name1}";


            //int guard = rand.Next(1, 21);
            // int att = rand.Next(1, 21); 

            //GuardValue =guard;
            // att = attackMulti;
            this.Name = Newname;
            attackPower = attackpower;
            Health = health;
            // Guard = guard;


        }

        public void randomAttack(Player enemyToAttack)
        {
            Random rand = new Random();
            int randomattack = rand.Next(1,3);

            {
                switch (randomattack)
                {
                    case 1:
                        enemyToAttack.Attack(this);
                        int att = rand.Next(1, 11);
                        
                        Console.WriteLine($"enemy {Name} attacked player {enemyToAttack.Name}for {attackPower + att} attackpower");
                        enemyToAttack.takeDamage(attackPower + att);
                        
                        break;
                    case 2:
                        Guard(true);
                        Console.WriteLine($"{Name} is guarding!");
                        break;
                   /* case 3:
                        enemyToAttack.Attack(this);
                        int Att = rand.Next(1, 11);
                        Console.WriteLine($"enemy {Name} attacked player {enemyToAttack.Name}for {attackPower + Att} attackpower");
                        enemyToAttack.takeDamage(attackPower + Att);
                        break;*/
                    


                     
                }

            }
        }
        public void Attack(Player enemyToattack)
        {
            int att = Random.Shared.Next(1, 11);
            Console.WriteLine($"enemy {Name} attacked player {enemyToattack.Name}for {attackPower + att} attackpower");
            enemyToattack.takeDamage(attackPower + att);

        }


        public void Guard(bool Isguarding)

        {
            Console.WriteLine("enemy took a defensive stance");
            isguarding = Isguarding;
            guardDuration = 1;
        }




        public void takeDamage(int damage)
        {
            if (isguarding && guardDuration > 0)
            {
                Random rand = new Random();
                int GuardValue = rand.Next(1, 21);
                int ndamage = Math.Max(damage - GuardValue, 0);

                if (ndamage <= 0)
                {
                    Console.WriteLine($"{Name} negated damage {ndamage}");
                }
                else
                {
                    Health -= ndamage;
                    Console.WriteLine($"Player {Name} took {ndamage} damage and now has {Health} health remaining");
                }

                if (GuardValue == 0)
                {
                    Console.WriteLine($"{Name}'s guard was broken and took full damage");
                    Health -= damage;
                    Console.WriteLine($"Player {Name} took {damage} damage and now has {Health} health remaining");
                    isguarding = false;
                }
            }
            else
            {
                Health -= damage;
                Console.WriteLine($"enemy {Name} took {damage} damage and now has {Health} health remaining");
            }

            if (Health <= 0)
            {
                Console.WriteLine($"The enemy {Name} has died");
                Console.WriteLine("{0} Has been defeated", Name);
            }
            else if (Health > 0)
            {
                Console.WriteLine("Health remaining {0}", Health);
            }
        }
    }
}
