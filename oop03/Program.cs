using OOP03.Binding;
using OOP03.polymorphism;
using OOP03.polymorphism_overriding;

namespace OOP03
{
    internal class Program
    {
        #region Overloading
        //public static int Sum(int x, int y)
        //{
        //    return x + y;
        //}

        //public static double Sum(double x, double y)
        //{
        //    return x + y;
        //}

        //public static double Sum(double x, int y)
        //{
        //    return x + y;
        //} 
        #endregion

        public static void Processemp(Employee emp)
        { 
         if (emp != null) 
         {
             emp.getemptype();
             emp.getempData();   
          
         
         }
        }

       

        static void Main(string[] args)
        {
            #region Polymorphism

            #region overloading
            //int result = Sum(55, 45);
            //Console.WriteLine(result);

            //double result1 = Sum(5.5, 45);
            //Console.WriteLine(result1);

            //double result2 = Sum(5.5, 4.25);
            //Console.WriteLine(result2);
            #endregion

            #region overriding
            // Supported with class only
            //TypeA typeA = new TypeA(1);
            //typeA.A = 10;
            //typeA.myfun01();
            //typeA.myfun02();

            //Console.WriteLine();

            //TypeB typeB = new TypeB(2,10);

            //typeB.myfun01();
            //typeB.myfun02();




            #endregion

            #region Binding

            //TypeA refbase = new TypeB(10, 20);
            //refbase.myfun01();
            //refbase.myfun02();



            #endregion

            #region not binding

            //  TypeB childref =(TypeB) new TypeA(1); //invalid
            // TypeA typeA = new TypeA(1);
            // TypeB typeB = (TypeB) typeA;
            //
            // Console.WriteLine(typeA.A);
            // Console.WriteLine(typeB.B);

            //TypeA typeA = new TypeB(1, 2); //valid
            //TypeB typeB = (TypeB) typeA;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            #endregion

            #region EX1
            // FullTimeEmp fullTimeEmp = new FullTimeEmp(20,"Kerollos",20,5000);
            // Processemp(fullTimeEmp);

            // PartTimeEmp partTimeEmp = new PartTimeEmp()
            // {
            //     Id = 1,
            //     Name = "Test",
            //     Age = 2,
            //     HourRate = 3,
            //     CountOfHours = 4



            // };
            // Processemp(partTimeEmp);
            // //partTimeEmp.Id = 20;
            //// partTimeEmp.Name = "kerollos";
            //// partTimeEmp.Age = 30;    
            #endregion

            #region EX2


            TypeA typeA = new TypeC(1,2,3); 
            typeA.A = 10;
            typeA.myfun01();
            typeA.myfun02();

            Console.WriteLine();
            TypeB typec = new TypeC(1, 2,3);
            typeA.A = 10;
            typec.myfun01();
            typec.myfun02();


            Console.WriteLine();
            TypeC typeC = new TypeC(1, 2, 3);
            typeA.A = 10;
            typeC.myfun01();
            typeC.myfun02();






            #endregion








            #endregion


        }

    }
} 
