using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Training
{
    public class Person: IDataErrorInfo
    {
        public int Id { get; set; }
        public string Name  { get; set; }

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Name))
                    return "Error";
                return null;
            }
        }

        public string Error { get; }
    }
}
