namespace CourseWork
{
    partial class Object3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Object3));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button11 = new Button();
            pictureBox1 = new PictureBox();
            button10 = new Button();
            button9 = new Button();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 83);
            panel1.TabIndex = 62;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(134, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(526, 31);
            label1.TabIndex = 1;
            label1.Text = "Компания \"Уит\" - строим будущее!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(240, 20);
            label2.TabIndex = 37;
            label2.Text = "Номер вашего проекта:";
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(198, 225);
            button1.Name = "button1";
            button1.Size = new Size(181, 57);
            button1.TabIndex = 35;
            button1.Text = "Отменить заказ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RemoveButton;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(13, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 27);
            textBox1.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(198, 142);
            label3.Name = "label3";
            label3.Size = new Size(159, 80);
            label3.TabIndex = 39;
            label3.Text = "Вы также можете\r\nотменить заказ,\r\nесли передумали\r\nего оформлять";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 142);
            label4.Name = "label4";
            label4.Size = new Size(159, 80);
            label4.TabIndex = 38;
            label4.Text = "Нажмите на \r\nкнопку ниже,\r\nесли вы готовы \r\nоформить заказ";
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(13, 225);
            button2.Name = "button2";
            button2.Size = new Size(177, 57);
            button2.TabIndex = 34;
            button2.Text = "Оформить заказ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ProcessButton;
            // 
            // button11
            // 
            button11.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.Black;
            button11.Location = new Point(394, 354);
            button11.Name = "button11";
            button11.Size = new Size(367, 57);
            button11.TabIndex = 65;
            button11.Text = "Вывод";
            button11.UseVisualStyleBackColor = true;
            button11.Click += DisplayButton;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.шрифт2;
            pictureBox1.Location = new Point(395, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 199);
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // button10
            // 
            button10.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Black;
            button10.Location = new Point(581, 291);
            button10.Name = "button10";
            button10.Size = new Size(181, 57);
            button10.TabIndex = 64;
            button10.Text = "Цвет";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ColorButton;
            // 
            // button9
            // 
            button9.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(394, 291);
            button9.Name = "button9";
            button9.Size = new Size(181, 57);
            button9.TabIndex = 63;
            button9.Text = "Шрифт";
            button9.UseVisualStyleBackColor = true;
            button9.Click += FontButton;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(12, 291);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(367, 183);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(394, 417);
            button3.Name = "button3";
            button3.Size = new Size(368, 57);
            button3.TabIndex = 67;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BackButton;
            // 
            // Object3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(770, 485);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(button11);
            Controls.Add(pictureBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button2);
            Name = "Object3";
            Text = "Object3";
            Load += Object3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button11;
        private PictureBox pictureBox1;
        private Button button10;
        private Button button9;
        private RichTextBox richTextBox1;
        private Button button3;
    }
}