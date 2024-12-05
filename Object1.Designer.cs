using System.Windows.Forms;

namespace CourseWork
{
    public partial class Object1 : Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Object1));
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label9 = new Label();
            label10 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            richTextBox2 = new RichTextBox();
            textBox7 = new TextBox();
            richTextBox3 = new RichTextBox();
            button7 = new Button();
            button8 = new Button();
            label11 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button12 = new Button();
            button13 = new Button();
            textBox8 = new TextBox();
            label13 = new Label();
            label15 = new Label();
            label14 = new Label();
            button14 = new Button();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            label16 = new Label();
            comboBox5 = new ComboBox();
            label17 = new Label();
            comboBox6 = new ComboBox();
            button15 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 28);
            label1.Name = "label1";
            label1.Size = new Size(526, 31);
            label1.TabIndex = 0;
            label1.Text = "Компания \"Уит\" - строим будущее!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 351);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод и редактирование";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(6, 260);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(267, 28);
            comboBox4.TabIndex = 18;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(60, 148);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(213, 28);
            comboBox3.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(60, 106);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 28);
            comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 28);
            comboBox1.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(6, 314);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(267, 27);
            textBox5.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(6, 291);
            label8.Name = "label8";
            label8.Size = new Size(143, 17);
            label8.TabIndex = 13;
            label8.Text = "Номер телефона:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(6, 235);
            label7.Name = "label7";
            label7.Size = new Size(116, 17);
            label7.TabIndex = 12;
            label7.Text = "Тип проекта:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(6, 202);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 26);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 179);
            label6.Name = "label6";
            label6.Size = new Size(188, 17);
            label6.TabIndex = 9;
            label6.Text = "Дата создания заявки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(6, 153);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 8;
            label5.Text = "Крыша";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 111);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 7;
            label4.Text = "Окна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 70);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 6;
            label3.Text = "Двери";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(161, 34);
            label2.TabIndex = 2;
            label2.Text = "Введите желаемые \r\nкомпоненты дома:";
            // 
            // Button1
            // 
            Button1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.Black;
            Button1.Location = new Point(18, 462);
            Button1.Name = "Button1";
            Button1.Size = new Size(129, 63);
            Button1.TabIndex = 10;
            Button1.Text = "Прочитать";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += read_button;
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(158, 462);
            button2.Name = "button2";
            button2.Size = new Size(127, 63);
            button2.TabIndex = 11;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += clear_button;
            // 
            // button3
            // 
            button3.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(302, 411);
            button3.Name = "button3";
            button3.Size = new Size(149, 63);
            button3.TabIndex = 12;
            button3.Text = "Получить хэш-код";
            button3.UseVisualStyleBackColor = true;
            button3.Click += hash_button;
            // 
            // button4
            // 
            button4.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(459, 411);
            button4.Name = "button4";
            button4.Size = new Size(149, 63);
            button4.TabIndex = 13;
            button4.Text = "Новый проект";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new_proj_button;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(778, 105);
            label9.Name = "label9";
            label9.Size = new Size(179, 20);
            label9.TabIndex = 15;
            label9.Text = "Город проживания:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(898, 160);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 16;
            label10.Text = "СПРАВОЧНИКИ:";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(778, 183);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 84);
            listBox1.TabIndex = 17;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(964, 183);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 84);
            listBox2.TabIndex = 18;
            // 
            // button5
            // 
            button5.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(778, 284);
            button5.Name = "button5";
            button5.Size = new Size(180, 63);
            button5.TabIndex = 19;
            button5.Text = "Запись";
            button5.UseVisualStyleBackColor = true;
            button5.Click += RecordButton;
            // 
            // button6
            // 
            button6.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(964, 284);
            button6.Name = "button6";
            button6.Size = new Size(181, 63);
            button6.TabIndex = 20;
            button6.Text = "Чтение";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ReadButton;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.Location = new Point(778, 423);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(367, 102);
            richTextBox2.TabIndex = 21;
            richTextBox2.Text = "";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(778, 131);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(366, 27);
            textBox7.TabIndex = 4;
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox3.Location = new Point(12, 720);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(364, 219);
            richTextBox3.TabIndex = 1;
            richTextBox3.Text = "";
            // 
            // button7
            // 
            button7.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(12, 651);
            button7.Name = "button7";
            button7.Size = new Size(178, 63);
            button7.TabIndex = 22;
            button7.Text = "Инициалы";
            button7.UseVisualStyleBackColor = true;
            button7.Click += InitialsButton;
            // 
            // button8
            // 
            button8.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(196, 651);
            button8.Name = "button8";
            button8.Size = new Size(180, 63);
            button8.TabIndex = 23;
            button8.Text = "Информация";
            button8.UseVisualStyleBackColor = true;
            button8.Click += InfoButton;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(12, 537);
            label11.Name = "label11";
            label11.Size = new Size(279, 20);
            label11.TabIndex = 24;
            label11.Text = "Введите фамилию и инициалы:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(12, 563);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(364, 27);
            textBox6.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(12, 596);
            label12.Name = "label12";
            label12.Size = new Size(309, 20);
            label12.TabIndex = 26;
            label12.Text = "Выберите дату вашего рождения:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(12, 619);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(364, 26);
            dateTimePicker2.TabIndex = 27;
            // 
            // button9
            // 
            button9.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(388, 807);
            button9.Name = "button9";
            button9.Size = new Size(185, 63);
            button9.TabIndex = 29;
            button9.Text = "Шрифт";
            button9.UseVisualStyleBackColor = true;
            button9.Click += FontButton;
            // 
            // button10
            // 
            button10.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(581, 807);
            button10.Name = "button10";
            button10.Size = new Size(185, 63);
            button10.TabIndex = 30;
            button10.Text = "Цвет";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ColorButton;
            // 
            // button11
            // 
            button11.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(388, 876);
            button11.Name = "button11";
            button11.Size = new Size(378, 63);
            button11.TabIndex = 31;
            button11.Text = "Вывод";
            button11.UseVisualStyleBackColor = true;
            button11.Click += DisplayButton;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.шрифт2;
            pictureBox1.Location = new Point(388, 563);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 238);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.PanelPoster1;
            panel2.Location = new Point(778, 748);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 191);
            panel2.TabIndex = 33;
            // 
            // button12
            // 
            button12.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.Black;
            button12.Location = new Point(778, 679);
            button12.Name = "button12";
            button12.Size = new Size(177, 63);
            button12.TabIndex = 34;
            button12.Text = "В обработку";
            button12.UseVisualStyleBackColor = true;
            button12.Click += ProcessButton;
            // 
            // button13
            // 
            button13.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.ForeColor = Color.Black;
            button13.Location = new Point(967, 679);
            button13.Name = "button13";
            button13.Size = new Size(177, 63);
            button13.TabIndex = 35;
            button13.Text = "Удаление";
            button13.UseVisualStyleBackColor = true;
            button13.Click += RemoveButton;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(778, 563);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(367, 26);
            textBox8.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(778, 537);
            label13.Name = "label13";
            label13.Size = new Size(299, 20);
            label13.TabIndex = 37;
            label13.Text = "Введите номер вашего проекта:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(964, 596);
            label15.Name = "label15";
            label15.Size = new Size(143, 68);
            label15.TabIndex = 39;
            label15.Text = "Или же удалите\r\nиз обработки,\r\nесли передумали\r\nоформлять заказ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(778, 596);
            label14.Name = "label14";
            label14.Size = new Size(134, 68);
            label14.TabIndex = 38;
            label14.Text = "Добавьте его \r\nв обработку,\r\nесли готовы \r\nоформить заказ";
            // 
            // button14
            // 
            button14.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.Black;
            button14.Location = new Point(778, 354);
            button14.Name = "button14";
            button14.Size = new Size(366, 63);
            button14.TabIndex = 40;
            button14.Text = "Индексаторы";
            button14.UseVisualStyleBackColor = true;
            button14.Click += AssignButton;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(464, 272);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(296, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 300);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Просмотр";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(296, 477);
            label16.Name = "label16";
            label16.Size = new Size(233, 17);
            label16.TabIndex = 41;
            label16.Text = "Выберите площадь участка:";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(296, 497);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(231, 28);
            comboBox5.TabIndex = 42;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(537, 477);
            label17.Name = "label17";
            label17.Size = new Size(215, 17);
            label17.TabIndex = 43;
            label17.Text = "Выберите кол-во этажей:";
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(537, 497);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(235, 28);
            comboBox6.TabIndex = 44;
            // 
            // button15
            // 
            button15.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.ForeColor = Color.Black;
            button15.Location = new Point(617, 411);
            button15.Name = "button15";
            button15.Size = new Size(149, 63);
            button15.TabIndex = 45;
            button15.Text = "Сложность";
            button15.UseVisualStyleBackColor = true;
            button15.Click += CalculateComplexityButton;
            // 
            // Object1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 951);
            Controls.Add(button15);
            Controls.Add(comboBox6);
            Controls.Add(label17);
            Controls.Add(comboBox5);
            Controls.Add(label16);
            Controls.Add(button14);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(textBox8);
            Controls.Add(button13);
            Controls.Add(button7);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(dateTimePicker2);
            Controls.Add(label12);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(button8);
            Controls.Add(richTextBox3);
            Controls.Add(textBox7);
            Controls.Add(richTextBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Courier New", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.MediumBlue;
            Name = "Object1";
            Text = "Строительная компания";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button5;
        private Button button6;
        private RichTextBox richTextBox2;
        private TextBox textBox7;
        private RichTextBox richTextBox3;
        private Button button7;
        private Button button8;
        private Label label11;
        private TextBox textBox6;
        private Label label12;
        private DateTimePicker dateTimePicker2;
        private Button button9;
        private Button button10;
        private Button button11;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button12;
        private Button button13;
        private TextBox textBox8;
        private Label label13;
        private Label label15;
        private Label label14;
        private Button button14;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private Label label16;
        private ComboBox comboBox5;
        private Label label17;
        private ComboBox comboBox6;
        private Button button15;
    }
}

