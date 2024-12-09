namespace ClassLibrary
{
    public class Blueprint
    {
        public string Description { get; set; }

        public Blueprint(string description)
        {
            Description = description;
        }
    }

    public class ProjectWithBlueprint : ComplexityInfo
    {
        public Blueprint Blueprint { get; private set; }

        public ProjectWithBlueprint(int area, int floors, string description)
        {
            Area = area;
            Floors = floors;
            Blueprint = new Blueprint(description);
        }
    }
}
