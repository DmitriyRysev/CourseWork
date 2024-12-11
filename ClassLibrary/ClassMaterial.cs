// Ассоциация. Material — это объекты, на которые ProjectWithMaterials ссылается. Жизненный цикл объектов Material
// не зависит от ProjectWithMaterials. Материалы можно добавить или удалить, они могут использоваться где-либо еще.

namespace ClassLibrary
{
    public class Material : ComplexityInfo
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public ComplexityInfo? ComplexityInfo
        {
            get => default;
            set
            {
            }
        }

        public Material(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }

    public static class MaterialCatalog
    {
        public static readonly List<Material> Materials = new List<Material>
        {
             new Material("Дуб", 5990),
            new Material("Береза", 3990),
            new Material("Ель", 2990),
            new Material("Дерево", 7990),
            new Material("Пластик", 3990),
            new Material("Металл", 6990),
            new Material("Черепица", 29990),
            new Material("Кирпичи", 27990),
            new Material("Шифер", 25990)
        };

        public static Material? FindMaterialByName(string name)
        {
            return Materials.FirstOrDefault(m => m.Name == name);
        }
    }

    public class ProjectWithMaterials : ComplexityInfo
    {
        private readonly List<Material> Materials; // Связь с объектами материала.

        public ProjectWithMaterials()
        {
            Materials = new List<Material>();
        }

        //public Material? Material
        //{
        //    get => default;
        //    set { }
        //}

        public void AddMaterial(Material material)
        {
            Materials.Add(material);
        }

        public double GetTotalMaterialCost()
        {
            return Materials.Sum(m => m.Cost);
        }
    }
}