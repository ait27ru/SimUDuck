using System;
using SimUDuck.WinConsole.Interface;

namespace SimUDuck.WinConsole.Behavior
{
    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings");
        }
    }
}