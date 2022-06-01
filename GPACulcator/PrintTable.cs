using System;
using System.Collections.Generic;
namespace GPACalculator
{
    internal class PrintTable
    {
        public void Table(Student student)
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t\t<<<<<<<< GPA CALCULATOR >>>>>>>>");
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|----------------------|");
            Console.WriteLine("\t\t|               |               |             |              |                |                      |");
            Console.WriteLine("\t\t|  COURSE CODE  |  COURSE UNIT  |    SCORE    |    GRADE     |   GRADE UNIT   |    Quality point     |");
            Console.WriteLine("\t\t|               |               |             |              |                |                      |");
            Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|----------------------|");
            foreach (KeyValuePair<string, Courses> Entry in student.CoursesDictionary)
            {
                Courses courseData = Entry.Value;
                if (Convert.ToInt16(courseData.QualityPoint) >= 10 && Convert.ToInt16(courseData.QualityPoint) < 100)
                {
                    Console.WriteLine("\t\t|               |               |             |              |                |              " +
                        "        |");
                    Console.WriteLine("\t\t|  " + courseData.CourseCode + "       |       " + courseData.CourseUnit + "       |     "
                        + courseData.Score + "   " +
                        "   |     " + courseData.Grade + "        |     " + courseData.GradeUnit + "          |           " + courseData.QualityPoint +
                        "         |");
                    Console.WriteLine("\t\t|               |               |             |              |                |                      |");
                    Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|----------------------|");
                }
                else
                {
                    Console.WriteLine("\t\t|               |               |             |              |                |                      |");
                    Console.WriteLine("\t\t|  " + courseData.CourseCode + "       |       " + courseData.CourseUnit + "       |     "
                        + courseData.Score + "  " +
                        "    |     " + courseData.Grade + "        |     " + courseData.GradeUnit + "          |      " + courseData.QualityPoint +
                        "               |");
                    Console.WriteLine("\t\t|               |               |             |              |                |                      |");
                    Console.WriteLine("\t\t|---------------|---------------|-------------|--------------|----------------|----------------------|");
                }
            }

        }
    }
}


