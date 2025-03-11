namespace Question_2
{
    internal class School
    {
        private string schoolName;
        private string location;
        private Student[] students;
        private int student_count;

        public School(string name, string location, int Max_students)
        {
            this.schoolName = name;
            this.location = location;
            students = new Student[Max_students];
            student_count = 0;

        }
        public void AddStudent(Student student)
        {
            students[student_count] = student;
            student_count++;
        }
        public string GetName()
        {
            return schoolName;
        }
        public string GetLocation()
        {
            return location;
        }
        public Student[] GetStudent()
        {
            return students;
        }


    }
}
