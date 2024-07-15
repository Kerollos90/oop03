using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Binding
{
    public class PartTimeEmp : Employee
    {

        public int CountOfHours { get; set; }   
        public decimal HourRate { get; set;}



        public new void getemptype() => Console.WriteLine("I am Part time emp");

        public override void getempData() => Console.WriteLine($"id = {Id} :: name = {Name} :: age = {Age} :: CountOfHours = {CountOfHours} :: HourRate = {HourRate} ");




    }
}
