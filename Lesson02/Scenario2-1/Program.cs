using System;

namespace Scenario2_1
{
    class Product
    {
        public string Name
        {

            get
            {
                return Name;
            }
            set
            {
                try
                {
                    if(Name == null || Name == ""){
                        throw new Exception("String cannot be null");
                }   
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Name = null;
            Console.WriteLine(p.Name);
        }
    }
}
