using System;
using SimUDuck.WinConsole.Interface;

namespace SimUDuck.WinConsole.Behavior
{
    public class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly no way");
        }
    }
}