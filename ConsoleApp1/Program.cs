using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle1 = new Rectangle(3,4);
            //var calculate = new ComputeShapeMeasurement();

            rectangle1.Width = 6;
            rectangle1.Height = 7;
            Console.WriteLine($"Width of Rectangle is {rectangle1.Width}");
            Console.WriteLine($"Height of Rectangle is {rectangle1.Height}");

            Console.WriteLine($"Area of Rectangle is {rectangle1.CalcAreaOfRectangle()}");
            Console.WriteLine($"Perimeter of Rectangle is {rectangle1.CalcPerimeterOfRectangle()}");

            Console.ReadKey();
        }
        class Rectangle
        {
            private int _width;
            private int _height;

            public Rectangle(int width,int height)
            {
                _width = width;
                _height = height;
            }

            public int Width
            {
                get
                {
                    return _width;

                }
                set
                {
                    if (value > 0)
                        {
                        _width = value;
                        }
                }                

            }

            public int Height
            {
                get
                {
                    return _height;
                }
               
                set
                {
                    if(value > 0)
                    {
                        _width = value;
                    }
                }
            }

            /*
            public int GetWidth()
            {
                return Width;
            }

            public void SetWidth(int value)
            {
                if(value > 0 )
                Width = value;
            }
            */

            public int CalcAreaOfRectangle()
            {
                return Width * Height;
            }

            public int CalcPerimeterOfRectangle()
            {
                return 2 * (Width + Height);
            }

        }

          /* 
         class ComputeShapeMeasurement
        {
            public int CalcAreaOfRectangle(Rectangle rectangle)
            {
                return rectangle.Width * rectangle.Height;
            }

            public int CalcPerimeterOfRectangle(Rectangle rectangle)
            {
                return 2 * (rectangle.Width + rectangle.Height);
            }
        }

           */
        

       
    }
}
