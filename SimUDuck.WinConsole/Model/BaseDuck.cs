using System;
using SimUDuck.WinConsole.Interface;

namespace SimUDuck.WinConsole.Model
{
    public abstract class BaseDuck
    {
        protected IFlyable FlyBehavior;
        protected IQuackable QuackBehavior;

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Swim");
        }

        public abstract void Display();
    }
}