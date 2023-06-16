using System;
/* 
namespace MultipleInterface
{
    // example of extension method
    // only difference with extension vs static is In Extension we need to pass the first parameter with this keyword
    //Extension method allow you to inject additional methods without modifying, deriving or recompiling the original class, struct or interface
    public static class Test1
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }

    public static class Test2
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;
            //bool result = i.IsGreaterThan(100);

            //int sumresult = Test2.Sum(1,2);
            //Console.WriteLine(result);
            //Console.WriteLine(sumresult);

            Check ch = new Check(4,5);
            ch.MethodCheck();
            Console.ReadLine();
        }
    }
} */

delegate void Procedure();

class DelegateDemo
{
    public static void method1()
    {
        Console.WriteLine("Method1 called");
    }
    public static void method2()
    {
        Console.WriteLine("Method2 called");
    }
    public void method3()
    {
        Console.WriteLine("method3 called");
    }

    static void Main()
    {
        Procedure proc = null;
        proc += new Procedure(DelegateDemo.method1);
        Console.WriteLine("After call method1");
        proc += new Procedure(method2);
        Console.WriteLine("After call method2");
        DelegateDemo de = new DelegateDemo();
        proc += new Procedure(de.method3);
        Console.WriteLine("After call method3");
        proc();
        Console.WriteLine("After call delegate proc");
        Console.ReadLine();
    }
}