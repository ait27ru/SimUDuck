using System;
using SimUDuck.WinConsole.Interface;

namespace SimUDuck.WinConsole.Model
{
    public class RedheadDuck : BaseDuck, IQuackable, IFlyable
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
            Console.WriteLine("Hi there, I'm a Redhead Duck");
        }
    }
}