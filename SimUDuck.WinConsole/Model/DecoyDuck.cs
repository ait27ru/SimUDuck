using System;
using SimUDuck.WinConsole.Behavior;

namespace SimUDuck.WinConsole.Model
{
    public class DecoyDuck : BaseDuck
    {
        public DecoyDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hey, I'm a Decoy Duck");
        }
    }
}