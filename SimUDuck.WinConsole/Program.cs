using SimUDuck.WinConsole.Model;

namespace SimUDuck.WinConsole
{
    internal class Program
    {
        private static void Main()
        {
            var mallardDuck = new MallardDuck();
            mallardDuck.Display();

            var redheadDuck = new RedheadDuck();
            redheadDuck.Display();
        }
    }
}