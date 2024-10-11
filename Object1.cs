using System;
using ClassLibrary;
using CourseWork.ClassLibrary;
#pragma warning disable CA1416 // Проверка совместимости платформы

namespace CourseWork
{
    public partial class Object1
    {
        public Home home;
        public Object1()
        {
            InitializeComponent();
            this.home = new Home();
            this.BackColor = Home.BackColor; // Установка цвета фона окна

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
        }

        private void hash_button(object sender, EventArgs e)
        {
            // Получение хэш-кода
            int hashCode = this.home.GetHashCode();
            richTextBox1.Text += string.Format("\nХэш-код объекта {0}, который используется " +
                "для идентификации объекта: {1}. \n", ToString(), hashCode);
        }

        private void new_proj_button(object sender, EventArgs e)
        {
            // "новый проект" - очищение всего окна полностью
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            richTextBox1.Clear();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
#pragma warning restore CA1416 // Проверка совместимости платформы
}
