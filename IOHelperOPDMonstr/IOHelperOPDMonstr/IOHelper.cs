using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOHelperOPDMonstr
{
    class HelperArray
    {

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
    class Helper
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

        public static void PrintMonstr(Inventar value)
        {
            Console.WriteLine($" Инвентарь:");
            for (int i = 0; i < value.Count; i++)
            {
                Console.WriteLine($"  Наименование:{value[i].Name}. Вес:{value[i].White}. Цена:{value[i].Cost}\n");
            }
        }
        


    }
    class IOHelper
    {
        public static int SaveInput(int min, int max, string message)
        {
            int num =  min - 1;
            do
            {
                Console.Write($"{message} [{min}-{max}]: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < min || num > max);
            return num;
        }
        public static DateTime SaveInput(DateTime min, DateTime max, string message)
        {
            DateTime num ;
            do
            {
                Console.Write($"{message} [{min}-{max}]: ");
                num = Convert.ToDateTime(Console.ReadLine());
            } while (num < min || num > max);
            return num;
        }
        public static double SaveInput(double min, double max, string message)
        {
            double num;
            do
            {
                Console.Write($"{message} [{min}-{max}]: ");
                num = Convert.ToDouble(Console.ReadLine());
            } while (num < min || num > max);
            return num;
        }

        public static int[] GenerateArrayInt(int size, int min, int max)
        {
            int[] res = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = rnd.Next(min, max + 1);
            }
            return res;
        }
        public static double[] GenerateArrayDouble(int size, double min, double max)
        {
            double[] res = new double[size];
            Random rnd = new Random();
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = rnd.NextDouble() * (max - min) + min;
            }
            return res;
        }

        public static int[,] GenerateDoubleArrayInt(int size_a, int size_b, int min, int max)
        {
            int[,] mas = new int[size_b, size_a];


            Random rnd = new Random();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(min, max + 1);

                }
                return mas;
            }
            return mas;
        }
        public static double[,] GenerateDoubleArrayInt(int size_a, double size_b, double min, double max)
        {
            double[,] mas = new double[(int)size_b, (int)size_a];


            Random rnd = new Random();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.NextDouble() * (max - min) + min;

                }
                return mas;
            }
            return mas;

        }
        
    
    }
}
