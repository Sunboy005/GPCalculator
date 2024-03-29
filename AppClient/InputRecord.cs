﻿using AppClient.DTOs;
using AppModel.Models;
using Commons;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AppClient
{
    public class InputRecord

    {
        List<AddDTO> recordKeeper = new List<AddDTO>();

        public List<AddDTO> GetData()
        {
            Console.WriteLine("Welcome to GPA Calculator");
            Console.WriteLine("Please, Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

        intro:
            Console.WriteLine("How many Courses Do you register for this semester?");
            int counter = 0;
            try
            {
                string result = Console.ReadLine();
                int resultParse = int.Parse(result);
                counter = resultParse;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid Input type. Please enter a number:", ex);
                goto intro;
            }                           
            
            Console.Clear();
            for (int i = 0; i < counter; i++)
            {
                var Dto = new AddDTO();
                Console.WriteLine($"Please Enter Course {i + 1} Name");
                Dto.CourseName = Console.ReadLine();
                Console.WriteLine("Please, Press Enter Key, to add the course Unit.");
                Console.Clear();
            courseunit:
                Console.WriteLine($"Please Enter Course {i + 1} Unit");
                var result1 = Console.ReadLine();
                int cUnit;
                bool intResult1TryParse = int.TryParse(result1, out cUnit);
                if (!intResult1TryParse)
                {
                    Console.WriteLine($"You have entered an invalid Data ({result1}). Please enter a number");
                    goto courseunit;
                }
                Dto.CourseUnit = cUnit;
                Console.WriteLine("Please, Press Enter Key, to add Your Score in the Course.");
                Console.Clear();

            coursescore:
                Console.WriteLine($"Please Enter Course {i + 1} Score");
                var result2 = Console.ReadLine();
                int cScore;
                bool intResult2TryParse = int.TryParse(result2, out cScore);
                if (!intResult2TryParse)
                {
                    Console.WriteLine($"You have entered an invalid Data ({result2}). Please enter a number");
                    goto coursescore;
                }
                Dto.CourseScore = cScore;//Assign the score toDTOs CourseScore
                Console.Clear();

                recordKeeper.Add(Dto);//Save it to the List
                if (i < counter)
                {
                    Console.WriteLine("Please, Press Enter Key, to add the next course.");
                    Console.Clear();
                }
            }
            // GetGrade()
           
            Console.WriteLine("Please Wait for your GPA ... ");
            Thread.Sleep(2000);
            return recordKeeper;
        }

        public List<Course> NewCourseConstruct(List<AddDTO> newRecord)
        {
            var newCourseList = new List<Course>();
            foreach (var item in newRecord)
            {
                var course = new Course();
                course.CourseName = item.CourseName;
                course.CourseUnit = item.CourseUnit;
                course.CourseScore = item.CourseScore;
                course.Grade = Utils.GetGrade(item.CourseScore);
                course.GradePoint = Utils.GetGradeUnit(Utils.GetGrade(item.CourseScore));
                course.QualityPoint =item.CourseUnit * Utils.GetGradeUnit(Utils.GetGrade(item.CourseScore));
                newCourseList.Add(course);

            }
            return newCourseList;
        }

    }
}
