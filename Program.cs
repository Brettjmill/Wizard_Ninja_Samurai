using System;

namespace Wizard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Merlin = new Wizard("Merlin");
            Samurai Katsumoto = new Samurai("Katsumoto");
            Ninja Hayabusa = new Ninja("Hayabusa");

            Console.WriteLine(Merlin.Health);
            Merlin.Attack(Katsumoto);
            Console.WriteLine(Katsumoto.Health);

            Katsumoto.Meditate();
            Console.WriteLine(Katsumoto.Health);

            Katsumoto.Attack(Hayabusa);
            Console.WriteLine(Hayabusa.Health);
            Katsumoto.Attack(Hayabusa);
            Console.WriteLine(Hayabusa.Health);

            Merlin.Heal(Hayabusa);
            Console.WriteLine(Hayabusa.Health);

            Katsumoto.Attack(Hayabusa);
            Console.WriteLine(Hayabusa.Health);
            Hayabusa.Steal(Katsumoto);
            Console.WriteLine(Hayabusa.Health);
            Console.WriteLine(Katsumoto.Health);

            Hayabusa.Attack(Katsumoto);
            Hayabusa.Attack(Katsumoto);
            Hayabusa.Attack(Katsumoto);
            Hayabusa.Attack(Katsumoto);
            Hayabusa.Attack(Katsumoto);
        }
    }
}
