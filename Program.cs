namespace Dot_Selector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DC_Menu dot_Selector = new();

            //User_Testing
            Func<bool> func = () =>
            {
                Console.WriteLine("Washoiii");
                return default;
            };
            Func<bool> funco = () =>
            {
                Console.WriteLine("No Wonder Stage");
                return default;
            };
            Func<bool>[] funcs = new Func<bool>[2];
            funcs[0] = func;
            funcs[1] = funco;
            ConsoleColor[] colors = new ConsoleColor[2] {ConsoleColor.White, ConsoleColor.DarkMagenta };
            dot_Selector.Dot_Menu(new string[] { "Yokoso", "Kira kira","Doki doki", "Mochi mochi" },
                                   funcs, colors);
        }




    }
}