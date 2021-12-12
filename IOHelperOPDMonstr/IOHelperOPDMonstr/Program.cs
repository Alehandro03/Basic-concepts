using System;

namespace IOHelperOPDMonstr
{

    class Program
    {
        static void Main(string[] args)
        {
            //Helper.PrintResult("Пример заполнения:");
            //var passport = (Seria: 1112, Number: 902614, DateTime: 2014, 04, 03);

            //Console.WriteLine(passport);



            //Passport ps1 = new Passport();

            //Passport ps2 = new Passport();



            //Helper.PrintResult("Введите серию: ");
            //int serial = (ps1._Serial = int.Parse(Console.ReadLine()));

            //Helper.Line(30);

            //Helper.PrintResult("Введите номер: ");
            //int number = (ps1._Number = int.Parse(Console.ReadLine()));
            //Helper.Line(30);

            //Helper.PrintResult("Ф.И.О: ");
            //string fio = (ps1.FIO = Convert.ToString(Console.ReadLine()));
            //Helper.Line(30);

            //Helper.PrintResult("Введите дату выдачи: ");
            //DateTime time = ps1._DateTime = Convert.ToDateTime(Console.ReadLine());
            //Helper.Line(30);

            //Helper.PrintResult($"Серия:{serial}\tНомер:{number}\n Ф.И.О:{fio}\n Дата выдачи: {time}");

            //Helper.Line(30);


            Inventar invOrk = new Inventar("Урукхай");
            Monstr ork = new Monstr();
            Helps helpsOrk = new Helps(500, 500);
            Console.WriteLine($"{MonsterType.Orc} - Урукхай");
            Helper.PrintResult("Введите сумму:\n");
            Helper.PrintResult($"Деньги:{ork._Cash = Convert.ToDouble(Console.ReadLine())}, Макс атака:{ork._MaxAttack = Convert.ToInt32(Console.ReadLine())}\n");
            invOrk.Add(new Item("Доспехи", 2000, 35.5));
            invOrk.Add(new Item("Зелье здоровья", 10, 5.0));
            Helper.PrintMonstr(invOrk);
            Helper.PrintResult("Удалить доспехи\n");
            invOrk.Remove(0);
            Helper.PrintMonstr(invOrk);
            Helper.PrintResult("Добавить латы\n");
            invOrk.Add(new Item("Латы", 1300, 30.0));
            Helper.PrintMonstr(invOrk);
            Helper.PrintResult("Добавить Секиру\n");
            invOrk.Add(new Item("Секира", 2300, 30.0));
            Helper.PrintMonstr(invOrk);
            



            Inventar invPeo = new Inventar("Арагорн");
            Monstr peo = new Monstr();
            Helps helpsPeo = new Helps(500, 500);
            Helper.PrintResult("Введите сумму:\n");           
            Helper.PrintResult($"Деньги:{peo._Cash = Convert.ToDouble(Console.ReadLine())}, Макс атака:{peo._MaxAttack = Convert.ToInt32(Console.ReadLine())}\n");
            Console.WriteLine($"{MonsterType.People} - Арагорн");
            invPeo.Add(new Item("Меч", 1800, 30.0));
            invPeo.Add(new Item("Доспехи", 2500, 45.5));
            invPeo.Add(new Item("Зелье здоровья", 10, 5.0));
            Helper.PrintMonstr(invPeo);
            Helper.PrintResult("Заменил меч на топор\n");
            invPeo[0] = new Item("Топор", 1500, 25.5);
            Helper.PrintMonstr(invPeo);




        }


    }
}
