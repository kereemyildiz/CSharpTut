using System;

namespace CSharpTut
{
    class Battle
    {
        public static void StartFight(Warrior warriorA,Warrior warriorB)
        {
            while(true)
            {
                if(GetAttackResult(warriorA,warriorB) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warriorB, warriorA) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                Console.WriteLine("");
               
            }

        }

        public static string GetAttackResult(Warrior attacker, Warrior defender)
        {
            int attack = attacker.Attack();
            int block = defender.Block();
            int damage = attack - block;
            if (damage > 0)
            {
                defender.Health -= damage;
            }
            else
            {
                damage = 0;
            }
            Console.WriteLine("{0} attacked {1} and gives {2} damage", attacker.Name, defender.Name, damage);

            if (defender.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} victorious\n",defender.Name,attacker.Name);
                return "Game Over";
            }
            return "";
        }
    }
}