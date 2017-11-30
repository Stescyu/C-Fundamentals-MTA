using System;

namespace Rectangle
{
    class Rectangle
    {
        private double length;
        private double width;
        public double Length {
            get {
                return length;
            }
            set {
                if (value > 0.0)
                    length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0.0)
                {
                    width = value;
                }
            }
        }
        public double GetArea(){
            return length * width;
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.length = 10.0;
            rect.width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle: {0}", area);
        }
    }
}