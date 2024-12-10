namespace ClassLibrary
{
    public class Supplier
    {
        public string Name { get; set; }
        public string Product { get; set; }

        public Supplier(string name, string product)
        {
            Name = name;
            Product = product;
        }
    }

    public class ProjectWithSuppliers : ComplexityInfo
    {
        public List<Supplier> Suppliers { get; private set; } = new List<Supplier>();

        public void AddSupplier(Supplier supplier)
        {
            Suppliers.Add(supplier);  // Слабая связь: объект передается извне
        }
    }
}
