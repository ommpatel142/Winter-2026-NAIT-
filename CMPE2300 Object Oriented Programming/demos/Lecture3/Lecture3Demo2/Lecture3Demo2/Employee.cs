using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Demo2
{
    internal class Employee
    {

        public string FullName
        {
            get;
            set;
        } 

        //We'll use the property directly in our constructor
        public Employee(string name)
        {
            FullName = name;
        }

        //Leveraging the one-parameter constructor to create the default constructor
        public Employee():this("Om Patel")
        {

        }
    }
}
