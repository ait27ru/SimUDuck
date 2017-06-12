using System;

namespace SimUDuck.WinConsole.Model
{
    public class RubberDuck : BaseDuck
    {
        public override void Display()
        {
            Console.WriteLine("Hello, I'm a Rubber Duck");
        }

        public new void Quack()
        {
            // Rubber ducks don't quack, so it is overriden to squeak
            Console.WriteLine("Squeak");
        }
    }
}