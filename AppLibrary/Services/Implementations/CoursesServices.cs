using AppLibrary.Services.DTOs;
using AppLibrary.Services.Interface;
using AppModel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AppLibrary.Services.Implementation
{
    publicclass CoursesServices : ICourses
    {
        public List<Course> GetCourses()
        {
            Console.WriteLine("Fetching users...");   // all users will be fetched
            Thread.Sleep(1000);

            //var courses = _coursesrRepo.SelectCourses();

            // return courses;
        }
        //Methods Related to Courses Class
        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(CourseName)) isValid = false;
            if (CourseUnit < 1) isValid = false;
            if (string.IsNullOrWhiteSpace(CourseCode)) isValid = false;
            if (CourseUnit < 0) isValid = false;

            return isValid;
        }

        public bool SaveCourse(Coursesdto nature)
        {
            var id = Guid.NewGuid().ToString();
            var user = new Course(id, nature.CourseName, nature.CourseCode, nature.CourseUnit);
            Console.WriteLine("Registering Courses ...");
            Thread.Sleep(1000);

            //if (_courseRepo.Add(user))
            //    return true;

            return true;
        }


    }
}
