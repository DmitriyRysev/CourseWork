namespace CourseWork
{
    partial class Object2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Object2));
            label9 = new Label();
            label10 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            richTextBox2 = new RichTextBox();
            textBox7 = new TextBox();
            button14 = new Button();
            button7 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label12 = new Label();
            textBox6 = new TextBox();
            label11 = new Label();
            button8 = new Button();
            richTextBox3 = new RichTextBox();
            panel1 = new Panel();
            label1 = new Label();
            button16 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(11, 84);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(219, 20);
            label9.TabIndex = 45;
            label9.Text = "Ваш город проживания:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(11, 143);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(239, 40);
            label10.TabIndex = 46;
            label10.Text = "Выберите начальника в \r\nближайшем к вам отделе:";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(11, 185);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 84);
            listBox1.TabIndex = 47;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(172, 185);
            listBox2.Margin = new Padding(2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 84);
            listBox2.TabIndex = 48;
            // 
            // button5
            // 
            button5.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(11, 273);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(150, 50);
            button5.TabIndex = 49;
            button5.Text = "Применить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += RecordButton;
            // 
            // button6
            // 
            button6.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(172, 273);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(150, 50);
            button6.TabIndex = 50;
            button6.Text = "Проверить данные";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ReadButton;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.Location = new Point(11, 331);
            richTextBox2.Margin = new Padding(2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(311, 189);
            richTextBox2.TabIndex = 51;
            richTextBox2.Text = "";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(11, 106);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(311, 27);
            textBox7.TabIndex = 44;
            // 
            // button14
            // 
            button14.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.ForeColor = Color.Black;
            button14.Location = new Point(336, 191);
            button14.Margin = new Padding(2);
            button14.Name = "button14";
            button14.Size = new Size(311, 50);
            button14.TabIndex = 52;
            button14.Text = "Индексаторы";
            button14.UseVisualStyleBackColor = true;
            button14.Click += IndexButton;
            // 
            // button7
            // 
            button7.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(336, 137);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(311, 50);
            button7.TabIndex = 55;
            button7.Text = "Проверить инициалы";
            button7.UseVisualStyleBackColor = true;
            button7.Click += InitialsButton;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(336, 269);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(311, 26);
            dateTimePicker2.TabIndex = 60;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(336, 247);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(309, 20);
            label12.TabIndex = 59;
            label12.Text = "Выберите дату вашего рождения:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(336, 106);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(311, 27);
            textBox6.TabIndex = 58;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(336, 84);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(279, 20);
            label11.TabIndex = 57;
            label11.Text = "Введите фамилию и инициалы:";
            // 
            // button8
            // 
            button8.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(336, 299);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(311, 50);
            button8.TabIndex = 56;
            button8.Text = "Вывод информации";
            button8.UseVisualStyleBackColor = true;
            button8.Click += InfoButton;
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox3.Location = new Point(336, 353);
            richTextBox3.Margin = new Padding(2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(309, 112);
            richTextBox3.TabIndex = 54;
            richTextBox3.Text = "";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 73);
            panel1.TabIndex = 61;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(83, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(526, 31);
            label1.TabIndex = 1;
            label1.Text = "Компания \"Уит\" - строим будущее!";
            // 
            // button16
            // 
            button16.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button16.ForeColor = Color.Black;
            button16.Location = new Point(493, 470);
            button16.Name = "button16";
            button16.Size = new Size(152, 50);
            button16.TabIndex = 62;
            button16.Text = "Далее";
            button16.UseVisualStyleBackColor = true;
            button16.Click += NextButton;
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(336, 471);
            button1.Name = "button1";
            button1.Size = new Size(152, 50);
            button1.TabIndex = 63;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BackButton;
            // 
            // Object2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(662, 533);
            Controls.Add(button1);
            Controls.Add(button16);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label10);
            Controls.Add(textBox7);
            Controls.Add(button8);
            Controls.Add(label9);
            Controls.Add(button14);
            Controls.Add(button7);
            Controls.Add(textBox6);
            Controls.Add(button6);
            Controls.Add(dateTimePicker2);
            Controls.Add(richTextBox2);
            Controls.Add(button5);
            Controls.Add(richTextBox3);
            Controls.Add(label12);
            Controls.Add(panel1);
            Controls.Add(label11);
            Margin = new Padding(2);
            Name = "Object2";
            Text = "Дизайн компания";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label10;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button5;
        private Button button6;
        private RichTextBox richTextBox2;
        private TextBox textBox7;
        private Button button14;
        private Button button7;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private TextBox textBox6;
        private Label label11;
        private Button button8;
        private RichTextBox richTextBox3;
        private Panel panel1;
        private Label label1;
        private Button button16;
        private Button button1;
    }
}