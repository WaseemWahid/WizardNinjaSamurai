using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja bruce = new Ninja("Bruce Lee");
            Wizard gandalf = new Wizard("Gandalf the White");
            Samurai jack = new Samurai("Samurai Jack");
            jack.Attack(gandalf);
            gandalf.Heal(gandalf);
            jack.Meditate();
            bruce.Attack(jack);
            bruce.Steal(gandalf);
            gandalf.Attack(jack);
            jack.Attack(bruce);
        }
    }
}
