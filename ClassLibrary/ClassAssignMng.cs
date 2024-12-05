using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class AssignmentManager
    {
        // Коллекции начальников и отделов
        private List<string> managers;
        private List<string> departments;

        // Конструктор
        public AssignmentManager(ListBox.ObjectCollection managers, ListBox.ObjectCollection departments)
        {
            this.managers = managers.Cast<string>().ToList();
            this.departments = departments.Cast<string>().ToList();
        }

        // Индексатор для доступа к начальникам
        public string this[int index, string type]
        {
            get
            {
                switch (type.ToLower())
                {
                    case "manager":
                        if (index >= 0 && index < managers.Count)
                            return managers[index];
                        break;
                    case "department":
                        if (index >= 0 && index < departments.Count)
                            return departments[index];
                        break;
                }
                return "Не найдено";
            }
        }

        // Метод формирования строки с информацией
        public string GetAssignment(string clientName, int managerIndex, int departmentIndex)
        {
            string manager = this[managerIndex, "manager"];
            string department = this[departmentIndex, "department"];

            if (manager == "Не найдено" || department == "Не найдено")
                return "Ошибка: Некорректные данные.";

            return $"За заказчиком \"{clientName}\" закреплен начальник \"{manager}\" по отделу \"{department}\".";
        }
    }

}
