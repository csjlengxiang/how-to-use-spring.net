
using Spring.Context;
using Spring.Context.Support;
using Spring.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpring
{
    class Program
    {
        static void Main(string[] args)
        {

            IApplicationContext ctx = ContextRegistry.GetContext();


            Teacher t = ctx.GetObject("teacher") as Teacher;

            t.DoSomeThing();


            Student s1 = ctx.GetObject("student1") as Student;
            s1.DoSomeThing();

            Student s2 = ctx.GetObject("student2") as Student;
            s2.DoSomeThing();


            Course course = ctx.GetObject("course") as Course;

            course.SK();

            Console.ReadKey();
        

            /*
            IApplicationContext ctx = ContextRegistry.GetContext();

            Teacher teacher = ctx.GetObject("teacher") as Teacher;
            teacher.DoSomeThing();

            Course course = ctx.GetObject("course") as Course;

            course.SK();
            */


            Console.ReadKey();
         }
    }
}
