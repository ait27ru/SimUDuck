using System;

namespace SimUDuck.WinConsole.Model
{
    public abstract class BaseDuck
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }

        public abstract void Display();
    }
}