using System;

namespace Peremennie
{
    class Program
    {
        static void Main(string[] args)
        {
           // Задание 1
           // Выведите на консоль значение двух инициализированных переменных a(int) и b(double)
           // (любые значения) и текст в следующем виде:
           // привет, < a > !
           // < a > + < b > = < a + b >
           // пока, < b > ...
           // Обратите внимание!Треугольные скобки означают иносказательность.
           //Т.е.нужно вывести не текст с треугольными скобками, а значение переменной или их суммы.
           // Многоточие в конце - это текст(три символа точки).

           // int a = 3;
           // int b = 4;
           // Console.WriteLine("Привет, " + a + '!');

           // int y = a + b;
           // Console.WriteLine(a + " + " + b + " = " + y);

           // Console.Write("пока, " + b + "...");

           // Задание 2
           // Пользователь вводит два числа(a и b). Выведите в консоль решение(5 * a + b ^ 4) / (b - a)
           // Примечание: "b^4" означает "b в степени 4"

           // Console.Write("Введите число a ");
           // double a = Convert.ToDouble(Console.ReadLine());

           // Console.Write("Введите число b ");
           // double b = Convert.ToDouble(Console.ReadLine());

           // double d = (5 * a + Math.Pow(b, 4)) / (b - a);

           // Console.Write("Ваш ответ (5 * a + b ^ 4) / (b - a) =  " + d);


           // Задание 3
           //  Пользователь вводит два строковых(string) значения(s1 и s2).Поменяйте содержимое
           //  переменных s1 и s2 местами.
           //  Подсказка: воспользуйтесь третьей переменной для временного сохранения значения одной
           //  из двух переменных.

           // Console.Write("Введите число 1 -  ");
           // string s1 = Console.ReadLine();
           // Console.Write("Введите число 2 - ");
           // string s2 = Console.ReadLine();
           // string s3 = s2;
           // s2 = s1;
           // s1 = s3;
           // Console.Write("Ваш ответ- ");
           // Console.Write(s1);
           // Console.Write(s2);

           // Задание 4
           // Пользователь вводит три не равных нулю числа(a, b и c).
           // Выведите в консоль решение(значение X) линейного уравнения стандартного вида a* X+b = c.

           // Console.WriteLine("Введите число a, b, c -  ");

           // int a = Convert.ToInt32(Console.ReadLine());
           // int b = Convert.ToInt32(Console.ReadLine());
           // int c = Convert.ToInt32(Console.ReadLine());

           // double x = (b - c) / a;
           // Console.Write("Ваш ответ = " + x);


           // Задание по *2
           // Решить квадратное уравнение вида ax ^ 2 + bx + c = 0.
           // С клавиатуры вводятся коэффициенты a, b и с.Нужно найти x1 и x2.
           // Для проверки подобрать коэффициенты так, чтобы дискриминант получился положительным.
           // Формула дискриминанта: D = b ^ 2 - 4 * a * c,
           // корни: x1 = (-b + корень(D)) / 2 * a, x2 = (-b - корень(D)) / 2 * a.
           // Для вычисления корня используйте Math.Sqrt(...).
           // Если запись условия текстом не понятна,
           // то формулы для расчета корней квадратных уравнений очень легко найти в интернете

           // Console.WriteLine("Введите число a, b, c -  ");

           // int a = Convert.ToInt32(Console.ReadLine());
           // int b = Convert.ToInt32(Console.ReadLine());
           // int c = Convert.ToInt32(Console.ReadLine());

           // double d = Math.Pow(b,2) - 4 * a * c;

           // double x1;
           // double x2;
           // if (d > 0)
           // {
           //     x1 = (-b + Math.Sqrt(d)) / (2 * a);
           //     x2 = (-b - Math.Sqrt(d)) / (2 * a);
           //     Console.Write("Ваш ответ ");
           //     Console.Write("x1 = " + x1);
           //     Console.Write("  x2 = " + x2);
           // }


           // if (d < 0)
           // {
           //     Console.Write("Корней нет ");
           // }

           // if (d == 0)
           // {
           //     int x3 = -b / (2 * a);
           //     Console.Write("Ваш ответ ");
           //     Console.Write("x  = " + x3);
           // }




        }





    }
}
