using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            int count = 10;
            float totalPrice = 20.95f; //f is used at the end to declare float
            char character = 'A'; //char uses single quote
            string firstName = "Steven"; //string uses double quote
            bool networking = true;
            const float Pi = 3.14f; //const is so you cannot change the value that is a constant

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(networking);
            Console.WriteLine("{0}, {1}", number, networking);
        }
    }
}
