#pragma warning disable CA1416 // Проверка совместимости платформы

namespace CourseWork
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Object1());
        }
    }
}

#pragma warning disable CA1416 // Проверка совместимости платформы