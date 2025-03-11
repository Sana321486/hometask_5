using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Student
    {
        private int student_ID;
        private string name;
        private int[] grades;
        private int grade_count;

        public Student(int ID, string name)
        {
            this.student_ID = ID;
            this.name = name;
            grades = new int[5];
            grade_count = 0;
        }
        public void setGrade(int grade)
        {
            grades[grade_count] = grade;
            grade_count++;
        }
        public double CalculateAverageGrade()
        {
            if (grade_count == 0) 
            {
                return 0; 
            }
            double sum = 0;
            for (int i = 0; i < grade_count; i++)
            {
                sum += grades[i];
            }
                return sum / grade_count;
            
        }
            public int getstudentID() {  return student_ID; }
        public string getName() { return name; }
    }
}
