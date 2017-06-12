using System;
using SimUDuck.WinConsole.Behavior;

namespace SimUDuck.WinConsole.Model
{
    public class RubberDuck : BaseDuck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("Hello, I'm a Rubber Duck");
        }
    }
}