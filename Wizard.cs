using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        // Wizard should have a default health of 50 and Intelligence of 25
        public Wizard(string name) : base(name)
        {
            Name = name;
            Intelligence = 25;
            health = 50;
        }
        // Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence 
        // and heals the Wizard by the amount of damage dealt
        public override int Attack(Human target)
        {
            int damage = Intelligence * 5;
            target.Health -= damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            health += damage;
            return target.Health;
        }
        // Wizard should have a method called Heal, 
        // which when invoked, heals a target Human by 10 * Intelligence
        public int Heal(Human target)
        {
            int heal = Intelligence * 10;
            target.Health += heal;
            Console.WriteLine($"{Name} healed {target.Name} for {heal.ToString()} health!");
            return target.Health;
        }
    }
}