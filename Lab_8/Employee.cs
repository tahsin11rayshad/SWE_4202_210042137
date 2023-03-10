using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal abstract class Employee
    {
        public string name;
        public int age;
        public double salary;

        public abstract void showEmployeeinfo();
    }
}
