using System;
using SimUDuck.WinConsole.Interface;

namespace SimUDuck.WinConsole.Behavior
{
    public class NormalQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}