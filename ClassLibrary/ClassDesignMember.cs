using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract public class DesignCompanyMember
    {
        // Абстрактное свойство Name с проверкой инициалов
        public abstract string Name { get; set; }

        // Абстрактный метод NameText() для отображения имени, реализуем в дочерних классах
        public abstract string NameText();

        // Переопределение метода ToString
        public override string? ToString()
        {
            // Возвращаем базовый ToString(), если Name пустое, иначе — значение Name
            return string.IsNullOrEmpty(this.Name) || this.Name == "Ошибка в инициалах" ? base.ToString() : this.Name;

            //if (string.IsNullOrEmpty(Name))  // <-- это как в примере
            //    return base.ToString();
            //return Name;
        }

        //Абстрактное свойство DateOfBirth, которое нужно реализовать в дочерних классах
        public abstract DateTime DateOfBirth { get; set; }

    }
}
