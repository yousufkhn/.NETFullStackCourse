using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {
            int total = 0;
            foreach(Course c in RegisteredCourses)
            {
                total += c.Credits;
            }
            return total;
            //throw new NotImplementedException();
        }

        public bool CanAddCourse(Course course)
        {
            // TODO:
            // 1. Course should not already be registered
            
            if (!RegisteredCourses.Contains(course) && GetTotalCredits() + course.Credits <= MaxCredits && course.HasPrerequisites(CompletedCourses))
            {
                return true;
            }
            else
            {
                return false;
            }
                // 2. Total credits + course credits <= MaxCredits
                // 3. Course prerequisites must be satisfied
                //throw new NotImplementedException();
        }

        public bool AddCourse(Course course)
        {
            // TODO:
            // 1. Call CanAddCourse
            if (CanAddCourse(course) && !course.IsFull())
            {
                RegisteredCourses.Add(course);
                course.EnrollStudent();
                return true;
            }
            else return false;
            // 2. Check course capacity
            // 3. Add course to RegisteredCourses
            // 4. Call course.EnrollStudent()
            //throw new NotImplementedException();
        }

        public bool DropCourse(string courseCode)
        {
            // TODO:
            // 1. Find course by code
            foreach(Course c in RegisteredCourses)
            {
                if (c.CourseCode.Equals(courseCode))
                {
                    RegisteredCourses.Remove(c);
                    c.DropStudent();
                    return true;
                }

            }
            return false;
            // 2. Remove from RegisteredCourses
            // 3. Call course.DropStudent()
            //throw new NotImplementedException();
        }

        public void DisplaySchedule()
        {
            // TODO:
            // Display course code, name, and credits
            if(RegisteredCourses != null)
            {
                foreach(Course c in RegisteredCourses)
                {
                    Console.WriteLine($"{c.CourseCode} - {c.CourseName} - {c.Credits}");
                }

            }
            else
            {
                Console.WriteLine("Not Registered in any Courses");
            }
                // If no courses registered, display appropriate message
                //throw new NotImplementedException();
        }
    }
}
