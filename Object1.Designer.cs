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
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.BackgroundImage = Properties.Resources.город;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 28);
            label1.Name = "label1";
            label1.Size = new Size(623, 36);
            label1.TabIndex = 0;
            label1.Text = "Компания \"Уит\" - строим будущее!";
            label1.Click += label2_Click;
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
            textBox5.TextChanged += textBox5_TextChanged;
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
            label8.Click += label8_Click;
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
            label7.Click += label7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 30);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
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
            label6.Click += label6_Click;
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
            label5.Click += label5_Click;
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
            label4.Click += label4_Click;
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
            button3.Location = new Point(296, 462);
            button3.Name = "button3";
            button3.Size = new Size(231, 63);
            button3.TabIndex = 12;
            button3.Text = "Получить хэш-код";
            button3.UseVisualStyleBackColor = true;
            button3.Click += hash_button;
            // 
            // button4
            // 
            button4.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(541, 462);
            button4.Name = "button4";
            button4.Size = new Size(231, 63);
            button4.TabIndex = 13;
            button4.Text = "Новый проект";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new_proj_button;
            // 
            // Object1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(785, 544);
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
    }
}

