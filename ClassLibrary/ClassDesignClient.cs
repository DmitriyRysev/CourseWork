namespace ClassLibrary
{
    abstract public class DesignCompanyClient
    {
        // Абстрактное свойство Name с проверкой инициалов
        public abstract string Name { get; set; }

        // Абстрактный метод NameText() для отображения имени
        public abstract string NameText();

        // Переопределение метода ToString
        public override string? ToString()
        {
            // Возвращаем базовый ToString(), если Name пустое, иначе — значение Name
            return string.IsNullOrEmpty(this.Name) || this.Name == "Ошибка в инициалах" ? base.ToString() : this.Name;
        }

        //Абстрактное свойство DateOfBirth, которое нужно реализовать в дочерних классах
        public abstract DateTime DateOfBirth { get; set; }
    }
}
