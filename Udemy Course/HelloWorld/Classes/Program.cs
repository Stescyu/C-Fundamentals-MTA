using System;

namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is {0} {1}", FirstName, LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person();
            John.FirstName = "John";
            John.LastName = "Smith";
            John.Introduce();
        }
    }
}
