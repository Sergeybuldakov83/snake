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
            Console.SetBufferSize(80, 25);

            // Отрисовка рамочки

            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine RightLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine LeftLine = new VerticalLine(0, 24, 78, '+');
            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            p.Draw();            

            Console.ReadLine();

        }

    }
}
