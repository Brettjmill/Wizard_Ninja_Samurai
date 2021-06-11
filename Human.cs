using System;

namespace Wizard_Ninja_Samurai{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;
        public int CurrentHealth
        {
            get { return Health; }
        }
        public Human(string inputName)
        {
            Name = inputName;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        public Human(string inputName, int inputStrength, int inputIntelligence, int inputDexterity, int inputHealth)
        {
            Name = inputName;
            Strength = inputStrength;
            Intelligence = inputIntelligence;
            Dexterity = inputDexterity;
            Health = inputHealth;
        }

        public virtual int Attack(Human target)
        {
            int damage = 5 * Strength;
            target.Health -= damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return target.Health;
        }
    }

        class Wizard : Human
        {
            public Wizard(string inputName) : base(inputName)
            {
                Intelligence = 25;
                Health = 50;
            }

            public override int Attack(Human target)
            {
                int damage = 5 * Intelligence;
                target.Health -= damage;
                Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
                Health += damage;
                if(Health > 50)
                {
                    Health = 50;
                }
                return target.Health;
            }

            public int Heal(Human target)
            {
                int healthRestored = 10 * Intelligence;
                target.Health += healthRestored;

                if(target is Samurai && target.Health > 200)
                {
                    target.Health = 200;
                }
                if(target is Ninja && target.Health > 100)
                {
                    target.Health = 100;
                }
                if(target is Wizard && target.Health > 50)
                {
                    target.Health = 50;
                }

                Console.WriteLine($"{Name} healed {target.Name} for {healthRestored} health!");
                return target.Health;
            }
        }

        class Ninja : Human
        {
            public Ninja(string inputName) : base(inputName)
            {
                Dexterity = 175;
            }

            public override int Attack(Human target)
            {
                int damage = 5 * Dexterity;

                Random rand = new Random();
                int bonusDamageChance = rand.Next(1,6);

                if(bonusDamageChance == 5)
                {
                    damage += 10;
                }

                target.Health -= damage;
                Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
                return target.Health;
            }

            public int Steal(Human target)
            {
                int damage = 5;
                target.Health -= damage;
                Health += damage;
                if (Health > 100)
                {
                    Health = 100;
                }
                Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage and recovered {damage} health!");
                return target.Health;
            }
        }

        class Samurai : Human
        {
            public Samurai(string inputName) : base(inputName)
            {
                Health = 200;
            }

            public override int Attack(Human target)
            {
                int damage = 5 * Strength;

                if (target.Health < 50)
                {
                    target.Health = 0;
                    Console.WriteLine($"{Name} attacked {target.Name}!  {target.Name} has been slain!");
                    return target.Health;
                }
                else{
                    target.Health -= damage;
                    Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
                    return target.Health;
                }
            }

            public int Meditate()
            {
                Health = 200;
                Console.WriteLine($"{Name} has recovered to full health!");
                return Health;
            }
        }
}
