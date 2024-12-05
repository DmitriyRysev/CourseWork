using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ComplexityInfo : IComplexity, IComplexity2
    {
        public int Area { get; set; } // Площадь участка
        public int Floors { get; set; } // Количество этажей

        // Реализация метода для расчета сложности
        public double CalculateComplexity()
        {
            return Area * 0.5 + Floors * 2; // Пример формулы
        }

        // Реализация метода для определения уровня сложности
        public string GetComplexityLevel()
        {
            double complexity = CalculateComplexity();
            return complexity switch
            {
                < 80 => "Низкая сложность",
                < 130 => "Средняя сложность",
                _ => "Высокая сложность"
            };
        }
    }
}
