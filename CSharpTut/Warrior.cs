using System;

namespace CSharpTut
{
    class Warrior
    {
        public string Name { get; set; } = "Warrior";
        public int Health { get; set; } = 0;
        private double AttackMaximum { get; set; } = 0;
        private double BlockMaximum { get; set; } = 0; 

        public Warrior(string v1, int v2, int v3, int v4)
        {
            Name = v1;
            Health = v2;
            AttackMaximum = v3;
            BlockMaximum = v4;

        }
        Random rnd = new Random();

        public int Attack()
        {
            int attack = rnd.Next(1, (int)AttackMaximum);
            return attack;
        }
        public int Block()
        {
            int block = rnd.Next(1, (int)BlockMaximum);
            return block;
        }
    }
}