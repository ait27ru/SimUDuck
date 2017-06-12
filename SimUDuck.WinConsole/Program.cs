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

            var redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.Quack();
            redheadDuck.Swim();
            redheadDuck.Fly();

            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Quack();
            rubberDuck.Swim();
            rubberDuck.Fly();

            Console.Write("Press Enter to exit ...");
            Console.ReadLine();
        }
    }
}