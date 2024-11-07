using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Company : Home
    {
        public string? Department;
        public string? Head;

        public Company() : base() { }

        public Company(string? department, string? head, string? city) : base(city)
        {
            Department = department;
            Head = head;
        }

        private string? name;

        // Свойство Name с проверкой на наличие инициалов
        public override string Name
        {
            get => string.IsNullOrEmpty(name) ? "Ошибка в инициалах" : name;
            set
            {
                // Проверка на точку (как признак инициалов)
                if (!string.IsNullOrEmpty(value) && value.Contains('.'))
                {
                    name = value;
                }
                else
                {
                    name = string.Empty;
                }
            }
        }

        // Реализация метода NameText для отображения информации
        public override string NameText()
        {
            return $"ФИО: {this.Name}\nТелефон: {this.Num}\nДата рождения: {this.DateOfBirth.ToShortDateString()}";
        }

        //Реализация свойства DateOfBirth
        public override DateTime DateOfBirth { get; set; }
    }
}
