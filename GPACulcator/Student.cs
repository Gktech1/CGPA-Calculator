using System;
using System.Collections.Generic;


namespace GPACalculator
{
    public class Student
    {
        public Dictionary<string, Courses> CoursesDictionary = new Dictionary<string, Courses>();

        public double TotalGradeUnit { get; set; }
        public double TotalCourseUnitPassed { get; set; }

        public double TotalQualityPoint { get; set; }
        public double GPA { get; set; }

        public void GPACalculator()
        {
            foreach (KeyValuePair<string, Courses> course in CoursesDictionary)
            {
                Courses eachCourse = course.Value;
                TotalGradeUnit += Convert.ToDouble(eachCourse.CourseUnit);
                TotalQualityPoint += Convert.ToDouble(eachCourse.QualityPoint);

                if (Convert.ToInt32(eachCourse.Score) > 39)
                {
                    TotalCourseUnitPassed += Convert.ToDouble(eachCourse.CourseUnit);
                }
            }

            GPA = TotalQualityPoint / TotalGradeUnit;
            GPA = Math.Round(GPA, 2);

        }
    }
}
