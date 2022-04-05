namespace Grades
{
    internal class Student
    {
        public Examen[] Exams { get; set; }

        public Student()
        {
            Exams = new Examen[]
            {
               new Examen{Name= "Graphika"},
               new Examen{Name = "OOP"},
               new Examen{Name = "Art"}
            };
        }

        public double TotalGrade()
        {
            double sum = 0;
           // for (int i = 0; i < Exams.Length; i++)
            //{
              //  sum = sum + Exams[i].Grade;
            //}

            foreach(var examen in Exams)
            {
                sum = sum + examen.Grade;
            } 
            return sum;
        }
        public void SetGrade(int index, double Grade)
        {
            Exams[index].Grade = Grade;
        }
    }
}
