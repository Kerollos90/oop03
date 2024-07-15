using OOP03.polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.polymorphism_overriding
{
    internal class TypeB :TypeA
    {
        public int B { get; set; }

        public TypeB(int a , int b) :base(a)
        {
            B = b;
        }

        //overriding
        //1 using new 
        //2 using overriding

        //new 
        public new void myfun01() => Console.WriteLine("i am derived");

        //overriding 
        public override void myfun02() => Console.WriteLine($"A = {A} :: B = {B}");

    }
}
