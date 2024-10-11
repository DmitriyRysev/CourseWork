using System;
using System.Drawing;

namespace CourseWork.ClassLibrary
{
    public class Home
    {
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