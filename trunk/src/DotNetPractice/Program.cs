using System;
using System.Runtime.InteropServices;

namespace DotNetPractice
{
    interface IA
    {
        void Method2();
    }
    interface IA1 : IA
    {
        void Method3();
    }
    abstract class A
    {
        public abstract void Method();
    }
    abstract class A1 : A { }
    class A2 : A1, IA1
    {
        public override void Method()
        {
            Console.WriteLine(this);
            Console.WriteLine(this.GetType().BaseType);
        }


        public void Method3()
        {
            Console.WriteLine("This is the method from IA1");
        }

        public void Method2()
        {
            Console.WriteLine("This is the method from IA");
        }

    }

    class B
    {
        public virtual void Test() { Console.WriteLine("This is B"); }

        public void Test1(int a, string b) { }
        public void Test1(string b, int a) { }
    }
    class B1 : B
    {
        public override void Test() { Console.WriteLine("This is B1"); }
    }
    class Program
    {
        public static void TestByte()
        {
            Console.WriteLine("The min and max of byte are {0} and {1} respectively.", byte.MinValue, byte.MaxValue);
        }
        static void Main(string[] args)
        {
            //IA1 a = new A2();
            //a.Method2();
            //a.Method3();
            //(a as A1).Method();

            //TestByte();


            //B1 b = new B1();
            //b.Test();
            //((B)b).Test();

            //b.Test1(1, "a");
            // 11110000 128 + 64 + 32 + 16
            Console.WriteLine(1<<4 & 240);
            Pos s = new Pos();
            // Test the Chinese Chess Checkmate
            Console.WriteLine(Marshal.SizeOf(s));
            new ChineseChess().FindOutAllTheUnCheckmatedPos1();

            Console.Read();
        }
    }
}
