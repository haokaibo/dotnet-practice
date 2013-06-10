using System;

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
            Console.WriteLine("=====Algrithm practices=====");

            //b.Test1(1, "a");
            Console.WriteLine("1: Chinese Chess Checkmate.");
            Console.WriteLine("2: CPUFrequencyAdapter.");
            Console.WriteLine("3: Prefix sorting.");
            Console.WriteLine("4: Array demo.");

            Console.WriteLine("Please input the number of the Test you want to try:");
            int testNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");
            switch (testNumber)
            {
                case 1:
                    // ** Test the Chinese Chess Checkmate
                    new ChineseChess().FindOutAllTheUnCheckmatedPos1(); break;
                case 2:
                    // ** Test the CPUFrequencyAdapter
                    // new CPUFrequencyAdapter().StaticAdjustFrequencyOfSingleCPU(2.66f);
                    // new CPUFrequencyAdapter().StaticAdjustFrequencyOfSingleCPU2(new TimeSpan(0, 0, 0, 0, 10), new TimeSpan(0, 0, 0, 0, 10));
                    // new CPUFrequencyAdapter().DynamicAdjustFrequencyOfSingleCPU(100, 10);
                    new CPUFrequencyAdapter().AdjustFrenquecyOfCPUToDrawSINCurve(); break;
                case 3:
                    // ** Test the prefix sorting
                    var prefixSorting = new PrefixSorting(new int[] { 3, 2, 1, 6, 5, 4, 9, 8, 7, 0 });
                    prefixSorting.Run();
                    prefixSorting.Output();
                    break;
                case 4:
                    // ** Test array demo
                    // Array-of-arrays (jagged array)
                    int arrayLength = 5;
                    int[][] scores = new int[arrayLength][];
                    Console.WriteLine("Created the array scores: int[{0}][]", arrayLength);
                    // Create the jagged array
                    for (int i = 0; i < scores.Length; i++)
                    {
                        scores[i] = new int[i + 3];
                        Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
                        for (int j = 0; j < scores[i].Length; j++)
                        {
                            scores[i][j] = i * j;
                            Console.WriteLine("scores[{0}][{1}] = {2}", i, j, scores[i][j]);
                        }
                    }
                    break;
                default:
                    Console.WriteLine(1 ^ 3);
                    break;
            }
            Console.Read();
        }

        private static void OutputArray(int[] arr)
        {
            Console.Write(arr + ": ");
            int arrLen = arr.Length;
            for (int i = 0; i < arrLen; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
