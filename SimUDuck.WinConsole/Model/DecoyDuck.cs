using System;

namespace SimUDuck.WinConsole.Model
{
    public class DecoyDuck : BaseDuck
    {
        public override void Display()
        {
            Console.WriteLine("Hey, I'm a Decoy Duck");
        }

        public new void Quack()
        {
            // Decoy ducks don's quack, so it is overriden to do nothing
        }

        public new void Fly()
        {
            // Decoy ducks don't fly, so it is overriden to do nothing
        }
    }
}