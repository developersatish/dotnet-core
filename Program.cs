using System;

namespace core_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class A {
        public A()
        {
            Console.WriteLine("A constructor");
        }

        static A(){
            Console.WriteLine("Static A()");
        }

        public void Method(){
            Console.WriteLine("In A method");
        }
    }

    public class B:A {

        public B()
        {
            Console.WriteLine("Contractor B");
        }

        static B(){
            Console.WriteLine("B static");
        }
    }
}
