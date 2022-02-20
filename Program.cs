using System;
using RPG_usando_POO.src.Entities;

namespace RPG_usando_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 380, 58);
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 220, 340);
            Ninja ninja = new Ninja("Wedge", 26, "Ninja", 350, 180);
            BlackWizard blackWizard = new BlackWizard("Magus", 25, "Black Wizard", 290, 560);


            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(blackWizard.Attack(7));

        }
    }
}
