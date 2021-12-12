using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOHelperOPDMonstr
{
    enum Genders { Male , Female , Other };

    class Passport
    {
               
        private int Serial;
        private int Number;
        private DateTime dateTime;
        
        
        public Passport() { }

        public Passport(int s, int num, DateTime t, string fio, Genders gender)
        {
            Serial = s;
            Number = num;
            dateTime = t;
            FIO = fio;
            Gender = gender;
            
        }

        public int _Serial
        {

            get { return Serial; }
            set
            {

                if (value == 0) throw new IndexOutOfRangeException("Строка не заполнена!");

                if (value < 1000 || value > 9999) throw new ArgumentException("Введено неверное значение!");

            }
        }
        public int _Number
        {
            get { return Number; }
            set
            {
                if (value == 0) throw new IndexOutOfRangeException("Строка не заполнена!");
                if (value < 100000 || value > 999999) throw new ArgumentException("Введено неверное значение!");
            }

        }
        public string FIO { get; set; }

        public Genders Gender { get; set; } 
        public string GenderText
        {
            get
            {
                return (Gender == Genders.Male ? "Мужской" :(Gender == Genders.Female ? "Женский" : "Неизвестный"));
            }
        }

            
                   

        public DateTime _DateTime
        {
            get { return dateTime; }

            set
            {
                DateTime mytime = value;
                DateTime thisDay = DateTime.Today;
                DateTime date1 = new DateTime(1991, 7, 20);
                

                if (mytime < date1) throw new ArgumentException("Введено неверное значение!");
                if (mytime > thisDay) throw new ArgumentException("Введено неверное значение!");
                
            }

        }


        


    }
        
        




    
}
