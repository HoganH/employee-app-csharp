using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Kennedy");
            
            System.Console.WriteLine( employee.ToString());

            employee = new Employee("James", "X", "Kirk");
            System.Console.WriteLine(employee.MiddleName);

            System.Console.ReadKey();
        }
    }
}
