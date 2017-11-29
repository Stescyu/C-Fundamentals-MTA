using System;

namespace foreach_Statement
{
    class Program
    {
        private static void forEachTest(){
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int i in numbers){
                Console.WriteLine("The value of i = {0}", i);
            }
        }
        static void Main(string[] args)
        {
            forEachTest();
        }
    }
}
