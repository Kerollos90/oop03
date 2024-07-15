using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.polymorphism
{
    internal class TypeA
    {
        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }

        public void myfun01() => Console.WriteLine("i am base");

        public virtual void myfun02() => Console.WriteLine($"Type A {A}");



    }
}
