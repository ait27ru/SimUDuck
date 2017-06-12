using System;
using SimUDuck.WinConsole.Behavior;

namespace SimUDuck.WinConsole.Model
{
    public class MallardDuck : BaseDuck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hi, I'm a Mallard Duck");
        }
    }
}