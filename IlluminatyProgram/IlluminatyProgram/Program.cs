using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlluminatyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String version = "v 1.0 "; // Version
            Console.WriteLine("This program was code by:Boux " +version);

            // All Strings will be declared there
            Password:
            String Password = "13"; // My 1337 Pass
            String cin = Console.ReadLine(); // Info collector line
            String q = "quit";
            String Anime = "Anime";
            String Cal = "Calculator";
            String Full = "Fullmetalalchemist";



            if (cin == Password)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login Sucsess !!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1337 / Configs Loaded!!!");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("God mode on !!!");
                Console.ResetColor();
                goto Program;
            }
            if(cin == q)
            {
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Acces Denied");
                Console.ResetColor();
                goto Password;
            }

        Program:

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("///////////////////////////////////////////////////");
            Console.WriteLine("Chose the program ");
            Console.WriteLine("///////////////////////////////////////////////////");
            Console.ReadLine();

            if(cin == Anime)
            {
                Console.WriteLine("ANIME PORN LOADED !!!");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Chose between Season");
                Console.ResetColor();

                Console.WriteLine("Assasination class room");

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fullmetal alchemist");
                Console.ResetColor();

                if (cin == Full)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Check for code correction ");
                    Console.ResetColor();
                }


            }


            

            Console.ReadKey();
        }
    }
}
