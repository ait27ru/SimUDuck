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

        public new void Fly()
        {
            // Rubber ducks don't fly either, so it is overriden to do nothing
        }
    }
}