using System;

namespace core_playground
{
    
    public class A
    {
        public A()
        {
            Console.WriteLine("A constructor");
        }

        static A()
        {
            Console.WriteLine("Static A()");
        }

        public void Method()
        {
            Console.WriteLine("In A method");
        }
    }   
}