using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            if (AvailableCourses.ContainsKey(code))
            {
                throw new ArgumentException("Course Already Exists");
            }
            // 2. Create Course object
            Course c = new Course(code, name, credits, maxCapacity, prerequisites);
            // 3. Add to AvailableCourses
            AvailableCourses.Add(c.CourseCode,c);
            //throw new NotImplementedException();
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            if (Students.ContainsKey(id))
            {
                throw new ArgumentException("Student already Registered");
            }
            // 2. Create Student object
            Student s = new Student(id, name, major, maxCredits, completedCourses);
            // 3. Add to Students dictionary
            Students.Add(s.StudentId,s);
            //throw new NotImplementedException();
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            if(Students.ContainsKey(studentId) && AvailableCourses.ContainsKey(courseCode))
            {
                Student s = Students[studentId];
                Course c = AvailableCourses[courseCode];
                s.AddCourse(c);
                return true;
            }
            return false;
            // 2. Call student.AddCourse(course)
            // 3. Display meaningful messages
            //throw new NotImplementedException();
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            if (Students.ContainsKey(studentId))
            {
                Student s = Students[studentId];
                s.DropCourse(courseCode);
                return true;
            }
            return false;
            // 2. Call student.DropCourse(courseCode)
            //throw new NotImplementedException();
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            foreach(var c in AvailableCourses)
            {
                Console.WriteLine($"{c.Key} {c.Value.CourseName} { c.Value.Credits} { c.Value.GetEnrollmentInfo()}");
            }
            //throw new NotImplementedException();
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            if (Students.ContainsKey(studentId){
                Student s = Students[studentId];
                s.DisplaySchedule();
            }
            // Call student.DisplaySchedule()
            //throw new NotImplementedException();
        }

        public void DisplaySystemSummary()
        {

            // TODO:
            Console.WriteLine($"Total Students : {Students.Count}");
            Console.WriteLine($"Total Courses : {AvailableCourses.Count}");
            // Display total students, total courses, average enrollment
            foreach(var c in AvailableCourses)
            {
                Console.WriteLine($"{c.Value.GetEnrollmentInfo}");
            }
            //throw new NotImplementedException();
        }
    }
}
