using System.Drawing;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace ClassLibrary
{
    // Изолированный класс (нельзя расширить путем наследования)
    public sealed class Client : Company
    {
        private string? name;
        private string? num;

        // Реализация свойства Name с проверкой корректности инициалов
        public override string Name
        {
            get => string.IsNullOrEmpty(name) ? "Ошибка в инициалах" : name;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Contains('.'))
                {
                    name = value;
                }
                else
                {
                    name = string.Empty;
                }
            }
        }

        // Свойство для номера телефона
        public new string? Num
        {
            get => num;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 11)
                    num = value;
                else
                    num = "0";
            }
        }

        public Client() { }
        public Client(string fio, string phoneNumber)
        {
            this.Name = fio;
            this.Num = phoneNumber;
        }

        [SupportedOSPlatform("windows")]
        public void NameText(PictureBox box, Font font, Color color)
        {
            // Очистка предыдущего изображения
            box.Image = null;

            // Создаем новое изображение и графику
            Bitmap bmp = new Bitmap(box.Width, box.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Выравниваем текст по центру PictureBox
                SizeF textSize = g.MeasureString(this.Name, font);
                float x = (box.Width - textSize.Width) / 2;
                float y = (box.Height - textSize.Height) / 2;

                using (Brush brush = new SolidBrush(color))
                {
                    g.DrawString(this.Name, font, brush, x, y);
                }
            }

            // Устанавливаем изображение в PictureBox
            box.Image = bmp;
        }


        // Реализуем абстрактный метод NameText()
        public override string NameText()
        {
            return $"Клиент: {Name}\n Дата рождения: {DateOfBirth.ToShortDateString()}";
        }

        //// Метод NameText для отображения текста в RichTextBox с заданными шрифтом и цветом
        //public void NameText(RichTextBox box, Font selectedFont, Color selectedColor)
        //{
        //    // Очищаем текст и добавляем строку с выбранным шрифтом и цветом
        //    box.Clear();
        //    box.SelectionFont = selectedFont;
        //    box.SelectionColor = selectedColor;
        //    box.AppendText(this.Name);
        //}

        // Переопределение метода ToString
        public override string? ToString()
        {
            return string.IsNullOrEmpty(this.Name) || this.Name == "Ошибка в инициалах" ? base.ToString() : this.Name;
        }

        // Свойство для даты рождения
        public override DateTime DateOfBirth { get; set; }

        // Реализация метода NameText с отображением имени и телефона
        //public void NameText(PictureBox box, FontDialog fontDialog, ColorDialog colorDialog)
        //{

        //    // Настройка выбора шрифта и цвета
        //    if (fontDialog.ShowDialog() == DialogResult.OK && colorDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        Graphics g = box.CreateGraphics();
        //        using (Font font = fontDialog.Font)
        //        using (Brush brush = new SolidBrush(colorDialog.Color))
        //        {
        //            g.DrawString(this.Name, font, brush, 1, 1);
        //        }
        //    }
        //}
    }
}
