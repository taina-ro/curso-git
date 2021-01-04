using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TESTE
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            salary += salary * percentage / 100.0;
        }
        public override string ToString()
        {
            return id
                + ", "
                + name
                + ", "
                + salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
