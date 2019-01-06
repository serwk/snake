using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(2, 4, '+');
            Point p4 = new Point(5, 1, '/');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            List<char> cList = new List<char>();
            cList.Add('*');
            cList.Add('|');
            cList.Add('+');
            cList.Add('=');

            Console.ReadLine();
        }

    }
}
