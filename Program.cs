namespace Dot_Selector
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region User

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
            
            MainLoop(new string[] { "Yokoso", "Kira kira","Doki doki", "Mochi mochi" },
                                   funcs);

            #endregion



            #region Selector

            void MainLoop(string[] Options, Func<bool>[] hola)
            {
                ConsoleKey key;
                int counter = 0;
                Console.CursorVisible = false;

                Rendering(counter, Options);
                while (true)
                {
                    key = Console.ReadKey().Key;
                    if (key == ConsoleKey.UpArrow)
                    {
                        Rendering(counter = counter > 0 ? counter - 1 : 0, Options);
                    }
                    else if (key == ConsoleKey.DownArrow)
                    {
                        counter = counter < Options.Length - 2 ? counter + 1 : Options.Length - 1;
                        Rendering(counter, Options);
                    }
                    else if (key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        hola[counter]();
                        Task.Delay(500).Wait();
                        Rendering(counter, Options);
                    }
                }

            }

            void Rendering(int counter_render, string[] Options_Render)
            {
                Console.Clear();
                for (int i = 0; i < Options_Render.Length; i++)
                {
                    if (i == counter_render)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"-> {Options_Render[i]}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"* {Options_Render[i]}");
                    }
                }

            }


            #endregion

        }

        



    }
}