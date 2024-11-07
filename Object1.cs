using System;
using System.Windows.Forms;
using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using CourseWork.ClassLibrary;
#pragma warning disable CA1416 // Проверка совместимости платформы

namespace CourseWork
{
    public partial class Object1
    {
        public Home home;
        public Company company;

        //private string foto;
        public Object1()
        {
            InitializeComponent();

            // Устанавливаем начальное положение формы вручную
            this.StartPosition = FormStartPosition.Manual;

            // Указываем координаты для верхнего левого угла формы
            this.Location = new Point(350, 5); // Например, немного левее и выше стандартного положения

            this.home = new Company();
            this.company = new Company();
            this.BackColor = Home.BackColor; // Установка цвета фона окна

            // Инициализация ListBox1 начальниками
            listBox1.Items.AddRange(new string[] { "Иванов", "Петров", "Сидоров", "Кузнецов" });

            // Инициализация ListBox2 отделами
            listBox2.Items.AddRange(new string[] { "Восточный", "Западный", "Южный", "Северный" });

        }

        private void read_button(object sender, EventArgs e)
        {
            // Генерируем случайный номер проекта
            Random random = new Random();
            int ProjNum = random.Next(1, 101);

            // Используем конструктор 
            HomeProject project = new HomeProject(ProjNum, dateTimePicker1.Value.AddDays(7));

            this.home.door = textBox1.Text;
            this.home.window = textBox2.Text;
            this.home.roof = textBox3.Text;

            // Использование свойства
            this.home.Info = textBox4.Text;
            this.home.Num = textBox5.Text;


            // Проверяем, заполнено ли поле для двери
            if (!string.IsNullOrWhiteSpace(home.door))
            {
                richTextBox1.Text += String.Format("Вы выбрали двери из материала '{0}'\n", home.door);
            }

            // Проверяем, заполнено ли поле для окна
            if (!string.IsNullOrWhiteSpace(home.window))
            {
                richTextBox1.Text += String.Format("Вы выбрали окна из материала '{0}'\n", home.window);
            }

            // Проверяем, заполнено ли поле для крыши
            if (!string.IsNullOrWhiteSpace(home.roof))
            {
                richTextBox1.Text += String.Format("Вы выбрали крышу из материала '{0}'\n", home.roof);
            }

            if (!string.IsNullOrWhiteSpace(this.home.door) &&
               !string.IsNullOrWhiteSpace(this.home.window) &&
               !string.IsNullOrWhiteSpace(this.home.roof))
            {
                // Вывод информации в интерфейс 
                DateTime selectedDate = dateTimePicker1.Value;
                richTextBox1.Text += String.Format("Заявка на выполнение проекта от {0:dd/MM/yyyy} создана.\n", selectedDate);
                richTextBox1.Text += project.ProjectSummary;

                // Использование свойств
                richTextBox1.Text += String.Format("Тип проекта:'{0}'\nВаш номер телефона: {1}\n", home.Info, home.Num);
            }   
            else
            {
                // Если хотя бы одно поле не заполнено, выводим сообщение об ошибке
                richTextBox1.Text = "Сначала выберите материалы!\n";
            }
        }

        private void clear_button(object sender, EventArgs e)
        {
            // Очищение полей ввода
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            // Создаем объекты с собственными конструкторами классов-наследников
            Home home = new Home { Name = textBox2.Text, Num = textBox1.Text };
            Company company = new Company { Name = textBox2.Text, Num = textBox1.Text };
            Client client = new Client(textBox2.Text, textBox1.Text);

            // Создаем объекты с типом базового класса DesignCompanyMember
            DesignCompanyClient homeAsBase = new Home { Name = textBox2.Text, Num = textBox1.Text };
            DesignCompanyClient companyAsBase = new Company { Name = textBox2.Text, Num = textBox1.Text };
            DesignCompanyClient clientAsBase = new Client(textBox2.Text, textBox1.Text);

            // Выводим результаты вызова метода NameText() для каждого объекта
            richTextBox1.Text = home.NameText() + "\n" +
                                company.NameText() + "\n" +
                                client.NameText() + "\n" +

                                homeAsBase.NameText() + "\n" +
                                companyAsBase.NameText() + "\n" +
                                clientAsBase.NameText();
        }

        private void hash_button(object sender, EventArgs e)
        {
            // Получение хэш-кода
            richTextBox1.Text += string.Format("\nХэш-код объекта {0}, который используется " +
                "для идентификации объекта: {1}. \n", ToString(), GetHashCode());

            //Company company = new Company(textBox7.Text, listBox1.Text, listBox2.Text);
            //richTextBox2.Text += company.city.GetHashCode().ToString();
        }

        private void new_proj_button(object sender, EventArgs e)
        {
            // "новый проект" - очищение всего окна полностью
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();

        }

        private void RecordButton(object sender, EventArgs e)
        {
            // Создаем объект класса Company
            Company company = new Company(listBox2.SelectedItem?.ToString(), listBox1.SelectedItem?.ToString(), textBox7.Text);

            // Upcasting: преобразуем объект Company к базовому типу Home
            Home homeAsBase = company;

            // Используем базовые свойства объекта Home
            homeAsBase.window = textBox1.Text;
            homeAsBase.door = textBox2.Text;
            homeAsBase.roof = textBox3.Text;

            // Формируем строку для записи
            string dataToWrite = $"Город: {homeAsBase.city}\nНачальник отдела: {company.Head}\nОтдел: {company.Department}";

            // Записываем данные в файл
            File.WriteAllText("companyData.txt", dataToWrite);

            MessageBox.Show("Данные успешно записаны в файл!");
        }

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitialsButton(object sender, EventArgs e)
        {
            // Установка имени с проверкой инициалов
            company.Name = textBox6.Text;

            // Вывод результата проверки в richTextBox3
            richTextBox3.Text = $"ФИО: {company.Name}\n";
        }

        private void InfoButton(object sender, EventArgs e)
        {
            // Установка даты рождения
            company.DateOfBirth = dateTimePicker2.Value;

            company.Num = textBox5.Text;
            company.Name = textBox6.Text;

            // Вызов метода NameText и вывод результата в richTextBox3
            richTextBox3.Text += $"Информация:\n{company.NameText()}\n";
            richTextBox3.Text += $"{company.ToString()}\n";
        }

        private Font selectedFont = new Font("Courier New", 12);
        private Color selectedColor = Color.Black;
        private Client client = new Client();

        // Кнопка для выбора шрифта из диалогового окна
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

        // Кнопка для выбора цвета из диалогового окна
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

        // Кнопка вывода ФИО в pictureBox
        private void DisplayButton(object sender, EventArgs e)
        {
            // Убираем фоновое изображение с PictureBox
            pictureBox1.BackgroundImage = null;

            // Обновляем данные клиента из TextBox
            client.Name = textBox6.Text;  // ФИО из TextBox6

            // Передаем PictureBox, FontDialog и ColorDialog в метод NameText
            client.NameText(pictureBox1, selectedFont, selectedColor);
        }
    }
#pragma warning restore CA1416 // Проверка совместимости платформы
}
