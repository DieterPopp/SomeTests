using System;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test test = new Test();
            test.TestMethod();
        }
        
    }

    public class Test
    {
        public Test()
        {

        }

        public void TestMethod()
        {
            Console.WriteLine("Das ist ein Test!");
        }
    }
}
