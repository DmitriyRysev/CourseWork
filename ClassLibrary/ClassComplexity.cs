namespace ClassLibrary
{
    public class ComplexityInfo : IComplexity, IComplexity2
    {
        public int Area { get; set; } // Площадь участка
        public int Floors { get; set; } // Количество этажей

        // Реализация метода для расчета сложности
        public double CalculateComplexity()
        {
            return Area * 0.5 + Floors * 2;
        }

        // Реализация метода для определения уровня сложности
        public string GetComplexityLevel()
        {
            double complexity = CalculateComplexity();
            return complexity switch
            {
                < 80 => "Низкая",
                < 130 => "Средняя",
                _ => "Высокая"
            };
        }
    }
}
