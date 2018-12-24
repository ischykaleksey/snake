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
            Point pnt1 = new Point();
            pnt1.x = 2;
            pnt1.y = 3;
            pnt1.symbol = '*';
            pnt1.Draw();

            Point pnt2 = new Point();
            pnt2.x = 4;
            pnt2.y = 5;
            pnt2.symbol = '#';
            pnt2.Draw();
            //int x2 = 4;
            //int y2 = 6;
            //char symbol2 = '#';
            //Draw(x2, y2, symbol2);

            Console.ReadLine();
        }
        
    }
}
