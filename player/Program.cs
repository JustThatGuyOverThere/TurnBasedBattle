﻿using System;
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
using BattleRules;
using System.Runtime.Versioning;

namespace game;


public static class Battle

{


    public static void Main(string[] args)

    {
        Console.WriteLine("Please enter player name:");
        string player1Name = Console.ReadLine();
        //att
        //  int attack = att.Next (1, 21);
        var newPlayer = new Player(player1Name, 10, 100);

        Enemy newenemy = new Enemy("some_name", 10, 100);
        var Rules = new battleRules(); 

        Console.WriteLine("you have encounted {0}", newenemy.Name);



        bool dead = false;
        while (!dead)

        {
            // bool Attack = false;
            //while (!Attack)
           
            Console.WriteLine("enter attack,guard, fireball");
            var attack = Console.ReadLine();
            
            
            switch (attack)
            {
                case "attack":
                    newPlayer.Attack(newenemy);
                    
                    break;
                case "guard":
                    newPlayer.Guarding(true);
                   
                    break;
                case "FireBall":
                    newPlayer.FireBall(newenemy);
                    break;
            }


                    newenemy.randomAttack(newPlayer);
            Rules.EndofTurn();

            if (newenemy.Health <= 0)
                {dead = true;
                    Console.WriteLine("The enemy has been defeated!");

                }

         

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





