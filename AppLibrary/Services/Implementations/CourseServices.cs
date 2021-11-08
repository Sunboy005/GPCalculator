using AppLibrary.Services.DTOs;
using AppLibrary.Services.Interfaces;
using AppModel.Models;
using System;

namespace AppLibrary.Services.Implementations
{
    public class CourseServices : ICourse
    {
        public bool Save(CoursesToAdd model)
        {
            var id = Guid.NewGuid().ToString();
            var course = new Course(id, model.CourseName, model.CourseUnit, model.CourseScore, model.GradePoint);

            return false;
        }

        public void ListCourses()
        {
            Console.WriteLine("Fetching Courses...");   // all users will be fetched
                                                        // Thread.Sleep(1000);
        }

    }
}
