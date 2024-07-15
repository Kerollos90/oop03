using OOP03.polymorphism_overriding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Binding
{
    internal class TypeC :TypeB
    {
        public int C {  get; set; }
        public TypeC(int a ,int b,int c) : base(a,b)
        {
            C = c; 
        }


        public new void myfun01() => Console.WriteLine("i am derived{Grand Child}");

        public  override void myfun02() => Console.WriteLine($"A = {A} :: B = {B} :: C = {C}");



    }
}
