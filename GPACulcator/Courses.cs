using System;
using System.Collections.Generic;


namespace GPACalculator
{

    public class Courses
    {


        public string CourseCode { get; set; }
        public string CourseUnit { get; set; }
        public string Score { get; set; }
        public string Grade { get; set; }
        public string GradeUnit { get; set; }
        public string QualityPoint { get; set; }
        public string Remark { get; set; }

        public void Calculate(string CousreCode, string CourseUnit, string Score)
        {
            this.CourseCode = CousreCode;
            this.CourseUnit = CourseUnit;
            this.Score = Score;
            int score = Convert.ToInt32(Score);
            if (score >= 75)
            {
                Remark = "EXCELLENT";
                Grade = "A";
                GradeUnit = "5";

            }
            else if (score >= 60 && score <= 69)
            {
                Remark = "Very Good";
                Grade = "B";
                GradeUnit = "4";
            }
            else if (score >= 50 && score <= 59)
            {
                Remark = "  Good   ";
                Grade = "c";
                GradeUnit = "3";

            }
            else if (score >= 45 && score <= 49)
            {
                Remark = "  Fair   ";
                Grade = "D";
                GradeUnit = "2";

            }
            else if (score >= 40 && score <= 44)
            {
                Remark = "  Pass   ";
                Grade = "E";
                GradeUnit = "1";

            }
            else if (score >= 0 && score <= 39)
            {
                Remark = "  Fail   ";
                Grade = "F";
                GradeUnit = "0";

            }

            int gradeUnit = Convert.ToInt32(GradeUnit);
            int courseUnit = Convert.ToInt32(CourseUnit);
            QualityPoint = Convert.ToString(courseUnit * gradeUnit);
        }


    }
}
