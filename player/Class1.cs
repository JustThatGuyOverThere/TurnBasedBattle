using RandomEnemy;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int attackPower { get; set; }

        public int att { get; set; }

        public int GuardValue { get; set; }

        public Player(string name, int attackpower, int health, int guard)
        {

            Random rand = new Random();
           // int att = rand.Next(1, 11);
           // int guard = rand.Next(1, 11);  
           GuardValue = guard;
           // this.att = attackMulti;
            Name = name;
            attackPower = attackpower;
            Health = health;


        }
        public void Attack(Enemy playerToattack)
        {
            Random rand = new Random();
            int att = rand.Next(1, 11);
            Console.WriteLine($"player {Name} attacked  {playerToattack.Name}for {attackPower + att} attackpower");
            playerToattack.takeDamage(attackPower +att);

        }
        public void Guard(Player playerToguard)
        {
            Random rand = new Random();
           // int GuardValue = rand.Next(1, 21);
            Console.WriteLine($"player {Name} is guarding with a guard value of {GuardValue}");
           // int guardDamage = Math.Max(attackPower + att - GuardValue, 0);
            playerToguard.negateDamage(GuardValue);
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
            int ndamage = damage - GuardValue;

            if (ndamage <= 0) { Console.WriteLine($"{Name} negated damage"); }
            else

            {
                Health -= ndamage;

                //Health -= damage;

                //Health -= damage;
                Console.WriteLine($"Player {Name} took {damage} damage amd now has {Health} health remaining");
            }
            if (Health <= 0)
            {
                Console.WriteLine($"the player {Name} has died");


                Console.WriteLine("{0} Has been defeated", Name);

            }
            else if (Health > 0)
            {
                Console.WriteLine("health remaining {0}", Health);
            }
            {
                
            }
        }

    }
}