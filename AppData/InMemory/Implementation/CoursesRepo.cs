using System;
using System.Collections.Generic;
using System.Text;
using AppModel.Models;

namespace AppData.InMemory.Implementation
{
    class CoursesRepo
    {
        public bool Add<T>(T entity)
        {
            int rowCountBefore = this.RowCount();
            var course = entity as Course; // convert generic type value to concrete type course
            InMemoryStore.Courses.Add(course);
            int rowCountAfter = this.RowCount();

            if (rowCountAfter <= rowCountBefore)
                return false;

            return true;
        }

        public string Delete<T>(T entity)
        {
            int rowCountBefore = this.RowCount();

            if (rowCountBefore < 1)
                return "No record found! Table is empty";

            var course = entity as Course; // convert generic type value to concrete type course
            InMemoryStore.Courses.Remove(course);
            int rowCountAfter = this.RowCount();

            if (rowCountAfter >= rowCountBefore)
                return "false";

            return "true";
        }

        public int RowCount()
        {
            return InMemoryStore.Courses.Count;
        }

        

        public List<Course> SelectCourses()
        {
            int rowCountBefore = this.RowCount();

            if (rowCountBefore < 1)
                return null;

            return InMemoryStore.Courses;
        }

        public string Update<T>(T entity)
        {
            int rowCountBefore = this.RowCount();

            if (rowCountBefore < 1)
                return "No record found! Table is empty";

            var course = entity as Course; // convert generic type value to concrete type course

            int count = InMemoryStore.Courses.Count;
            for (int i = 0; i < InMemoryStore.Courses.Count; i++)
            {
                if (InMemoryStore.Courses[i].Equals(course))
                {
                    InMemoryStore.Courses[i].CourseName = course.CourseName;
                    InMemoryStore.Courses[i].CourseUnit = course.CourseUnit;
                    InMemoryStore.Courses[i].CourseScore = course.CourseScore;
                    return "true";
                }

                if (InMemoryStore.Courses[count].Equals(course))
                {
                    InMemoryStore.Courses[count].CourseName = course.CourseName;
                    InMemoryStore.Courses[count].CourseUnit = course.CourseUnit;
                    InMemoryStore.Courses[count].CourseScore = course.CourseScore;
                    return "true";
                }
                count--;
            }

            return "false";
        }
    }
}
