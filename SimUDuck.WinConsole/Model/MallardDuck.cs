using System;
using SimUDuck.WinConsole.Interface;

namespace SimUDuck.WinConsole.Model
{
    public class MallardDuck : BaseDuck, IQuackable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public override void Display()
        {
            Console.WriteLine("Hi, I'm a Mallard Duck");
        }
    }
}