using System;
using System.Collections.Generic;
using System.Text;

namespace AppLibrary.Services.DTOs
{
    public class CoursesToAdd
    {
        public string CourseName { get; set; }
     
        public int CourseUnit { get; set; }
        public int CourseScore { get; set; }
        public int GradePoint { get; set; }

    }
}
