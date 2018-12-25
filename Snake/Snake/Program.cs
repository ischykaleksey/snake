using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pnt1 = new Point(2,3,'*');
            //pnt1.x = 2;
            //pnt1.y = 3;
            //pnt1.symbol = '*';
            pnt1.Draw();

            Point pnt2 = new Point(4,5,'#');
            //pnt2.x = 4;
            //pnt2.y = 5;
            //pnt2.symbol = '#';
            pnt2.Draw();

            Console.ReadLine();
        }
       
    }
}
