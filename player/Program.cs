using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using player;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using RandomEnemy;

namespace game;


public static class battle

{


    public static void Main(string[] args)

    {
        Console.WriteLine("Please enter player name:");
        string player1Name = Console.ReadLine();
        //att
        //  int attack = att.Next (1, 21);
        var newPlayer = new Player(player1Name, 10, 100, 15 );

        Enemy newenemy = new Enemy("some_name", 15, 100, 20 );

        Console.WriteLine("you have encounted {0}", newenemy.Name);



        bool alive = false;
        while (!alive)

        {

            Console.WriteLine("enter attack or run");

            string attack = Console.ReadLine();

            if (attack == "attack")
            {
                
                alive = false;
                newPlayer.Attack(newenemy);
                
                
                newenemy.Guard(newPlayer);

                {

                   newPlayer.Attack(newenemy);
                }
                    if (newenemy.Health <= 0)
                {
                    Console.WriteLine("The enemy has been defeated!");
                    
                }
            }

            // alive = true;

        }

        

        }
    }

    /* string PlayerName = Console.ReadLine();
     var newplayer = new Player()
     {
         Name = PlayerName,
         attackPower = 10,
         Health = 100
     };*/



//}





