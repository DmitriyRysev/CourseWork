using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ProjectAction
    {
        // Поле для хранения номера проекта
        public int ProjectNumber { get; set; }

        // Делегаты и события
        public delegate void ActionHandler(object sender, ProjectEventArgs e);

        public event ActionHandler? ProcessHandler;
        public event ActionHandler? RemoveHandler;

        // Метод для добавления проекта в обработку
        public void ProcessProject()
        {
            // Генерация события ProcessHandler
            ProcessHandler?.Invoke(this, new ProjectEventArgs(ProjectNumber));
        }

        // Метод для удаления проекта из обработки
        public void RemoveProject()
        {
            // Генерация события RemoveHandler
            RemoveHandler?.Invoke(this, new ProjectEventArgs(ProjectNumber));
        }
    }
}
