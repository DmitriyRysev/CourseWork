using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
