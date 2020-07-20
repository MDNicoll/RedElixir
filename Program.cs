using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace RedElixir
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------
            // Basic console settings for the program
            Console.Title = "RedElixir - v1.0.0";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetWindowSize(81,30);
            Console.SetBufferSize(81, 30);
            Console.CursorVisible = false;

            //---------------------------------------
            // Run the game!
            Run();
        }

        private static void Run()
        {
            //---------------------------------------
            // Run Class variables
            string State = "";

            //---------------------------------------
            // Display the initial title screen
            Screens.WriteTitle();

            while (Console.ReadKey(true).Key != ConsoleKey.Q)
            {
                switch (State)
                {
                    case "NewGame":
                        Screens.WriteNewGame();
                        break;

                    default:
                        Screens.WriteTitle();

                        State = Console.ReadKey(true).Key == ConsoleKey.S ? "NewGame" : ""; 
                        break;

                }
            }
        }
    }
}