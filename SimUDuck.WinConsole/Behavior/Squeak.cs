using System;
using SimUDuck.WinConsole.Interface;

namespace SimUDuck.WinConsole.Behavior
{
    public class Squeak : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}