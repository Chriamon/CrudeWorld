using System;

namespace Crude_World
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Game1 game = new Game1())
            {
                //COREY ADDED THIWS COMMENT
                game.Run();
            }
        }
    }
#endif
}

