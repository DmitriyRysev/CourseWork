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

        private string? info;
        public string? Info { get => info; set { info = value; } }

        private string? num;
        public string? Num 
        { 
            get => num; 
            set { if (value.Length == 11) num = value; else num = "0" ; }
        }
    }
}



// Для 3 лабы: стандартные свойства в классе Home для полей класса
//private string? _door;
//public string? Door
//{
//    get => _door; private set { _door = value; } // Ограничиваем доступ к set, сохраняя возможность чтения
//}

//private string? _window;
//public string? Window
//{
//    get => _window; set { _window = value; }
//}

//private string? _roof;
//public string? Roof
//{
//    get => _roof; set { _roof = value; }
//}



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
