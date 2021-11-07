using System;
using System.Collections.Generic;
using System.Text;

namespace AppModel.Models
{
    public class Courses
    {
        //Constructors
        public Courses(string courseId, string courseName, string courseCode, int courseUnit)
        {
            CourseId = courseId;
            CourseName = courseName;
            CourseCode = courseCode;
            CourseUnit = courseUnit;
        }
        //Properties Related to Courses Class
        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }


        //Methods Related to Courses Class
        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(CourseName)) isValid = false;
            if (CourseUnit<1) isValid = false;
            if (string.IsNullOrWhiteSpace(CourseCode)) isValid = false;
            if (CourseUnit < 0) isValid = false;

            return isValid;
        }

    }
}
