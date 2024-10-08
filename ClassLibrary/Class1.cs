using System;
using System.Drawing;

namespace CourseWork.ClassLibrary
{
    public class Home
    {
        //public Home(string? info1, string? num1) { info = info1; num = num1; }

        public string? window;
        public string? door;
        public string? roof;

        // Статический конструктор
        public static readonly Color BackColor;

        static Home()
        {
            DateTime now = DateTime.Now;

            if (now.DayOfWeek == DayOfWeek.Tuesday || now.DayOfWeek == DayOfWeek.Friday)
            {
                Home.BackColor = Color.White;
            }

            else
            {
                Home.BackColor = Color.AliceBlue;
            }
        }

        // Свойства
        //private string? info;
        //public string? Info { get => info; set { info = value; } }

        // Проверка символа и его замена
        private string? info;
        public string? Info
        {
            get => info;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    // Проверка, является ли первый символ строчным
                    if (char.IsLower(value[0]))
                    {
                        // Заменяем первый символ на прописной
                        info = char.ToUpper(value[0]) + value.Substring(1);
                    }
                    else
                    {
                        info = value;
                    }
                }
            }
        }

        private string? num;
        public string? Num 
        { 
            get => num; 
            set { if (value.Length == 11) num = value; else num = "0" ; }
        }
    }
}


// Перегрузки конструкторов

//public string sofa;
//public string bed;
//public string table;

// Конструкторы класса
//public Home() { }

//public Home(string sofa)
//{
//    this.sofa = sofa;
//}

//public Home(string sofa, string bed)
//{
//    this.sofa = sofa;
//    this.bed = bed;
//}

//public Home(string sofa, string bed, string table)
//{
//    this.sofa = sofa;
//    this.bed = bed;
//    this.table = table;
//}
