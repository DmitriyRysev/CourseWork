using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary 
{
    public class Home : DesignCompanyMember
    {
        public string? window;
        public string? door;
        public string? roof;
        public string? city;

        //private string? name;

        //// Реализация свойства Name с проверкой корректности инициалов
        //public override string Name
        //{
        //    get { return name.Replace(name[0].ToString(), name[0].ToString().ToUpper()); }
        //    set
        //    {
        //        if (value.IndexOf('.') == value.Length - 3 && value.LastIndexOf('.') == value.Length - 1)
        //            name = value;
        //        else
        //            name = "Ошибка в инициалах";
        //    }
        //}

        private string? name;

        // Реализация свойства Name с проверкой корректности инициалов
        public override string? Name
        {
            get { return string.IsNullOrEmpty(name) ? name : char.ToUpper(name[0]) + name.Substring(1); }
            set
            {
                // Проверка инициалов
                if (!string.IsNullOrEmpty(value) &&
                    value.IndexOf('.') == value.Length - 3 &&
                    value.LastIndexOf('.') == value.Length - 1)
                {
                    name = value;
                }
                else
                {
                    name = string.IsNullOrEmpty(value) ? string.Empty : "Ошибка в инициалах";
                }
            }
        }

        // Реализация метода NameText, возвращающего информацию об объекте
        public override string NameText()
        {
            return $"ФИО: {this.Name}\n Телефон: {this.Num}";
            //return DateOfBirth.ToShortDateString();
        }

        public Home() { }

        public Home(string? city)
        {
            this.city = city;
        }

        // Статический конструктор
        public static readonly Color BackColor;

        static Home()
        {
            DateTime now = DateTime.Now;

            if (now.DayOfWeek == DayOfWeek.Tuesday || now.DayOfWeek == DayOfWeek.Friday)
            {
                Home.BackColor = Color.FromArgb(215, 228, 242);
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
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 11)
                    num = value;
                else
                    num = "0";
            }
        }

        //Реализация свойства DateOfBirth
        public override DateTime DateOfBirth { get; set; }
    }
}