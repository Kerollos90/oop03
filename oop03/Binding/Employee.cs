using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Binding
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Employee()
        {
            
        }

        public void getemptype() => Console.WriteLine("I am emp");

        public virtual void getempData() => Console.WriteLine($"id = {Id} :: name = {Name} :: age = {Age}");

    }
}
