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
            textBox5 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
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
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.Size = new Size(623, 36);
            label1.TabIndex = 0;
            label1.Text = "Компания \"Уит\" - строим будущее!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 351);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод и редактирование";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 314);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(264, 30);
            textBox5.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(6, 291);
            label8.Name = "label8";
            label8.Size = new Size(174, 20);
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
            label7.Size = new Size(141, 20);
            label7.TabIndex = 12;
            label7.Text = "Тип проекта:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 30);
            textBox4.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(6, 202);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 30);
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
            label6.Size = new Size(229, 20);
            label6.TabIndex = 9;
            label6.Text = "Дата создания заявки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(6, 147);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Крыша";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 106);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
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
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Двери";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 30);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 30);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 30);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(196, 40);
            label2.TabIndex = 2;
            label2.Text = "Введите желаемые \r\nкомпоненты дома:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(296, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(476, 351);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Просмотр";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(464, 322);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Button1
            // 
            Button1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.ForeColor = Color.Black;
            Button1.Location = new Point(12, 462);
            Button1.Name = "Button1";
            Button1.Size = new Size(135, 63);
            Button1.TabIndex = 10;
            Button1.Text = "Прочитать";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += read_button;
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(155, 462);
            button2.Name = "button2";
            button2.Size = new Size(135, 63);
            button2.TabIndex = 11;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += clear_button;
            // 
            // button3
            // 
            button3.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(302, 462);
            button3.Name = "button3";
            button3.Size = new Size(229, 63);
            button3.TabIndex = 12;
            button3.Text = "Получить хэш-код";
            button3.UseVisualStyleBackColor = true;
            button3.Click += hash_button;
            // 
            // button4
            // 
            button4.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(537, 462);
            button4.Name = "button4";
            button4.Size = new Size(229, 63);
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
            label9.Size = new Size(214, 23);
            label9.TabIndex = 15;
            label9.Text = "Город проживания:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(881, 164);
            label10.Name = "label10";
            label10.Size = new Size(154, 22);
            label10.TabIndex = 16;
            label10.Text = "СПРАВОЧНИКИ:";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(778, 189);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 119);
            listBox1.TabIndex = 17;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 23;
            listBox2.Location = new Point(965, 189);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 119);
            listBox2.TabIndex = 18;
            // 
            // button5
            // 
            button5.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(778, 314);
            button5.Name = "button5";
            button5.Size = new Size(180, 45);
            button5.TabIndex = 19;
            button5.Text = "Запись";
            button5.UseVisualStyleBackColor = true;
            button5.Click += RecordButton;
            // 
            // button6
            // 
            button6.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(964, 314);
            button6.Name = "button6";
            button6.Size = new Size(181, 45);
            button6.TabIndex = 20;
            button6.Text = "Чтение";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ReadButton;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.Location = new Point(778, 365);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(367, 160);
            richTextBox2.TabIndex = 21;
            richTextBox2.Text = "";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(778, 131);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(366, 30);
            textBox7.TabIndex = 4;
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox3.Location = new Point(12, 731);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(364, 194);
            richTextBox3.TabIndex = 1;
            richTextBox3.Text = "";
            // 
            // button7
            // 
            button7.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(12, 669);
            button7.Name = "button7";
            button7.Size = new Size(178, 56);
            button7.TabIndex = 22;
            button7.Text = "Инициалы";
            button7.UseVisualStyleBackColor = true;
            button7.Click += InitialsButton;
            // 
            // button8
            // 
            button8.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(196, 669);
            button8.Name = "button8";
            button8.Size = new Size(180, 56);
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
            label11.Location = new Point(12, 548);
            label11.Name = "label11";
            label11.Size = new Size(334, 23);
            label11.TabIndex = 24;
            label11.Text = "Введите фамилию и инициалы:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(12, 574);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(364, 30);
            textBox6.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Courier New", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(12, 607);
            label12.Name = "label12";
            label12.Size = new Size(370, 23);
            label12.TabIndex = 26;
            label12.Text = "Выберите дату вашего рождения:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(12, 633);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(364, 30);
            dateTimePicker2.TabIndex = 27;
            // 
            // button9
            // 
            button9.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(388, 807);
            button9.Name = "button9";
            button9.Size = new Size(185, 56);
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
            button10.Size = new Size(185, 56);
            button10.TabIndex = 30;
            button10.Text = "Цвет";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ColorButton;
            // 
            // button11
            // 
            button11.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(388, 869);
            button11.Name = "button11";
            button11.Size = new Size(378, 56);
            button11.TabIndex = 31;
            button11.Text = "Вывод";
            button11.UseVisualStyleBackColor = true;
            button11.Click += DisplayButton;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.шрифт2;
            pictureBox1.Location = new Point(388, 548);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 253);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.PanelPoster1;
            panel2.Location = new Point(778, 548);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 377);
            panel2.TabIndex = 33;
            // 
            // Object1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 935);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(dateTimePicker2);
            Controls.Add(label12);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(button8);
            Controls.Add(button7);
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
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private TextBox textBox4;
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
    }
}

