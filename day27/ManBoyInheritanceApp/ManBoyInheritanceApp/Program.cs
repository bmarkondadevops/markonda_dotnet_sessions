using ManBoyInheritanceApp.Models;
using System;
using System.Net.Http.Headers;

namespace ManBoyInheritanceApp
{


    struct Point { 
    
        public int x;
        public int y;
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //  CaseStudy1();

            //CaseStudy2();

            //CaseStudy3();

            //CaseStudy4();

            CaseStudy5();

            //CaseStudy6();



          //  Man x = new Man();
            Console.WriteLine(new Man());


        }

        private static void CaseStudy6()
        {
            Point p1 = new Point(); //VAlueType Inheritance
            p1.x = 10;
            p1.y = 20;

            Point p2 = p1;//create copy in stack
            p2.x = 100;

            Console.WriteLine(p2.x);
            Console.WriteLine(p1.x);

            int no1 = 100;
            int no2 = no1;

        }

        private static void CaseStudy5()
        {
            Object box;
            //box = "Hello";
            //Console.WriteLine(box.GetType());
            //box = 100; //boxing
            //Console.WriteLine(box.GetType());
            //int result =(int) box ;
            //result++;
            //Console.WriteLine(result);

            box = new Boy();
            Console.WriteLine(box.GetType());
            var boy = (Boy) box; //unboxing
            boy.Play();


        }

        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Infant());
            AtThePark(new Toddler());


        }

        private static void AtThePark(Man x) //polymorphic method
        {
            Console.WriteLine("At the park!!");
            x.Play();

        }

        private static void CaseStudy3()
        {

              Man x;// x expects (ISA a typeof Man)
              x = new Boy();
              x.Play();
              x.Read();
        }

        private static void CaseStudy2()
        {
           var boy= new Boy();
            boy.Read();
            boy.Eat();
            boy.Play();//who plays??
        }

        private static void CaseStudy1()
        {
            Man x;// x expects a Man type
            x= new Man();
            x.Play();
            x.Read();
        }
    }
}
