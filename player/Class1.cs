using RandomEnemy;
using BattleRules;
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

        public int guardDuration;
       
        public int att { get; set; }

        //   public int GuardValue { get; set; }

        public bool IsGuarding;

        public Player(string name, int attackpower, int health)
        {

            Random rand = new Random();
            // int att = rand.Next(1, 11);
            // int guard = rand.Next(1, 11);  

            // this.att = attackMulti;
            Name = name;
            attackPower = attackpower;
            Health = health;
           
    

        

        }
        public void Attack(Enemy playerToattack)//, BattleRules Rules)
        {
            

            Random rand = new Random();
            int att = rand.Next(1, 11);
            Console.WriteLine($"player {Name} attacked  {playerToattack.Name}for {attackPower + att} attackpower");
            playerToattack.takeDamage(attackPower + att);

        }
        public void Guarding(bool Isguarding)
        {

            IsGuarding = true;
            guardDuration = 1;
            Console.WriteLine("{0} took a defensive stance", Name);


        }

        public void FireBall(Enemy Playertoattack)
        {
            Random rando = new Random();
            int multi = rando.Next(1, 11);

            Console.WriteLine($"Player { Name} used fireball {Playertoattack.Name} for {multi*3} damage" );

            Playertoattack.takeDamage(multi*3);
                }
        public void ResetStatus()
        {
            IsGuarding = false;  // Set the player's guarding status to false
            guardDuration = 0;  // Set the player's guard duration to 0
        }

        public void takeDamage(int damage)
        {
            if (IsGuarding && guardDuration > 0)
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
                    IsGuarding = false;
                }
            }
            else
            {
                Health -= damage;
                Console.WriteLine($"Player {Name} took {damage} damage and now has {Health} health remaining");
            }

            if (Health <= 0)
            {
                Console.WriteLine($"The player {Name} has died");
                Console.WriteLine("{0} Has been defeated", Name);
            }
            else if (Health > 0)
            {
                Console.WriteLine("Health remaining {0}", Health);
            }
        }
    }
}
