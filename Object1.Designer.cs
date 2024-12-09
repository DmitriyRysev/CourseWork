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
            button3 = new Button();
            button4 = new Button();
            richTextBox1 = new RichTextBox();
            label16 = new Label();
            comboBox5 = new ComboBox();
            label17 = new Label();
            comboBox6 = new ComboBox();
            button15 = new Button();
            label9 = new Label();
            button2 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            comboBox9 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(1217, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 28);
            label1.Name = "label1";
            label1.Size = new Size(526, 31);
            label1.TabIndex = 0;
            label1.Text = "Компания \"Уит\" - строим будущее!";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(12, 359);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(278, 28);
            comboBox4.TabIndex = 18;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(77, 216);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(213, 28);
            comboBox3.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(77, 182);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 28);
            comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 28);
            comboBox1.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(12, 427);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(278, 27);
            textBox5.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 404);
            label8.Name = "label8";
            label8.Size = new Size(159, 20);
            label8.TabIndex = 13;
            label8.Text = "Номер телефона:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 316);
            label7.Name = "label7";
            label7.Size = new Size(219, 40);
            label7.TabIndex = 12;
            label7.Text = "Тип проекта(влияет на\r\nвремя выполнения):";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(12, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(279, 26);
            dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 251);
            label6.Name = "label6";
            label6.Size = new Size(219, 20);
            label6.TabIndex = 9;
            label6.Text = "Дата создания заявки:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 8;
            label5.Text = "Крыша";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Окна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 6;
            label3.Text = "Двери";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(279, 40);
            label2.TabIndex = 2;
            label2.Text = "Выберите желаемые\r\nкомпоненты дома из списков.";
            // 
            // Button1
            // 
            Button1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.Black;
            Button1.Location = new Point(12, 460);
            Button1.Name = "Button1";
            Button1.Size = new Size(278, 57);
            Button1.TabIndex = 10;
            Button1.Text = "Применить";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += read_button;
            // 
            // button3
            // 
            button3.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(12, 520);
            button3.Name = "button3";
            button3.Size = new Size(278, 57);
            button3.TabIndex = 12;
            button3.Text = "Получить хэш-код";
            button3.UseVisualStyleBackColor = true;
            button3.Click += hash_button;
            // 
            // button4
            // 
            button4.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(599, 523);
            button4.Name = "button4";
            button4.Size = new Size(282, 57);
            button4.TabIndex = 13;
            button4.Text = "Начать заново";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new_proj_button;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(307, 148);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(574, 288);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(308, 443);
            label16.Name = "label16";
            label16.Size = new Size(249, 40);
            label16.TabIndex = 41;
            label16.Text = "Выберите вариант размера\r\nучастка из списка ниже:";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(308, 489);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(282, 28);
            comboBox5.TabIndex = 42;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(599, 443);
            label17.Name = "label17";
            label17.Size = new Size(259, 40);
            label17.TabIndex = 43;
            label17.Text = "Выберите доступное\r\nколичество этажей в доме:";
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(599, 489);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(282, 28);
            comboBox6.TabIndex = 44;
            // 
            // button15
            // 
            button15.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.ForeColor = Color.Black;
            button15.Location = new Point(307, 523);
            button15.Name = "button15";
            button15.Size = new Size(283, 57);
            button15.TabIndex = 45;
            button15.Text = "Расчитать сложность проекта";
            button15.UseVisualStyleBackColor = true;
            button15.Click += CalculateComplexityButton;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(307, 105);
            label9.Name = "label9";
            label9.Size = new Size(119, 40);
            label9.TabIndex = 47;
            label9.Text = "Информация\r\nо проекте:";
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(887, 523);
            button2.Name = "button2";
            button2.Size = new Size(215, 57);
            button2.TabIndex = 48;
            button2.Text = "Далее";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NextButton;
            // 
            // button8
            // 
            button8.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(887, 182);
            button8.Name = "button8";
            button8.Size = new Size(215, 57);
            button8.TabIndex = 61;
            button8.Text = "Чертеж";
            button8.UseVisualStyleBackColor = true;
            button8.Click += BluePrintButton;
            // 
            // button9
            // 
            button9.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(887, 442);
            button9.Name = "button9";
            button9.Size = new Size(215, 75);
            button9.TabIndex = 62;
            button9.Text = "Поставщик";
            button9.UseVisualStyleBackColor = true;
            button9.Click += SupplierButton;
            // 
            // button10
            // 
            button10.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(887, 362);
            button10.Name = "button10";
            button10.Size = new Size(215, 74);
            button10.TabIndex = 63;
            button10.Text = "Материал";
            button10.UseVisualStyleBackColor = true;
            button10.Click += MaterialButton;
            // 
            // comboBox7
            // 
            comboBox7.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(887, 148);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(215, 28);
            comboBox7.TabIndex = 64;
            // 
            // comboBox8
            // 
            comboBox8.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(887, 294);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(215, 28);
            comboBox8.TabIndex = 65;
            // 
            // comboBox9
            // 
            comboBox9.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(887, 328);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(215, 28);
            comboBox9.TabIndex = 66;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(887, 105);
            label10.Name = "label10";
            label10.Size = new Size(229, 40);
            label10.TabIndex = 67;
            label10.Text = "Выберите чертеж или \r\nопишите свой:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(887, 251);
            label11.Name = "label11";
            label11.Size = new Size(218, 40);
            label11.TabIndex = 68;
            label11.Text = "Выберите поставщика\r\nи продукт:";
            // 
            // Object1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1111, 588);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox9);
            Controls.Add(comboBox8);
            Controls.Add(comboBox7);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(richTextBox1);
            Controls.Add(textBox5);
            Controls.Add(comboBox4);
            Controls.Add(label8);
            Controls.Add(comboBox3);
            Controls.Add(button15);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox6);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label17);
            Controls.Add(comboBox5);
            Controls.Add(label5);
            Controls.Add(label16);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Button1);
            Controls.Add(panel1);
            Font = new Font("Courier New", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.MediumBlue;
            Name = "Object1";
            Text = "Строительная компания";
            Load += Object1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private Label label7;
        private Label label8;
        protected TextBox textBox5;
        protected ComboBox comboBox3;
        protected ComboBox comboBox2;
        protected ComboBox comboBox1;
        protected ComboBox comboBox4;
        protected RichTextBox richTextBox1;
        private Label label16;
        private ComboBox comboBox5;
        private Label label17;
        private ComboBox comboBox6;
        private Button button15;
        private Label label9;
        private Button button2;
        private Button button8;
        private Button button9;
        private Button button10;
        protected ComboBox comboBox7;
        protected ComboBox comboBox8;
        protected ComboBox comboBox9;
        private Label label10;
        private Label label11;
    }
}

