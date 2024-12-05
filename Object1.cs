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
        private ProjectAction projectAction;
        private AssignmentManager assignmentManager;

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

            // Инициализация AssignmentManager
            assignmentManager = new AssignmentManager(listBox1.Items, listBox2.Items);

            // Создаём экземпляр ProjectAction
            projectAction = new ProjectAction();

            // Подписываемся на события
            projectAction.ProcessHandler += OnProjectProcessed;
            projectAction.RemoveHandler += OnProjectRemoved;

            // Добавление элементов из массива
            string[] doorItems = { "Дуб", "Береза", "Ель" };
            comboBox1.Items.AddRange(doorItems);
            comboBox1.Text = "Выберите дверь";

            string[] windowItems = { "Дерево", "Пластик", "Металл" };
            comboBox2.Items.AddRange(windowItems);
            comboBox2.Text = "Выберите раму окна";

            string[] roofItems = { "Из черепицы", "Кирпичная", "Кровля из металла" };
            comboBox3.Items.AddRange(roofItems);
            comboBox3.Text = "Выберите вид крыши";

            string[] projItems = { "Премиальный", "Стандартный" };
            comboBox4.Items.AddRange(projItems);
            comboBox4.Text = "Выберите тип проекта";

            string[] areaItems = { "150", "200", "250", "300" };
            comboBox5.Items.AddRange(areaItems);
            comboBox5.Text = "Площадь участка";

            string[] floorItems = { "1", "2", "3" };
            comboBox6.Items.AddRange(floorItems);
            comboBox6.Text = "Количество этажей";


        }

        // Обработчик события ProcessHandler 
        private void OnProjectProcessed(object sender, ProjectEventArgs e)
        {
            string message = $"[{DateTime.Now:T}] Проект под номером {e.ProjectNumber} добавлен в обработку.";
            richTextBox1.AppendText(message + Environment.NewLine);
        }

        // Обработчик события RemoveHandler 
        private void OnProjectRemoved(object sender, ProjectEventArgs e)
        {
            string message = $"[{DateTime.Now:T}] Проект под номером {e.ProjectNumber} удалён из обработки.";
            richTextBox1.AppendText(message + Environment.NewLine);
        }

        private void ProcessButton(object sender, EventArgs e)
        {
            if (int.TryParse(textBox8.Text, out int projectNumber))
            {
                projectAction.ProjectNumber = projectNumber;
                projectAction.ProcessProject();
            }
            else
            {
                MessageBox.Show("Введите корректный номер проекта.", "Ошибка");
            }
        }

        private void RemoveButton(object sender, EventArgs e)
        {
            if (int.TryParse(textBox8.Text, out int projectNumber))
            {
                projectAction.ProjectNumber = projectNumber;
                projectAction.RemoveProject();
            }
            else
            {
                MessageBox.Show("Введите корректный номер проекта.", "Ошибка");
            }
        }

        private void read_button(object sender, EventArgs e)
        {
            // Генерируем случайный номер проекта
            Random random = new Random();
            int ProjNum = random.Next(1, 101);

            // Используем конструктор 
            HomeProject project = new HomeProject(ProjNum, dateTimePicker1.Value.AddDays(7));

            this.home.door = comboBox1.Text;
            this.home.window = comboBox2.Text;
            this.home.roof = comboBox3.Text;

            // Использование свойства
            this.home.Info = comboBox4.Text;
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
            textBox5.Clear();

            //// Создаем объекты с собственными конструкторами классов-наследников
            //Home home = new Home { Name = comboBox2.Text, Num = comboBox1.Text };
            //Company company = new Company { Name = comboBox2.Text, Num = comboBox1.Text };
            //Client client = new Client(comboBox2.Text, comboBox1.Text);

            //// Создаем объекты с типом базового класса DesignCompanyMember
            //DesignCompanyClient homeAsBase = new Home { Name = comboBox2.Text, Num = comboBox1.Text };
            //DesignCompanyClient companyAsBase = new Company { Name = comboBox2.Text, Num = comboBox1.Text };
            //DesignCompanyClient clientAsBase = new Client(comboBox2.Text, comboBox1.Text);

            //// Выводим результаты вызова метода NameText() для каждого объекта
            //richTextBox1.Text = home.NameText() + "\n" +
            //                    company.NameText() + "\n" +
            //                    client.NameText() + "\n" +

            //                    homeAsBase.NameText() + "\n" +
            //                    companyAsBase.NameText() + "\n" +
            //                    clientAsBase.NameText();
        }

        private void hash_button(object sender, EventArgs e)
        {
            // Получение хэш-кода
            richTextBox1.Text += string.Format("\nХэш-код объекта {0}, который используется " +
                "для идентификации объекта: {1}. \n", ToString(), GetHashCode());

            //Company company = new Company(textBox7.Text, listBox1.Text, listBox2.Text);
            //richcomboBox2.Text += company.city.GetHashCode().ToString();
        }

        private void new_proj_button(object sender, EventArgs e)
        {
            // "новый проект" - очищение всего окна полностью
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
            homeAsBase.window = comboBox1.Text;
            homeAsBase.door = comboBox2.Text;
            homeAsBase.roof = comboBox3.Text;

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

            richTextBox3.Clear();

            // Вызов метода NameText и вывод результата в richTextBox3
            richTextBox3.Text += $"{company.NameText()}\n";
            //richTextBox3.Text += $"{company.ToString()}\n";
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

        private void AssignButton(object sender, EventArgs e)
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

        private void CalculateComplexityButton(object sender, EventArgs e)
        {
            // Проверка введенных данных
            if (int.TryParse(comboBox5.Text, out int area) && int.TryParse(comboBox6.Text, out int floors))
            {
                // Создание объекта и расчет сложности
                ComplexityInfo project = new ComplexityInfo
                {
                    Area = area,
                    Floors = floors
                };

                // Преобразование интерфейса обратно в класс ComplexityInfo
                if (project is ComplexityInfo detailedProject)
                {
                    // Доступ к специфическим свойствам и методам класса ComplexityInfo
                    richTextBox1.AppendText($"Площадь: {detailedProject.Area} кв.м\n");
                    richTextBox1.AppendText($"Количество этажей: {detailedProject.Floors}\n");
                }
                else
                {
                    richTextBox1.AppendText("Не удалось преобразовать объект в ComplexityInfo.\n");
                }


                // Получение данных из методов
                double complexity = project.CalculateComplexity();
                string complexityLevel = project.GetComplexityLevel();

                richTextBox1.Clear();

                // Вывод данных в RichTextBox
                richTextBox1.AppendText($"Площадь: {area} кв.м\n");
                richTextBox1.AppendText($"Количество этажей: {floors}\n");
                richTextBox1.AppendText($"Сложность: {complexityLevel} (Оценка: {complexity:F2})\n");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные данные.", "Ошибка");
            }


        }
    }
#pragma warning restore CA1416 // Проверка совместимости платформы
}
