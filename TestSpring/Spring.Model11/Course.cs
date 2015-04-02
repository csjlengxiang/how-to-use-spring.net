using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Model
{
    interface ICourse
    {
        void SK();
    }
    public class Course : ICourse
    {
        IList<Student> Students { get; set; }
        Teacher CourseTeacher { get; set; }

        public void SK()
        {
            Console.WriteLine("skl ");
            CourseTeacher.DoSomeThing();
            if (Students != null)
                foreach (Student student in Students)
                {
                    student.DoSomeThing();
                }
        }
    }
}
