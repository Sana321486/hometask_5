using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Teacher
    {
        private int Teacher_ID;
        private string Teacher_Name;
        private string Subject;

        public Teacher(int ID,string name,string subject)
        {
            this.Teacher_ID = ID;
            this.Teacher_Name = name;
            this.Subject = subject;
        }
         public void AssignGrade(Student std,int Grade)
        {
            std.setGrade(Grade);
        }
        public int getTeacher_ID() { return Teacher_ID; }
        public string getTeacher_Name() { return Teacher_Name; }
        public string getSubject() { return Subject; }

    }
}
