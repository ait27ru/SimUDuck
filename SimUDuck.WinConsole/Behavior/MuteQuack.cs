using System;
using SimUDuck.WinConsole.Interface;

namespace SimUDuck.WinConsole.Behavior
{
    public class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("[[Silence]]");
        }
    }
}