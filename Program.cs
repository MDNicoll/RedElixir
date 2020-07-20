using System;

namespace RedElixir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic setup & sizing for the console window
            Console.SetWindowSize(81,30);
            Console.SetBufferSize(81, 30);

            WriteTitle();
        }
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
        }
    }
}
