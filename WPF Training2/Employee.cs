using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Training2
{
    public class Employee
    {
        public Employee()
        {
            ID = 3;
            FirstName = "John";
        }

        public int ID { get; set; }
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public DateTime BirthDate  { get; set; }
    }
}
