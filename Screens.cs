using System;
using System.Collections.Generic;
using System.Text;

namespace RedElixir
{
    class Screens
    {
        public static void WriteTitle()
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

        public static void WriteNewGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine(@" ================================================================================");
            Console.Write(@" =                              "); 
            Console.ForegroundColor = ConsoleColor.White; 
            Console.Write("CHARACTER CREATION");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("                              =");
            
            Console.WriteLine(@" ================================================================================");
            Console.WriteLine(@" =   NAME:                             == LVL: [----------------?-------------] =");
            Console.WriteLine(@" = GENDER:                             ==  HP: [----------------?-------------] =");
            Console.WriteLine(@" =   RACE:                             ==  MP: [----------------?-------------] =");
            Console.WriteLine(@" =  CLASS:                             ==  FP: [----------------?-------------] =");
            Console.WriteLine(@" =  FAITH:                             ==  STR:    | INT:    | CON:    |=========");
            Console.WriteLine(@" =    AGE:                             ==  DEX:    | FAI:    | LCK:    |=========");
            Console.WriteLine(@" ================================================================================");
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
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" =                                                                              =");
            Console.WriteLine(@" ================================================================================");
        }

        public static void WriteProgressBar(int Stat)
        {
            //---------------------------------------
            // Calculate the number of - before and after the stat
            string sStat = Stat.ToString();
            int sStatLen = sStat.Length;

            //---------------------------------------
            // What this function will output 
            // [----------------?-------------] (30 Char long between [])
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@"[");

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@"]");
        }
    }
}
