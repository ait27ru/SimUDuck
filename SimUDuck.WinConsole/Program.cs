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

            var redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.Quack();
            redheadDuck.Swim();

            Console.Write("Press Enter to exit ...");
            Console.ReadLine();
        }
    }
}