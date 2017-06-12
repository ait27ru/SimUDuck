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
            mallardDuck.Quack();
            mallardDuck.Swim();
            mallardDuck.Fly();
            Console.WriteLine();

            var redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.Quack();
            redheadDuck.Swim();
            redheadDuck.Fly();
            Console.WriteLine();

            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Quack();
            rubberDuck.Swim();
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