/*Create a console application project named Exercise02 that outputs the number of bytes in memory that each of the following number types use and the minimum and maximum possible values they can have: 
sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.*/

// https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting?redirectedfrom=MSDN
using System;
using static System.Console;

namespace core_playground
{

    public class Exercise02
    {

        public static void Entry()
        {
            //  FormatString();
            BreakLine();
            WriteLine("{0,-15} {1,-5} {2,30} {3,30}", "Type", "Bytes of memory", "Min", "Max");
            BreakLine();
            PrintFormat("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            PrintFormat("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            PrintFormat("byte", sizeof(short), short.MinValue, short.MaxValue);

            PrintFormat("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            PrintFormat("int", sizeof(int), int.MinValue, int.MaxValue);
            PrintFormat("uint", sizeof(uint), uint.MinValue, uint.MaxValue);

            PrintFormat("long", sizeof(long), long.MinValue, long.MaxValue);
            PrintFormat("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            PrintFormat("float", sizeof(float), float.MinValue, float.MaxValue);


            PrintFormat("double", sizeof(double), double.MinValue, double.MaxValue);
            PrintFormat("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            BreakLine();
        }

        static void BreakLine()
        {
            WriteLine("------------------------------------------------------------------------------------------------------------");

        }
        static void PrintFormat(string name, dynamic size, dynamic min, dynamic max)
        {
            WriteLine("{0,-15} {1,-15} {2,30} {3,30}", name, size, min, max);
        }
        static void FormatString()
        {
            string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
                         "Ebenezer", "Francine", "George" };
            decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80,
                                 16.75m };

            WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
            for (int ctr = 0; ctr < names.Length; ctr++)
                WriteLine("{0,-15} {1,5:N1}", names[ctr], hours[ctr]);
        }
    }
}