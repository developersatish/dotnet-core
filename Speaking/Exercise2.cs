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
            WriteLine($"size of sbyte: {sizeof(sbyte)} min size: {sbyte.MinValue} Max Size: {sbyte.MaxValue}");
        }
    }
}