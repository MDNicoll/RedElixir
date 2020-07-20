using System;
using System.ComponentModel.DataAnnotations;

namespace RedElixir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "RedElixir - v1.0.0";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetWindowSize(81,30);
            Console.SetBufferSize(81, 30);
            Console.CursorVisible = false;

            do
            {
                WriteTitle();
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Q);
        }

        //---------------------------------------------------------------------------------------------------------
        // Class WriteTitle() 
        // -Writes a simple title screen for the game start
        //
        //---------------------------------------------------------------------------------------------------------
        private static void WriteTitle()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@" ================================================================================");
            Console.WriteLine(@" =                      (                                                       ="); 
            Console.WriteLine(@" =                      )\ )     (        (                                     ="); 
            Console.WriteLine(@" =                     (()/(  (  )\ ) (   )\(     ) (  (                        ="); 
            Console.WriteLine(@" =                      /(_))))\(()/( )\ ((_)\ ( /( )\ )(                       ="); 
            Console.WriteLine(@" =                     (_)) /((_)((_)|(_) _((_))\()|(_|()\                      ="); 
            Console.WriteLine(@" =                     | _ (_))  _| || __| |(_|(_)\ (_)((_)                     ="); 
            Console.WriteLine(@" =                     |   / -_) _` || _|| || \ \ / | | '_|                     =");
            Console.WriteLine(@" =                     |_|_\___\__,_||___|_||_/_\_\ |_|_|                       =");
            Console.WriteLine(@" ================================================================================");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =  What would you like to do?                                                  =");
            Console.WriteLine(@" = (S)tart a new game                                                           =");
            Console.WriteLine(@" = (L)oad a saved game                                                          =");
            Console.WriteLine(@" = (Q)uit the game                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" ================================================================================");
        }

        //---------------------------------------------------------------------------------------------------------
        // Class NewGame() 
        // -Generates a new game save by: Creating a new XML file, filling that XML file with information for the 
        // in-game character.
        //---------------------------------------------------------------------------------------------------------
        private static void NewGame()
        {
            Console.Clear();
        }
    }
}