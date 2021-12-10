using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            // Задание 1
            // Пользователь вводит одно число (A).
            // Вывести все числа от 1 до 1000, которые делятся на A.

            //Console.Write("Введите число: ");

            //int a = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 1000; i++)
            //{

            //    if (i % a == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //Задание 2 
            //Пользователь вводит одно число (A).
            //Найдите количество положительных целых чисел, квадрат которых меньше A.

            //Console.WriteLine("Введите число: ");
            //int a = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int num = 0;
            //for (int i = 1; Math.Pow(i, 2) < a; i++)
            //{
            //    num++;
            //    sum = num;
            //}
            //Console.Write(sum);

            //Задание 3
            //Пользователь вводит одно число (A).
            //Вывести наибольший делитель (кроме самого A) числа A.

            //Console.WriteLine("Введите число: ");
            //int a = int.Parse(Console.ReadLine());

            //for (int i = 2; i < a; i++)
            //{

            //    if (a % i == 0)
            //    {
            //        int b = a / i;
            //        if (b != a)
            //        {
            //            Console.WriteLine($"Наибольший делитель чисо - {b}");
            //            break;
            //        }

            //    }


            //}

            //Задание 4
            //Пользователь вводит два числа (A и B).
            //Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
            //(Учтите, что при вводе B может оказаться меньше A).

            //Console.WriteLine("Введите число:А ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число:Б ");
            //int b = int.Parse(Console.ReadLine());

            //if(a > b)
            //{
            //    int tmp = a;
            //    a = b;
            //    b = tmp;
            //}

            //    int c = 0;
            //    for (int i = a; i <= b; i++)
            //    {

            //        if (i % 7 == 0)
            //        {
            //            c = i + c;


            //        }

            //    }
            //    Console.WriteLine($"Сумма чисел в диапозоне от А до Б - {c}");


            //Задание 5
            //Пользователь вводит два числа.
            //Найти их наибольший общий делитель используя алгоритм Евклида.

            //Console.WriteLine("Введите число:А ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число:Б ");
            //int b = int.Parse(Console.ReadLine());

            //while (a != 0 && b != 0)
            //{
            //    if (a > b)
            //    {
            //        a = a % b;
            //    }
            //    else
            //    {
            //        b = b % a;
            //    }

            //}
            //Console.Write("Наибольший общий делитель - " + (a + b));


            //Задание 6!!!!
            //Пользователь вводит целое положительное число, которое является кубом целого числа N.
            //Найдите число N методом половинного деления.

            //Console.WriteLine("Введите число: ");

            //int a = int.Parse(Console.ReadLine());
            //int left = 0;
            //int right = a;
            //int middle = -2;

            //while (left != right)
            //{
            //    middle = (left + right) / 2;
            //    if (Math.Pow(middle, 3) == a)
            //    {
            //        break;
            //    }
            //    else if (Math.Pow(middle, 3) > a)
            //    {
            //        right = middle;

            //    }
            //    else if(Math.Pow(middle, 3) < a)
            //    {
            //        left = middle;
            //    }


            //}

            //Console.WriteLine(middle);

            //Задание 7
            // Пользователь вводит одно число произвольной длины (5-8 цифр).
            // Найти количество нечетных цифр этого числа.

            //Console.Write("Введите проверяемое число : ");
            //int num = int.Parse(Console.ReadLine());
            //int numProverka, kolNeChetnih = 0, num1;
            //num1 = num;
            //while (true)
            //{

            //    numProverka = num % 10;
            //    num /= 10;
            //    if (numProverka % 2 != 0)
            //    {
            //        kolNeChetnih++;
            //    }
            //    if(num == 0)
            //    {
            //          break;
            //    }
            //}
            //Console.WriteLine($"Количество не четных цифр в числе {num1} равно { kolNeChetnih} ");

            //Задание 8
            //Пользователь вводит одно число.
            //Найти число, которое является зеркальным отображением последовательности цифр заданного числа,
            //например, задано число 123, вывести 321. Просьба массивами и строками не пользоваться.

            //Console.Write("Введите проверяемое число : ");
            //int num = int.Parse(Console.ReadLine());

            //int L = num.ToString().Length;
            //int i = 0;
            //int a = 0;
            //while (num  >  0)
            //{
            //    a += (num % 10) * (int)Math.Pow(10, L - i - 1 );
            //    i++;
            //    num /= 10;                               
            //}
            //Console.WriteLine(a);

            //Задание 9

            //Пользователь вводит целое положительное  число (N).
            //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.

            Console.Write("Введите проверяемое число N : ");
            int num = int.Parse(Console.ReadLine());
            int sum_even = 0;
            int sum_odd = 0;
            for (int i = 1; i <= num; i++)
            {
                int copy = i;
                while (copy > 0)
                {
                    int d = copy % 10;
                    if (d % 2 == 0) sum_even += d;

                    else sum_odd += d;

                    copy /= 10;

                }

                if (sum_even > sum_odd)
                {
                    Console.WriteLine(i);
                }


            }



            //Задание 10
            //Пользователь вводит два числа.
            //Сообщите, есть ли в написании двух чисел одинаковые цифры.
            //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.

            //    Console.WriteLine("Введите число:А ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите число:Б ");
            //int b = int.Parse(Console.ReadLine());

            //int aL = a.ToString().Length;
            //int bL = b.ToString().Length;
            //int b1 = b;
            //for (int i = 1; i <= aL; i++)
            //{
            //    b = b1;
            //    int sum_a = a % 10 * (int)Math.Pow(10,0);
            //    for (int j = 1; j <= bL; j++)
            //    {
            //        int sum_b = b % 10 * (int)Math.Pow(10, 0);
            //        if (sum_a == sum_b)
            //        {
            //            Console.WriteLine("Да");
            //            return;
            //        }

            //        b = b / 10 * (int)Math.Pow(10, 0);
            //    }
            //    a = a / 10 * (int)Math.Pow(10, 0);

            //}

            //Console.WriteLine("Нет");



        }


    }
}
