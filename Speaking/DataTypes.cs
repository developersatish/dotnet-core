using System;
using System.Linq;
using System.Reflection;

namespace core_playground
{
    public class DataTypes
    {
        public static void Entry()
        {

            // NumberSize();
            // CompareDouble();
            CompareDecimal();
        }

        static void NumberSize()
        {
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range { int.MinValue:N0} to { int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range { double.MinValue:N0} to { double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range { decimal.MinValue:N0} \b to { decimal.MaxValue:N0}.");

        }

        static void CompareDouble()
        {
            /*
            The double type is not guaranteed to be accurate. Only use double when accuracy, 
            especially when comparing two numbers, is not important; for example, when measuring a person's height.

            The problem with the preceding code is how the computer stores the number 0.1 
            or multiples of 0.1. To represent 0.1 in binary, the computer stores 1 in the 1/16 column,
             1 in the 1/128 column, 1 in the 1/1024 column, and so on. The number 0.1 in decimal 
             is 0.0001001001001 repeating forever:
             
            */
            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3"); //TRUE

            }

        }

        static void CompareDecimal()
        {
            decimal c = 0.1M; // M indicates a decimal literal value
            decimal d = 0.2M;
            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }

            Console.WriteLine($"{default(int)}"); // 0
            Console.WriteLine($"{default(bool)}"); // False
            Console.WriteLine($"{default(DateTime)}"); // 1/01/0001 00:00:00

            /*
            The decimal type is accurate because it stores the number as a 
            large integer and shifts the decimal point. For example, 0.1 is stored as 1, 
            with a note to shift the decimal point one 
            place to the left. 12.75 is stored as 1275, with a note to 
            shift the decimal point two places to the left.
            */

            /*You can use the var keyword to declare local variables. The compiler will infer the type from the literal value you assign after the assignment (=) operator.

A literal number without a decimal point is inferred as an int variable unless you add the L suffix, in which case, it infers a long variable. A literal number with a decimal point is inferred as double unless you add the M suffix, in which case, it infers a decimal variable, or the F suffix, in which case, it infers a float variable. Double quotes indicate a string variable, single quotes indicate a char variable, and the true and false values infer a bool type.*/
        }
    }
}
