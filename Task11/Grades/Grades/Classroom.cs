namespace Grades
{
    internal class Classroom
    {
        public Student[] Students { get; set; }

        public Classroom()
        {
            var studend = new Student();
            studend.SetGrade(0, 5);
            studend.SetGrade(1, 3);
            studend.SetGrade(2, 4);

            var student1 = new Student();
            student1.SetGrade(0, 3);
            student1.SetGrade(1, 5);
            student1.SetGrade(2, 5);

            var student2 = new Student();
            student2.SetGrade(0, 4);
            student2.SetGrade(1, 5);
            student2.SetGrade(2, 5);

            Students = new Student[]
            {
                studend,
                student1,
                student2
            };
        }

        public double TotalGrade()
        {
            double sum = 0;

            //for (int i = 0; i < Students.Length; i++)
            //{
            //  sum = sum + Students[i].TotalGrade();
            //}

            foreach (var student in Students)
            {
                sum = sum + student.TotalGrade();
            }
            return sum;
        }
    }
}
