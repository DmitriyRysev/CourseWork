using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Company : Home 
    {
        public string? Department;
        public string? Head;

        public Company() : base() { }

        public Company(string? department, string? head, string? city) : base(city)
        {
            Department = department;
            Head = head;
        }
    }
}
