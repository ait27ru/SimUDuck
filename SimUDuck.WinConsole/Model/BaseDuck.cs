namespace SimUDuck.WinConsole.Model
{
    public abstract class BaseDuck
    {
        public string Quack()
        {
            return "Quack";
        }

        public string Swim()
        {
            return "Swim";
        }

        public abstract void Display();
    }
}