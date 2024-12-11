// Композиция. Объект Blueprint создается внутри конструктора ProjectWithBlueprint, и его
// жизненный цикл полностью зависит от жизненного цикла объекта ProjectWithBlueprint.

// Если ProjectWithBlueprint будет удален, то и объект Blueprint будет удален вместе с ним.

namespace ClassLibrary
{
    public class Blueprint : ComplexityInfo
    {
        public string Description { get; set; }

        public ComplexityInfo? ComplexityInfo
        {
            get => default;
            set { }
        }

        public Blueprint(string description)
        {
            Description = description;
        }
    }

    public class ProjectWithBlueprint : ComplexityInfo
    {
        public Blueprint Blueprint;

        public ProjectWithBlueprint(int area, int floors, string description)
        {
            Area = area;
            Floors = floors;
            Blueprint = new Blueprint(description); // Полный контроль над объектом
        }

        //public Blueprint? Blueprint1
        //{
        //    get => default;
        //    set { }
        //}
    }
}
