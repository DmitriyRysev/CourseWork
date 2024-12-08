using System;

namespace ClassLibrary
{
    public struct HomeProject
    {
        public static int CurrentProjectNumber { get; set; }

        // Автоматические свойства  
        public int Projnum { get; set; }
        public DateTime ProjectDate { get; set; }   

        // Явный конструктор с параметрами
        public HomeProject(int ProjNum, DateTime projectDate)
        {
            Projnum = ProjNum;
            ProjectDate = projectDate;

        }

        public string ProjectSummary
        {
            get { return $"Проект под номером {Projnum} будет готов: {ProjectDate:dd/MM/yyyy}\n"; }
        }
    }
}
