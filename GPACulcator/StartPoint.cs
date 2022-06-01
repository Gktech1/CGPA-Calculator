using System;
using System.Collections.Generic;
namespace GPACalculator
{
    public class StartPoint
    {
        public void Start()
        {
            Validation validation = new Validation();
            Student student = new Student();
            PrintTable print = new PrintTable();
            List<string> list = new List<string>();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WELCOME!");
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("\n\n\t\t\t<<<<<<<< GPA CALCULATOR >>>>>>>>");
            while (true)
            {

                //USER ENTER COURSE NAME & COURSE CODE, COURSE UNIT AND SCORE
                Console.Write("\nEnter Course Code : ");
                String courseCode = Console.ReadLine();

                while (!validation.CourseCode(courseCode))
                {
                    Console.WriteLine("\nCourse code must be 6 characters");
                    Console.WriteLine("\nCourse code must contain three letters and three digits");
                    Console.Write("\nEnter course code: ");
                    courseCode = Console.ReadLine();
                    Console.Clear();
                }
                Console.Write("\nEnter Course Unit : ");
                String courseUnit = Console.ReadLine();
                string validatedCourseUnit = validation.ValidateCourseUnit(courseUnit);
                Console.Write("\nEnter Score : ");
                String score = Console.ReadLine();
                string validatedScore = validation.ValidateGradeUnit(score);

                //CREATE A COURSE OBJECT AND SAVE USER INPUT 
                Courses course = new Courses();
                course.Calculate(courseCode, validatedCourseUnit, validatedScore);

                //STORE ALL COURSES INTO A DICTIONARY IN THE STUDENT OBJECT 
                student.CoursesDictionary.Add(courseCode, course);
                print.Table(student);

                Console.WriteLine("\nType \"1\" to add courses or \" 2\" to calucalte GPA:");
                string command = Console.ReadLine();
                if (command.ToLower() == "2")
                {

                    break;
                }

                student.GPACalculator();
                Console.WriteLine("\n\n\t\tTotal Course Unit Registered: " + student.TotalGradeUnit);
                Console.WriteLine("\n\t\tTotal Course Unit Passed:     " + student.TotalCourseUnitPassed);
                Console.WriteLine("\n\t\tTotal Course Weight Point:    " + student.TotalQualityPoint);
                Console.WriteLine("\n\t\tGPA:                          " + student.GPA);
                Console.Clear();

            }
            Console.Clear();
            print.Table(student);
            student.GPACalculator();
            Console.WriteLine("\n\n\t\tTotal Course Unit Registered: " + student.TotalGradeUnit);
            Console.WriteLine("\n\t\tTotal Course Unit Passed:     " + student.TotalCourseUnitPassed);
            Console.WriteLine("\n\t\tTotal Course Weight Point:    " + student.TotalQualityPoint);
            Console.WriteLine("\n\t\tGPA:                          " + student.GPA);



        }
    }
}