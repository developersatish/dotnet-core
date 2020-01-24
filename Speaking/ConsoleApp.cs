using System;
using static System.Console;

namespace core_playground
{
    public class ConsoleApp
    {
        public static void Entry(string[] args)
        {
            // dotnet run red yellow 50 50
            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);
            BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);
            WindowWidth = int.Parse(args[2]);
            WindowHeight = int.Parse(args[3]);

            WriteLine($"There are {args.Length} arguments.");
            foreach (var arg in args)
            {
                WriteLine(arg);
            }
            Console.WriteLine("Hello World!");
            
        }       
    }
}