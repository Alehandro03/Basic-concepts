using System;

namespace PrivedeniaTipov
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1
            //Посчитать сумму всех трех цифр трехзначного числа, заданного константой(const).
            //Вывести сумму на печать.
            //Например:735 = 15(7 + 3 + 5)          

            //Console.Write("Введите трехзначное число - ");

            // int a = Convert.ToInt32(Console.ReadLine());           

            //if(a>999)
            //{
            //    Console.WriteLine("Ошибка №" + a + ".  Число не является трехзначным");
            //    return;
            //}

            //if(a<100)  
            //{
            //    Console.WriteLine("Ошибка №" + a + ".  Число не является трехзначным");
            //     return;
            //}

            //else
            //{
            //    int a1 = a % 10;
            //    int a2 = (a / 10) % 10;
            //    int a3 = a / 100;

            //    int b = a1 + a2 + a3;

            //    Console.WriteLine(a + "=" + b + "(" + a1 + "+" + a2 + "+" + a3 + ")");
            //}


            //Задание 2
            // Ввести с клавиатуры координаты выстрела x1 и y1.
            // Записать в bool переменную логическое выражение, которое будет истинным(true) тогда и только тогда,
            // когда этот выстрел попадает в круглую мишень(точка лежит внутри круга радиусом R).
            // Вывести bool переменную на экран.
            //Формула круга: x ^ 2 + y ^ 2 = R ^ 2.
            //Следовательно, условие нахождения точки ВНУТРИ круга будет... (подумайте о знаке сравнения). 
            //Запись x^2 означает "икс в квадрате".

            //Console.WriteLine("Введите координаты выстрела x1 и y1");

            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());

            //const double R = 8;

            //bool hit = Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2);

            //Console.WriteLine(hit);



            //Задание 3
            //Пользователь вводить трехзначное число.
            //Записать логическое условие, которые будет истинным тогда и только тогда,
            //когда его средняя цифра меньше или равна(<=) первой(левой) и
            //одновременно строго больше(>) последней(правой).

            //Console.WriteLine("Введите трехзначное число");

            //int a = Convert.ToInt32(Console.ReadLine());

            //int a1 = a / 100;
            //int a2 = (a / 10) % 10;
            //int a3 = a % 10;

            //if (a > 999)
            //{
            //    Console.WriteLine("Ошибка №" + a + ".  Число не является трехзначным");              
            //}

            //else if (a < 100)
            //{
            //    Console.WriteLine("Ошибка №" + a + ".  Число не является трехзначным");             
            //}


            //if (a1 >= a2 && a2 > a3)
            //{
            //    Console.Write(a + "(true)");

            //}

            //else
            //{
            //    Console.Write(a + "(false)");
            //}

            //Задание 4
            //Ввести целое трехзначное число. Поменять местами его первую и последнюю цифры.
            //Собрать новое число в новой переменной!

            //Console.WriteLine("Введите трехзначное число");

            //int a = Convert.ToInt32(Console.ReadLine());

            //int a1 = a / 100;
            //int a2 = (a / 10) % 10;
            //int a3 = a % 10;

            //int a4 = a1;
            //a1 = a3;
            //a3 = a4;

            //int a5 = (a1 * 100) + (a2 * 10) + a3;

            //Console.Write("Ваше число " + a5);

            //Задание 5
            //Записать логическое условие, которое проверит, что в double числе нулевая дробная часть.

            //Console.Write("Введите число на проверку  ");
            //double d = Convert.ToDouble(Console.ReadLine());

            //int a = (int)d;

            //if (d == a)
            //{
            //    Console.Write(d + " (true)");
            //}

            //else
            //{
            //    Console.Write(d + " (false)");
            //}










        }
    }
}
