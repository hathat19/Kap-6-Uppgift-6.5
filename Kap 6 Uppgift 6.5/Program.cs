using System;
using System.Collections.Generic;
namespace Uppgift6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            //-------------------------------------------

            Console.WriteLine(Längst("er", "gegegeg"));
            Console.WriteLine(Längst("er;;\"", "hh,,,"));
            Console.WriteLine(Längst(232,523));
        }

        static string Längst(string s1, string s2)
        {
            if (s1.Length >= s2.Length) return s1;
            return s2;
        }

        static int Längst(int i1, int i2)
        {
            if (i1.ToString().Length >= i2.ToString().Length) return i1;
            return i2;
        }

    }
}
/*Skapa ett program som innehåller en metod som heter Längst. Metoden ska
returnera den längsta av de två strängar som metoden ska ha som parametrar.
Metoden ska överlagras så att den också kan användas för att returnera det längsta
av två heltal. Om båda argumenten är lika långa så ska metoden returnera det första
av dem.*/