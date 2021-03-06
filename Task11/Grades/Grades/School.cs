namespace Grades
{
    internal class School
    {
        public Classroom[] Classrooms { get; set; }
        public School()
        {
            Classrooms = new Classroom[]
            {
                new Classroom(),
                new Classroom(),
                new Classroom()
            };
        }

        public double TotalGrade()
        {
            double sum = 0;

            // for (int i = 0; i <Classrooms.Length ; i++)
            // {
            //    sum = sum + Classrooms[i].TotalGrade();
            //}

            foreach (var classroom in Classrooms)
            {
                sum = sum + classroom.TotalGrade();
            }
            return sum;
        }
    }
}
