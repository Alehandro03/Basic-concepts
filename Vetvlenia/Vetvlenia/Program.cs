using System;

namespace Vetvlenia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White; // устанавливаем белый цвет фона для текста
            Console.ForegroundColor = ConsoleColor.Green;// устанавливаем зеленый цвет шрифта

            //Задача 1
            //Пользователь вводит два числа(A и B).
            //Если A > B, подсчитать A+B, если A == B, подсчитать A*B, если A<B, подсчитать A-B.
            //Сделать лесенкой из двух if'ов.

            //Console.WriteLine("Введите число А и B");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //if(a>b)
            //{
            //    int d = a + b;
            //    Console.WriteLine(d);
            //}
            //else if( a == b)
            //{
            //    int d = a * b;
            //    Console.WriteLine(d);
            //}
            //else
            //{
            //    int d = a - b;
            //    Console.WriteLine(d);
            //}


            //Задание 2

            //Пользователь вводит два числа(X и Y).
            //Определить какой четверти координатной плоскости принадлежит точка с координатами(X, Y).

            //Console.WriteLine("Введите число X и Y");

            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());

            //if( x > 0 && y > 0 )
            //{
            //    Console.WriteLine("Точка принадлежит первой четверти");
            //}
            //else if( x > 0 && y < 0 )
            //{
            //    Console.WriteLine("Точка принадлежит второй четверти");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("Точка принадлежит третей четверти");
            //}
            //else if ( x < 0 && y > 0 )
            //{
            //    Console.WriteLine("Точка принадлежит четвертой четверти");
            //}
            //else
            //{
            //    Console.WriteLine("Координаты точек равны нулю");
            //}

            //Задание 3
            //Пользователь вводит три числа (A, B и С).
            //Выведите их в консоль в порядке возрастания.
            //Можно использовать сложное условное выражение, но можно и if'ами.

            //Console.WriteLine("Введите числа А, В, С");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //if(a>b&& b>c)
            //{
            //    Console.WriteLine($"Ответ {c} > {b} > {a}");
            //}
            //else if (a>b&& b<c)
            //{
            //    Console.WriteLine($"Ответ {b} > {c} > {a}");
            //}
            //else if(a<b&&a<c)
            //{
            //    Console.WriteLine($"Ответ {a} > {c} > {b}");
            //}
            //else if (c>b&&b>a)
            //{
            //    Console.WriteLine($"Ответ {a} > {b} > {c}");
            //}
            //else if(b>a&&a>c)
            //{
            //    Console.WriteLine($"Ответ {c} > {a} > {b}");
            //}
            //else if(c>a&& a>b)
            //{
            //    Console.WriteLine($"Ответ {b} > {a} > {c}");
            //}
            //else
            //{
            //    Console.WriteLine("Введено не верное значение!");
            //}

            //Задание 4 
            // Пользователь вводит три числа (A, B и С).
            // Выведите в консоль решение (значения X) квадратного уравнения стандартного вида, где AX^2+BX+C=0.
            //На этот раз обработать все три случая: корней нет, один корень(и его значение), два корня(и два значения).
            //Для переменных корней использовать
            //переменные с локальной областью видимости в ветке самого if (чтобы не плодить лишние переменные заранее).
            //То есть, если корней нет -
            //вообще переменная не нужна, если один корень - одна переменная, если два -две.

            //Console.WriteLine("Введите числа А, В, С");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());

            //double d = Math.Pow(b,2) - (4 * a * c) ;

            //if (d > 0)
            //{
            //    double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
            //    double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
            //    Console.WriteLine($"Ответ x1 = {x1} , x2 = {x2}");
            //}

            //else if (  d == 0 )
            //{
            //    double x = -b / 2 * a;
            //    Console.WriteLine($"Ответ x = {x} ");
            //}
            //else 
            //{
            //    Console.WriteLine($"Ответ корней нет");
            //}

            //Задание 5 
            //Пользователь вводит двузначное число.
            //Выведите в консоль прописную запись этого числа.
            //Например при вводе “25” в консоль будет выведено “двадцать пять”.
            //Примечание.Здесь, пожалуй, удобно использовать switch-case,
            //но можно и if-ами.Да, потребуется много веткой с соответствующими словами ))
            //Но их будет не 89(10 - 99) :)
            //Подумайте, как можно сделать поменьше. Анализируйте соответствующие цифры и выводите соответствующий текст.

            //Console.WriteLine("Введите числа двухзначное число");
            //int a = Convert.ToInt32(Console.ReadLine());


            //if (a >= 10 && a < 20)
            //{
            //    switch (a)
            //    {
            //        case 10: Console.WriteLine("Десять"); break;
            //        case 11: Console.WriteLine("Одиннадцать"); break;
            //        case 12: Console.WriteLine("Двенадцать"); break;
            //        case 13: Console.WriteLine("Тринадцать"); break;
            //        case 14: Console.WriteLine("Четырнадцать"); break;
            //        case 15: Console.WriteLine("Пятнадцать"); break;
            //        case 16: Console.WriteLine("Шестнадцать"); break;
            //        case 17: Console.WriteLine("Семнадцать"); break;
            //        case 18: Console.WriteLine("Восемнадцать"); break;
            //        case 19: Console.WriteLine("Девятьнадцать"); break;
            //    }
            //}
            //else if(a>= 20 && a < 100)
            //{
            //    int b = (a / 10)*10;

            //    switch(b)
            //    {
            //        case 20: Console.Write("Двадцать "); break;
            //        case 30: Console.Write("Тридцать "); break;
            //        case 40: Console.Write("Сорок "); break;
            //        case 50: Console.Write("Пятьдесят "); break;
            //        case 60: Console.Write("Шестьдесят "); break;
            //        case 70: Console.Write("Семьдесят "); break;
            //        case 80: Console.Write("Вщсемьдесят "); break;
            //        case 90: Console.Write("Девяносто "); break;
            //    }

            //    int c = a % 10;

            //    switch(c)
            //    {
            //        case 1: Console.WriteLine("один"); break;
            //        case 2: Console.WriteLine("два"); break;
            //        case 3: Console.WriteLine("три"); break;
            //        case 4: Console.WriteLine("четыре"); break;
            //        case 5: Console.WriteLine("пять"); break;
            //        case 6: Console.WriteLine("шесть"); break;
            //        case 7: Console.WriteLine("семь"); break;
            //        case 8: Console.WriteLine("восемь"); break;
            //        case 9: Console.WriteLine("девять"); break;
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Число не двузначное");
            //}

            //Задание 6
            //Даны вещественные положительные числа a, b, c.
            //Выяснить, существует ли треугольник со сторонами a, b, c.

            //Console.WriteLine("Введите положительные числа сторон треугольника: a, b, c");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //if (a <= 0 || b <= 0 || c <=0)
            //{
            //    Console.WriteLine("Заданы не верные параметры");
            //}
            //else if (b < a + c && a < b + c && c < a + b)
            //{
            //    Console.WriteLine("Треугольник существует");
            //}
            //else
            //{
            //    Console.WriteLine("Треугольник не существует");
            //}

            // Задание под *2
            //Ввести с клавиатуры вещественное число R и две точки (координаты) x и y.
            //Определить, принадлежит ли точка с координатами [x; y] заштрихованной фигуре.

            //Console.WriteLine("Введите  число R и две точки (координаты) x и y.");
            //int R = Convert.ToInt32(Console.ReadLine());
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());

            //if(x >= R && x <= R * 2)
            //{
            //    Console.WriteLine(" Точка [x; y] принадлежит заштрихованной фигуре");
            //}
            //else if (y >= R && y <= R * 2)
            //{
            //    Console.WriteLine(" Точка [x; y] принадлежит заштрихованной фигуре");
            //} 
            //else if (x >= -2 * R && x <= 0)
            //{
            //    Console.WriteLine(" Точка [x; y] принадлежит заштрихованной фигуре");
            //}
            //else if (y >= -2 * R && y <= 0)
            //{
            //    Console.WriteLine(" Точка [x; y] принадлежит заштрихованной фигуре");
            //}
            //else
            //{
            //    Console.WriteLine(" Точка [x; y]  не принадлежит заштрихованной фигуре");
            //}







        }




    }
}

