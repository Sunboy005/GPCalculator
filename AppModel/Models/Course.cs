using System;
using System.Collections.Generic;
using System.Text;

namespace AppModel.Models
{
    public class Course
    {
        //Constructors
        public Course(string id, string courseName, int courseUnit, int courseScore, int gradePoint)
        {
            CourseId = id;
            CourseName = courseName;
            CourseUnit = courseUnit;
            CourseScore = courseScore;
            GradePoint = gradePoint;
        }
        //Properties Related to Courses Class
        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public int CourseUnit { get; set; }
        public int CourseScore { get; set; }
        public int GradePoint { get; set; }
    }
}
