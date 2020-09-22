using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x,y");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double otv = Math.Pow(3, -x) - Math.Cos(x) + Math.Sin(2 * x * y);
            Console.WriteLine("Ответ - " + Math.Round(otv, 3));
            Console.WriteLine("Введите a,b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double c = Math.Sqrt((a * a) + (b * b));
            double p = a + b + c;
            double s = (a * b) / 2;
            Console.WriteLine("Периметр = " + p);
            Console.WriteLine("Площадь = " + s);
            Console.ReadKey();
        }
    }
}
