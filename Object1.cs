using ClassLibrary;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

#pragma warning disable CA1416 // Проверка совместимости платформы

namespace CourseWork
{
    public partial class Object1 : Form
    {
        public Home home;
        public Company company;

        public Object1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

            // Устанавливаем начальное положение формы вручную
            this.StartPosition = FormStartPosition.Manual;

            // Указываем координаты для верхнего левого угла формы
            this.Location = new Point(250, 200); // Например, немного левее и выше стандартного положения

            this.home = new Company();
            this.company = new Company();
            this.BackColor = Home.BackColor; // Установка цвета фона окна

            // Добавление элементов из массива
            string[] doorItems = { "Дуб", "Береза", "Ель" };
            comboBox1.Items.AddRange(doorItems);
            comboBox1.Text = "Выберите дверь";

            string[] windowItems = { "Дерево", "Пластик", "Металл" };
            comboBox2.Items.AddRange(windowItems);
            comboBox2.Text = "Выберите раму окна";

            string[] roofItems = { "Черепица", "Кирпичи", "Шифер" };
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

            string[] blueprint = { "Дом с балконом и гаражом", "Дом в стиле модерн с террасой", "Классический коттедж с мансардой" };
            comboBox7.Items.AddRange(blueprint);
            comboBox7.Text = "Чертежи";

            string[] supplier = { "ООО 'ДомСтройКомплект'", "ООО 'Материалы 24/7'", "ООО 'Мир домов'", "ООО'ЭкоЖизнь'" };
            comboBox8.Items.AddRange(supplier);
            comboBox8.Text = "Поставщики";

            string[] product = { "Двери", "Окна", "Крыши" };
            comboBox9.Items.AddRange(product);
            comboBox9.Text = "Продукт";


        }
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // Завершаем все процессы, связанные с текущим приложением
            Process.GetCurrentProcess().Kill();
        }

        // Кнопка чтения информации и вывода ее в richTextBox1
        private void read_button(object sender, EventArgs e)
        {
            // Генерируем случайный номер проекта
            Random random = new Random();
            int ProjNum = random.Next(1, 101);
            HomeProject.CurrentProjectNumber = ProjNum;

            this.home.door = comboBox1.Text;
            this.home.window = comboBox2.Text;
            this.home.roof = comboBox3.Text;

            // Использование свойства
            this.home.Info = comboBox4.Text;
            this.home.Num = textBox5.Text;

            // Проверки на ввод информации пользователем
            bool isMaterialSelected = true;
            if (home.door == "Выберите дверь")
            {
                MessageBox.Show("Пожалуйста, выберите материал для двери.", "Ошибка", MessageBoxButtons.OK);
                isMaterialSelected = false;
            }
            else if (home.window == "Выберите раму окна")
            {
                MessageBox.Show("Пожалуйста, выберите материал для окон.", "Ошибка", MessageBoxButtons.OK);
                isMaterialSelected = false;
            }
            else if (home.roof == "Выберите вид крыши")
            {
                MessageBox.Show("Пожалуйста, выберите материал для крыши.", "Ошибка", MessageBoxButtons.OK);
                isMaterialSelected = false;
            }
            else if (home.Info == "Выберите тип проекта")
            {
                MessageBox.Show("Пожалуйста, выберите тип проекта.", "Ошибка", MessageBoxButtons.OK);
                isMaterialSelected = false;
            }
            else if (this.home.Num.Length != 11)
            {
                MessageBox.Show("Пожалуйста, введите корректный номер телефона.", "Ошибка", MessageBoxButtons.OK);
                return; // Прерываем выполнение метода
            }

            // Если материалы выбраны корректно, продолжаем
            if (isMaterialSelected)
            {
                // Определяем срок ожидания в днях
                int daysToAdd = home.Info == "Премиальный" ? 7 : 14;

                // Создаем объект HomeProject с корректным сроком ожидания
                HomeProject project = new HomeProject(ProjNum, dateTimePicker1.Value.AddDays(daysToAdd));

                richTextBox1.Clear();
                // Выводим выбранные материалы
                richTextBox1.AppendText($"Вы выбрали двери из материала '{home.door}'\n");
                richTextBox1.AppendText($"Вы выбрали окна из материала '{home.window}'\n");
                richTextBox1.AppendText($"Вы выбрали крышу из материала '{home.roof}'\n");

                // Выводим информацию о типе проекта и сроках ожидания
                if (home.Info == "Премиальный")
                {
                    richTextBox1.AppendText($"\nТип проекта: {home.Info}. Срок выполнения: 7 дней (ускоренное выполнение).\nВаш номер телефона: {home.Num}\n");
                }
                else if (home.Info == "Стандартный")
                {
                    richTextBox1.AppendText($"\nТип проекта: {home.Info}.Срок выполнения: 14 дней. Вы можете выбрать 'Премиальный' " +
                        $"тип для сокращения срока до 7 дней.\nВаш номер телефона: {home.Num}\n");
                }

                // Выводим финальную информацию
                richTextBox1.AppendText($"\nЗаявка на выполнение проекта от {dateTimePicker1.Value:dd/MM/yyyy} создана.\n");
                richTextBox1.AppendText(project.ProjectSummary);
            }
        }

        // Кнопка очищения полей ввода
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

        // Кнопка получения хэша объекта 
        private void hash_button(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            // Получение хэш-кода
            richTextBox1.Text += string.Format("Хэш-код объекта {0}, который используется " +
                "для идентификации объекта: {1}. \n", ToString(), GetHashCode());

            //Company company = new Company(textBox7.Text, listBox1.Text, listBox2.Text);
            //richcomboBox2.Text += company.city.GetHashCode().ToString();
        }

        // Кнопка сброса полей ввода, начало проекта с нуля
        private void new_proj_button(object sender, EventArgs e)
        {
            textBox5.Clear();
            richTextBox1.Text = "Добро пожаловать в приложение для создания собственного дизайн-проекта " +
                "вашего дома! Заполните поля и переходите к следующему шагу по нажатию кнопки 'Далее'!";

            // Сброс значений в ComboBox до начального состояния
            comboBox1.Text = "Выберите дверь";
            comboBox2.Text = "Выберите раму окна";
            comboBox3.Text = "Выберите вид крыши";
            comboBox4.Text = "Выберите тип проекта";
            comboBox5.Text = "Площадь участка";
            comboBox6.Text = "Количество этажей";
            comboBox7.Text = "Чертежи";
            comboBox8.Text = "Поставщики";
            comboBox9.Text = "Продукт";
        }

        // Кнопка вычисления сложности проекта
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
                richTextBox1.AppendText($"Сложность выполнения: {complexityLevel}\n");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные данные.", "Ошибка");
            }
        }

        // Кнопка перехода к следующей форме
        private void NextButton(object sender, EventArgs e)
        {
            string num = textBox5.Text; // Получаем номер телефона из TextBox5
            Object2 secondForm = new Object2(this, num);
            secondForm.Show();
            this.Hide();
        }

        private void Object1_Load(object sender, EventArgs e)
        {
            richTextBox1.AppendText($"Добро пожаловать в приложение для создания собственного дизайн-проекта вашего дома! " +
                $"Заполните поля и переходите к следующему шагу по нажатию кнопки 'Далее'!");
        }

        private void BluePrintButton(object sender, EventArgs e)
        {
            // Проверяем корректность ввода данных
            if (!int.TryParse(comboBox5.Text, out int area) || area <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную площадь участка.", "Ошибка");
                return;
            }

            if (!int.TryParse(comboBox6.Text, out int floors) || floors <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное количество этажей.", "Ошибка");
                return;
            }

            string description = comboBox7.Text;
            if (description == "Чертежи")
            {
                MessageBox.Show("Пожалуйста, выберите или введите описание чертежа.", "Ошибка");
                return;
            }

            // Создаем проект с чертежом
            ProjectWithBlueprint project = new ProjectWithBlueprint(area, floors, description);

            // Отображаем данные
            richTextBox1.Clear();
            richTextBox1.AppendText($"Проект:\n");
            richTextBox1.AppendText($"- Площадь: {project.Area} кв.м\n");
            richTextBox1.AppendText($"- Этажей: {project.Floors}\n");
            richTextBox1.AppendText($"Чертеж:\n");
            richTextBox1.AppendText($"- {project.Blueprint.Description}\n");
        }

        private void SupplierButton(object sender, EventArgs e)
        {
            // Проверяем корректность ввода данных
            if (!int.TryParse(comboBox5.Text, out int area) || area <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную площадь участка.", "Ошибка");
                return;
            }

            if (!int.TryParse(comboBox6.Text, out int floors) || floors <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное количество этажей.", "Ошибка");
                return;
            }

            string supplierName = comboBox8.Text;
            if (supplierName == "Поставщики")
            {
                MessageBox.Show("Пожалуйста, выберите имя поставщика.", "Ошибка");
                return;
            }

            string product = comboBox9.Text;
            if (product == "Продукт")
            {
                MessageBox.Show("Пожалуйста, выберите продукта.", "Ошибка");
                return;
            }

            // Создаем проект с поставщиками
            ProjectWithSuppliers project = new ProjectWithSuppliers { Area = area, Floors = floors };

            // Создаем поставщика
            Supplier supplier = new Supplier(supplierName, product);
            project.AddSupplier(supplier);

            // Отображаем данные
            richTextBox1.Clear();
            richTextBox1.AppendText($"Проект:\n");
            richTextBox1.AppendText($"- Площадь: {project.Area} кв.м\n");
            richTextBox1.AppendText($"- Этажей: {project.Floors}\n");
            richTextBox1.AppendText($"Поставщик:\n");
            richTextBox1.AppendText($"- Имя: {supplier.Name}\n");
            richTextBox1.AppendText($"- Продукт: {supplier.Product}\n");
        }

        private void MaterialButton(object sender, EventArgs e)
        {
            // Создаем проект
            ProjectWithMaterials project = new ProjectWithMaterials();

            // Получаем выбранные материалы
            string selectedDoor = comboBox1.Text;
            string selectedWindow = comboBox2.Text;
            string selectedRoof = comboBox3.Text;

            // Находим материалы в каталоге
            var doorMaterial = MaterialCatalog.FindMaterialByName(selectedDoor);
            var windowMaterial = MaterialCatalog.FindMaterialByName(selectedWindow);
            var roofMaterial = MaterialCatalog.FindMaterialByName(selectedRoof);

            // Проверяем, что все материалы найдены
            if (doorMaterial == null || windowMaterial == null || roofMaterial == null)
            {
                MessageBox.Show("Пожалуйста, выберите материалы.", "Ошибка");
                return;
            }

            // Добавляем материалы в проект
            project.AddMaterial(doorMaterial);
            project.AddMaterial(windowMaterial);
            project.AddMaterial(roofMaterial);

            // Рассчитываем общую стоимость
            double totalCost = project.GetTotalMaterialCost();

            // Отображаем данные
            richTextBox1.Clear();
            richTextBox1.AppendText($"Проект: Площадь {comboBox5.Text} кв.м, Этажей {comboBox6.Text}\n");
            richTextBox1.AppendText($"Материалы:\n");
            richTextBox1.AppendText($"- Дверь: {doorMaterial.Name}, Стоимость: {doorMaterial.Cost}₽\n");
            richTextBox1.AppendText($"- Окно: {windowMaterial.Name}, Стоимость: {windowMaterial.Cost}₽\n");
            richTextBox1.AppendText($"- Крыша: {roofMaterial.Name}, Стоимость: {roofMaterial.Cost}₽\n");
            richTextBox1.AppendText($"Общая стоимость материалов: {totalCost}₽\n");
        }
    }
#pragma warning restore CA1416 // Проверка совместимости платформы
}
