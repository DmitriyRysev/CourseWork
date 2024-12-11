using ClassLibrary;
using System.Diagnostics;

#pragma warning disable CA1416 // Проверка совместимости платформы

namespace CourseWork
{
    public partial class Object3 : Form
    {
        public Home home;
        public Company company;
        private ProjectAction projectAction;
        private Form previousForm;
        private string nameFromObj;
        //private string? DoorFromForm;
        //private string? WinFromForm;
        //private string? RoofFromForm;

        //public Object3(Form previousForm, string clientName, string? door, string? win, string? roof)
        public Object3(Form previousForm, string clientName)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

            // Устанавливаем начальное положение формы вручную
            this.StartPosition = FormStartPosition.Manual;

            // Указываем координаты для верхнего левого угла формы
            this.Location = new Point(600, 300);

            this.previousForm = previousForm; // Сохраняем ссылку на предыдущую форму

            home = new Home();
            company = new Company();
            projectAction = new ProjectAction();

            // Подписка на события
            projectAction.ProcessHandler += OnProjectProcessed;
            projectAction.RemoveHandler += OnProjectRemoved;

            nameFromObj = clientName;
            this.previousForm = previousForm;
            //this.DoorFromForm = door;
            //this.WinFromForm = win;
            //this.RoofFromForm = roof;
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // Завершаем все процессы, связанные с текущим приложением
            Process.GetCurrentProcess().Kill();
        }

        // Обработчик события ProcessHandler 
        private void OnProjectProcessed(object sender, ProjectEventArgs e)
        {
            richTextBox1.Clear();
            string message = $"Спасибо за ваш заказ! Проект под номером {e.ProjectNumber} " +
                $"был успешно принят в работу в {DateTime.Now:T}.";
            richTextBox1.AppendText(message + Environment.NewLine);
        }

        // Обработчик события RemoveHandler 
        private void OnProjectRemoved(object sender, ProjectEventArgs e)
        {
            richTextBox1.Clear();
            string message = $"Жаль, что вы отказались. Проект под номером {e.ProjectNumber} " +
                $"был отменен в {DateTime.Now:T}. Мы будем рады помочь вам в будущем!";
            richTextBox1.AppendText(message + Environment.NewLine);
        }

        // Кнопка добавления проекта в обработку
        private void ProcessButton(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int projectNumber))
            {
                projectAction.ProjectNumber = projectNumber;
                projectAction.ProcessProject();
            }
            else
            {
                MessageBox.Show("Введите корректный номер проекта.", "Ошибка");
            }
        }

        // Кнопка удаления проекта из обработки
        private void RemoveButton(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int projectNumber))
            {
                projectAction.ProjectNumber = projectNumber;
                projectAction.RemoveProject();
            }
            else
            {
                MessageBox.Show("Введите корректный номер проекта.", "Ошибка");
            }
        }

        // Кнопка перехода к предыдущей форме
        private void BackButton(object sender, EventArgs e)
        {
            this.Hide();           // Скрываем текущую форму
            previousForm.Show();   // Показываем предыдущую форму
        }

        private void Object3_Load(object sender, EventArgs e)
        {
            textBox1.AppendText($"{HomeProject.CurrentProjectNumber}\n");
        }
    }
}
