using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Binding
{
    public class FullTimeEmp  : Employee
    {

        public decimal Salary { get; set; }


        public FullTimeEmp(int id, string name, int age ,decimal salary) : base(id, name, age)
        {
            Salary = salary;
        }
        public new void getemptype() => Console.WriteLine("I am Full time emp");

        public override void getempData() => Console.WriteLine($"id = {Id} :: name = {Name} :: age = {Age} :: Salary = {Salary}");

    }
}
