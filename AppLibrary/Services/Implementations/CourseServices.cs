using AppLibrary.Services.DTOs;
using AppModel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AppLibrary.Services.Implementations
{
    public class CourseServices
    {
        public bool Save(CoursesToAdd  model)
        {
            var id=  Guid.NewGuid().ToString();
            var course = new Course(id, model.CourseName, model.CourseCode, model.CourseUnit);

            return false;
        }

        public void ListCourses()
        {
            Console.WriteLine("Fetching Courses...");   // all users will be fetched
            Thread.Sleep(1000);

        }

    }
}
