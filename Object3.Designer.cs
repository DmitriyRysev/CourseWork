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
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(704, 83);
            panel1.TabIndex = 62;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(95, 26);
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
            label2.Location = new Point(11, 92);
            label2.Name = "label2";
            label2.Size = new Size(240, 20);
            label2.TabIndex = 37;
            label2.Text = "Номер вашего проекта:";
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(176, 231);
            button1.Name = "button1";
            button1.Size = new Size(159, 52);
            button1.TabIndex = 35;
            button1.Text = "Отменить заказ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RemoveButton;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(11, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 27);
            textBox1.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(176, 148);
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
            label4.Location = new Point(11, 148);
            label4.Name = "label4";
            label4.Size = new Size(159, 80);
            label4.TabIndex = 38;
            label4.Text = "Нажмите на \r\nкнопку ниже,\r\nесли вы готовы \r\nоформить заказ";
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(11, 231);
            button2.Name = "button2";
            button2.Size = new Size(159, 52);
            button2.TabIndex = 34;
            button2.Text = "Оформить заказ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ProcessButton;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(354, 92);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(327, 249);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(11, 289);
            button3.Name = "button3";
            button3.Size = new Size(324, 52);
            button3.TabIndex = 63;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BackButton;
            // 
            // Object3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(695, 355);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button2);
            Name = "Object3";
            Text = "Дизайн компания";
            Load += Object3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private RichTextBox richTextBox1;
        private Button button3;
    }
}