using System;
using System.Linq;
using System.Reflection;

namespace core_playground
{
    public class ReadAssemblies
    {
        public static void Entry()
        {
            // loop through the assemblies that this application references
            foreach (var r in Assembly.GetEntryAssembly()
              .GetReferencedAssemblies())
            {
                // load the assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));
                // declare a variable to count the total number of methods
                int methodCount = 0;
                // loop through all the types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    // add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }
                // output the count of types and their methods
                Console.WriteLine($"{a.DefinedTypes.Count():N0} types " +
                 $"with {methodCount:N0} methods in {r.Name} assembly.");
            }

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range { int.MinValue:N0} to { int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range { double.MinValue:N0} to { double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range { decimal.MinValue:N0} \b to { decimal.MaxValue:N0}.");
        }
    }
}
