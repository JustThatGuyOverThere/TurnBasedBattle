using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using player;
using RandomEnemy;


namespace BattleRules
{
    public class battleRules
    {
        public int TurnCounter;


        public int Turnstoreset = 2;
        public int turnssinceReset = 0;

        private Player player;
        private Enemy enemy;

        public battleRules()
        {
            TurnCounter = 0;
        }
        public void EndofTurn()
        { 
            TurnCounter++;
            Console.WriteLine($"turn {TurnCounter}");
            turnssinceReset++;
            if (turnssinceReset >= Turnstoreset  ) 
            {
                turnssinceReset = 0;  
                Player.ResetStatus();
                Enemy.ResetStatus();
            }
           
        }


        public int getTurncount()
        { 
            return TurnCounter;
            
        }
    }
}


        
    
    



