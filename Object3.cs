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

        public Object3(Form previousForm, string clientName)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

            // Устанавливаем начальное положение формы вручную
            this.StartPosition = FormStartPosition.Manual;

            // Указываем координаты для верхнего левого угла формы
            this.Location = new Point(560, 200);

            this.previousForm = previousForm; // Сохраняем ссылку на предыдущую форму

            home = new Home();
            company = new Company();
            projectAction = new ProjectAction();

            // Подписка на события
            projectAction.ProcessHandler += OnProjectProcessed;
            projectAction.RemoveHandler += OnProjectRemoved;

            nameFromObj = clientName;
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

        private Font selectedFont = new Font("Courier New", 12);
        private Color selectedColor = Color.Black;
        private Client client = new Client();

        // Кнопка выбора шрифта
        private void FontButton(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFont = fontDialog.Font;
                }
            }
        }

        // Кнопка выбора цвета шрифта
        private void ColorButton(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedColor = colorDialog.Color;
                }
            }
        }

        // Кнопка вывода на экран
        private void DisplayButton(object sender, EventArgs e)
        {
            // Убираем фоновое изображение с PictureBox
            pictureBox1.BackgroundImage = null;

            // Обновляем данные клиента из TextBox
            client.Name = nameFromObj;  // ФИО из TextBox6

            // Передаем PictureBox, FontDialog и ColorDialog в метод NameText
            client.NameText(pictureBox1, selectedFont, selectedColor);
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

#pragma warning disable CA1416 // Проверка совместимости платформы