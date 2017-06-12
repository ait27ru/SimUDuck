using System;
using SimUDuck.WinConsole.Model;

namespace SimUDuck.WinConsole
{
    internal class Program
    {
        private static void Main()
        {
            var mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();
            mallardDuck.PerformFly();
            Console.WriteLine();

            var redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.PerformQuack();
            redheadDuck.Swim();
            redheadDuck.PerformFly();
            Console.WriteLine();

            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformQuack();
            rubberDuck.Swim();
            rubberDuck.PerformFly();
            Console.WriteLine();

            var decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.Swim();
            Console.WriteLine();

            Console.Write("Press Enter to exit ...");
            Console.ReadLine();
        }
    }
}