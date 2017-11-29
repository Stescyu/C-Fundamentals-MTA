using System;

namespace Scenario1_1
{
    class Program
    {
        double price;
        public double Discount(int n){
            if(n < 10){
                return price * n * 0.95; //5% off
            } else if(n < 50){
                return price * n * 0.9; //10% off
            } else if(n < 100){
                return price * n * 0.85; //15% off
            } else {
                return price * n * 0.8; //20% off
            }
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.price = 3.99;
            double x = p.Discount(7);
            Console.WriteLine(x);

            Program bay = new Program();
            bay.price = 5.99;
            Console.WriteLine(bay.Discount(150));

            //The data do not interfere with each other using the same class
        }
    }
}
