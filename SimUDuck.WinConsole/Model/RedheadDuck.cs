using System;
using SimUDuck.WinConsole.Behavior;

namespace SimUDuck.WinConsole.Model
{
    public class RedheadDuck : BaseDuck
    {
        public RedheadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hi there, I'm a Redhead Duck");
        }
    }
}