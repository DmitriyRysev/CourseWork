// Агрегация.Объекты Supplier создаются за пределами ProjectWithSuppliers и передаются через метод AddSupplier.
// Жизненный цикл объектов Supplier не зависит от ProjectWithSuppliers. Они могут существовать независимо.

namespace ClassLibrary
{
    public class Supplier : ComplexityInfo
    {
        public string Name { get; set; }
        public string Product { get; set; }

        public ComplexityInfo? ComplexityInfo
        {
            get => default;
            set { }
        }

        public Supplier(string name, string product)
        {
            Name = name;
            Product = product;
        }
    }

    public class ProjectWithSuppliers : ComplexityInfo
    {
        public List<Supplier> Suppliers { get; private set; } = new List<Supplier>();

        //public Supplier? Supplier
        //{
        //    get => default;
        //    set { }
        //}

        public void AddSupplier(Supplier supplier)
        {
            Suppliers.Add(supplier);  // Слабая связь: объект передается извне
        }
    }
}
