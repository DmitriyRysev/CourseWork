using ClassLibrary;
using System.Diagnostics;

#pragma warning disable CA1416 // Проверка совместимости платформы

namespace CourseWork
{
    public partial class Object2 : Form
    {
        public Home home;
        public Company company;
        private AssignmentManager assignmentManager;

        private Form previousForm; // Ссылка на предыдущую форму
        private string numFromObject1;
        public Object2(Form previousForm, string num)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

            // Устанавливаем начальное положение формы вручную
            this.StartPosition = FormStartPosition.Manual;

            // Указываем координаты для верхнего левого угла формы
            this.Location = new Point(620, 200); // Например, немного левее и выше стандартного положения

            this.previousForm = previousForm; // Сохраняем ссылку на предыдущую форму

            home = new Home();
            company = new Company();

            // Инициализация ListBox1 начальниками
            listBox1.Items.AddRange(new string[] { "Иванов", "Петров", "Сидоров", "Кузнецов" });

            // Инициализация ListBox2 отделами
            listBox2.Items.AddRange(new string[] { "Восточный", "Западный", "Южный", "Северный" });

            // Инициализация AssignmentManager
            assignmentManager = new AssignmentManager(listBox1.Items, listBox2.Items);

            numFromObject1 = num;
        }
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // Завершаем все процессы, связанные с текущим приложением
            Process.GetCurrentProcess().Kill();
        }

        // Кнопка записи данных о начальниках в файл
        private void RecordButton(object sender, EventArgs e)
        {
            // Создаем объект класса Company
            Company company = new Company(listBox2.SelectedItem?.ToString(), listBox1.SelectedItem?.ToString(), textBox7.Text);

            // Upcasting: преобразуем объект Company к базовому типу Home
            Home homeAsBase = company;

            // Формируем строку для записи
            string dataToWrite = $"Город: {homeAsBase.city}\nНачальник отдела: {company.Head}\nОтдел: {company.Department}";

            // Записываем данные в файл
            File.WriteAllText("companyData.txt", dataToWrite);

            MessageBox.Show("Данные успешно записаны в файл!");
        }

        // Кнопка чтения данных о начальниках из файла
        private void ReadButton(object sender, EventArgs e)
        {
            if (File.Exists("companyData.txt"))
            {
                // Читаем данные из файла и выводим в RichTextBox
                string dataFromFile = File.ReadAllText("companyData.txt");
                richTextBox2.Text = dataFromFile;
            }

            else
            {
                MessageBox.Show("Файл не найден. Сначала запишите данные.");
            }
        }

        // Кнопка индексации по ФИО, начальнику и отделу
        private void IndexButton(object sender, EventArgs e)
        {
            // Получение данных из TextBox и ListBox
            string clientName = textBox6.Text;
            int managerIndex = listBox1.SelectedIndex;
            int departmentIndex = listBox2.SelectedIndex;

            if (string.IsNullOrWhiteSpace(clientName) || managerIndex == -1 || departmentIndex == -1)
            {
                MessageBox.Show("Ошибка: заполните все поля и выберите элементы из списков.");
                return;
            }

            // Формирование строки с информацией
            string result = assignmentManager.GetAssignment(clientName, managerIndex, departmentIndex);

            // Вывод результата
            richTextBox2.Text = result;
        }

        // КНопка проверки инициалов
        private void InitialsButton(object sender, EventArgs e)
        {
            // Установка имени с проверкой инициалов
            company.Name = textBox6.Text;

            // Вывод результата проверки в richTextBox3
            richTextBox3.Text = $"ФИО: {company.Name}\n";
        }

        // Кнопка вывода информации
        private void InfoButton(object sender, EventArgs e)
        {
            // Установка даты рождения
            company.DateOfBirth = dateTimePicker2.Value;

            company.Num = numFromObject1; // Используем переданный номер
            company.Name = textBox6.Text;

            richTextBox3.Clear();

            // Вызов метода NameText и вывод результата в richTextBox3
            richTextBox3.Text += $"{company.NameText()}\n";
            //richTextBox3.Text += $"{company.ToString()}\n";
        }

        // Кнопка перехода к следующей форме
        private void NextButton(object sender, EventArgs e)
        {
            string clientName = textBox6.Text;
            Object3 thirdForm = new Object3(this, clientName);
            thirdForm.Show();
            this.Hide();
        }

        private void BackButton(object sender, EventArgs e)
        {
            this.Hide();           // Скрываем текущую форму
            previousForm.Show();   // Показываем предыдущую форму
        }
    }
}

#pragma warning disable CA1416 // Проверка совместимости платформы