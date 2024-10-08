using System;

namespace ClassLibrary
{
    public struct HomeProject
    {
        // Автоматические свойства
        public int Projnum { get; set; }
        public DateTime ProjectDate { get; set; }

        // Явный конструктор с параметром
        public HomeProject(int ProjNum, DateTime projectDate)
        {
            Projnum = 0;
            ProjectDate = projectDate;

        }

        public string ProjectSummary
        {
            get { return $"Проект под номером {Projnum} будет готов: {ProjectDate:dd/MM/yyyy}\n"; }
        }
    }
}


// Сокращенная запись
//public string FormattedProjnum => $"\nПроект номер {Projnum}\n";