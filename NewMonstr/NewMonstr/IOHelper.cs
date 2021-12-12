using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMonstr
{
    class IOHelper
    {

        public static void Line(int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write("_");
            }
            Console.Write("\n");
        }
        public static int Resolve(double a, double b, double c, ref double x1, ref double x2)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d < 0) return 0;

            if (b == 0)
            {
                x1 = -b / (2 * a);
                return 1;
            }

            else
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                return 2;
            }
        }
        public static int ArgByRef(ref int a)
        {
            return 30;
        }
        public static void PrintResult(int value)
        {
            Console.WriteLine(value);
        }
        public static void PrintResult(double value)
        {
            Console.WriteLine(value);
        }
        public static void PrintResult(string value)
        {
            Console.Write(value);
        }
        public static void PrintResult(bool value)
        {
            Console.WriteLine(value);
        }

        public static void PrintResult(int[] value)
        {
            Console.WriteLine(value);
        }
        public static void PrintResult(int[,] value)
        {
            Console.WriteLine(value);
        }
        public static void PrintResult(Type value)
        {
            Console.WriteLine(value);
        }

        public static void PrintMonstr(Inventory value)
        {
            Console.WriteLine($" Инвентарь:");
            for (int i = 0; i < value.Count; i++)
            {
                Console.WriteLine($"  Наименование:{value[i].Name}. Вес:{value[i].White}. Цена:{value[i].Cost}\n");
            }
        }
    }
}
