using System;

namespace dowhile_Statement
{
    class Program
    {
        public static void DoWhileTest(){
            int i = 1;
            do
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
            while (i <= 5);
        }
        static void Main(string[] args)
        {
            DoWhileTest();
        }
    }
}
