using System;

namespace SimUDuck.WinConsole.Model
{
    public class DecoyDuck : BaseDuck
    {
        public override void Display()
        {
            Console.WriteLine("Hey, I'm a Decoy Duck");
        }
    }
}