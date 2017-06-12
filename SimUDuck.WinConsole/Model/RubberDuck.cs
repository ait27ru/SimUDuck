using System;
using SimUDuck.WinConsole.Interface;

namespace SimUDuck.WinConsole.Model
{
    public class RubberDuck : BaseDuck, IQuackable
    {
        public void Quack()
        {
            // Rubber ducks don't quack, so it is overriden to squeak
            Console.WriteLine("Squeak");
        }

        public override void Display()
        {
            Console.WriteLine("Hello, I'm a Rubber Duck");
        }
    }
}