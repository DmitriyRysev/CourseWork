namespace ClassLibrary
{
    public class ProjectEventArgs : EventArgs
    {
        public int ProjectNumber { get; }

        public ProjectEventArgs(int projectNumber)
        {
            ProjectNumber = projectNumber;
        }
    }
}
