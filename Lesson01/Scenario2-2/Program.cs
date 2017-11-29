using System;

namespace Scenario2_2
{
    class Program
    {
        public static int Factorial(int n)
        {
            if(n > 1){
                return n * Factorial(n - 1); 
            } else {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
    }
}
