﻿using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
           // Classroom classroom = new Classroom();
            //double grade = classroom.TotalGrade();
            //Console.WriteLine("Total Grade: {0}", grade);

            School school = new School();
            double grade1 = school.TotalGrade();
            Console.WriteLine("Total Grade: {0}", grade1);
        }
    }
}
