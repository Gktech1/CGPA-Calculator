using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GPACalculator
{
    public class Validation
    {
        public string Command(string command)
        {
            while (true)
            {
                if (command == "1")
                {
                    break;
                }
                else if (command == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid Command, enter \"1\" to add courses or \" 2\" to calucalte GPA: ");
                    command = Console.ReadLine();
                }
            }
            return command;
        }

        public bool CourseCode(string code)
        {
            code = code.Trim();
            Regex rgx = new Regex("^[a-zA-Z]{3}[1-9]{1}[0-9]{2}$");
            return (rgx.IsMatch(code));

        }


        public string ValidateGradeUnit(string grade)
        {
            grade = grade.Trim();

            int number;
            while (true)
            {
                if (int.TryParse(grade, out number))
                {
                    if (Convert.ToInt32(grade) >= 0 && Convert.ToInt32(grade) <= 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("\nInvalid score, score must be between 0 - 100: ");
                        grade = Console.ReadLine();
                    }

                }
                else
                {
                    Console.Write("\nInvalid score, score must be a number: ");
                    grade = Console.ReadLine();
                }

            }
            return number.ToString();
        }

        public string ValidateCourseUnit(string courseUnit)
        {
            courseUnit = courseUnit.Trim();
            int number;
            while (true)
            {
                if (int.TryParse(courseUnit, out number))
                {
                    if (Convert.ToInt32(courseUnit) >= 0 && Convert.ToInt32(courseUnit) <= 5)
                    {

                        break;
                    }
                    else
                    {
                        Console.Write("\nInvalid grade unit, grade unit must be between 0 - 5: ");
                        courseUnit = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("\nInvalid grade unit, course unit must be a number: ");
                    courseUnit = Console.ReadLine();
                }


            }
            return number.ToString();
        }
    }
}
