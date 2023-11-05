using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Selector
{
    class DC_Menu
    {

        #region Public_Methods

        public void Dot_Menu(string[] Options, Func<bool>[] Funcs, ConsoleColor[] Colors)
        {
            MainLoop(Options, Funcs, Colors);
        }


        public void Dot_Menu(string[] Options, Func<bool>[] Funcs)
        {
            MainLoop(Options, Funcs, new ConsoleColor[] { ConsoleColor.Blue, ConsoleColor.White });
        }

        #endregion



        #region Private_Methods

        void MainLoop(string[] Options, Func<bool>[] Option_Funcs, ConsoleColor[] CMD_Colors)
        {
            ConsoleKey key;
            int counter = 0;
            Console.CursorVisible = false;

            Rendering(counter, Options, CMD_Colors);
            while (true)
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow)
                {
                    Rendering(counter = counter > 0 ? counter - 1 : 0, Options, CMD_Colors);
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    counter = counter < Options.Length - 2 ? counter + 1 : Options.Length - 1;
                    Rendering(counter, Options, CMD_Colors);
                }
                else if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Option_Funcs[counter]();
                    Task.Delay(500).Wait();
                    Rendering(counter, Options, CMD_Colors);
                }
            }

        }


        void Rendering(int counter_render, string[] Options_Render, ConsoleColor[] CMD_Colors)
        {
            Console.Clear();
            for (int i = 0; i < Options_Render.Length; i++)
            {
                if (i == counter_render)
                {
                    Console.ForegroundColor = CMD_Colors[0];
                    Console.WriteLine($"-> {Options_Render[i]}");
                }
                else
                {
                    Console.ForegroundColor = CMD_Colors[1];
                    Console.WriteLine($"* {Options_Render[i]}");
                }
            }

        }

        #endregion
    }
}
