using System;
using System.Collections.Generic;

namespace A3Q1
{
    class Program
    {
        //Make Lists
        static List<string> Falconer = new List<string> { "Debbie", "Heidi", "Noel", "Melissa", "Kirsten", "Koshy" };
        static List<string> Falcons = new List<string> { "Hisan", "Ka Kite", "Siren", "Koa", "Stella", "Mojo" };
        static void Main(string[] args)
        //Clears console / Prints string to screen 
        {
            Console.Clear();

            Console.WriteLine(Display());
        }
        static int GenerateRandomNumber(List<string> List)
        {
            var rnd = new Random();
            //Makes random number as long as list
            return rnd.Next(1, List.Count);
        }
        //Creates variables to display
        static string Display()
        {
            var selectFalconer = Falconer[GenerateRandomNumber(Falconer)];
            var selectFalcons = Falcons[GenerateRandomNumber(Falcons)];
            //Returns answer
            return $"Falconer: {selectFalconer} with Falcon: {selectFalcons}";
        }
    }
}
