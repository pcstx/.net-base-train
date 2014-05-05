using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ValPoint vPoint;
            vPoint.x = 1;
            vPoint.y = 2;
            Console.WriteLine(vPoint.y);          

            ValPoint vPoint1 = new ValPoint();
            Console.WriteLine(vPoint1.x);

            Console.ReadLine();
        }
    }
    public struct ValPoint 
    {
        public int x;
        public int y;

        public ValPoint(int x,int y)
        {
            this.x = x;
            this.y = y;
        } 
    }

}
