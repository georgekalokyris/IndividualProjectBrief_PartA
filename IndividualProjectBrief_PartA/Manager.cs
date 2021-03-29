using System;
using System.Collections.Generic;
using System.Linq;

namespace IndividualProjectBrief_PartA
{
    class Manager
    {
        private School _school;

        public Manager(School school)
        {
            this._school = school;
        }

        //Students to Courses
        public bool AddStudentToCourse(Student student, Course course)
        {
            if (course.Studs.Contains(student))
            {
                return false;
            }
            course.Studs.Add(student);
            student.StudAss.AddRange(course.Assigns); //All of the assignments of the course assigned to the student
            student.StudCourse.Add(course);
            return true;
        }
        //Trainers to Courses
        public bool AddTrainerToCourse(Trainer trainer, Course course)
        {
            if (course.Trains.Contains(trainer))
            {
                return false;
            }
            course.Trains.Add(trainer);
            return true;
        }

        //Assignments to courses
        public bool AddAssignmentToCourse(Assignment assignment, Course course)
        {
            if (_school.Assignments.Contains(assignment))
            {
                return false;   
            }
            _school.Assignments.Add(assignment);

            course.Assigns.Add(assignment);
            foreach(var student in course.Studs)
            {
                student.StudAss.Add(assignment); //All of the assignments of the course assigned to the student
            }
            return true;

        }

        public void AddStudent(Student student)
        {
            if (!_school.Students.Contains(student))
            {
                _school.Students.Add(student);
            }
        }

        public void AddCourse(Course course)
        {
            if (!_school.Courses.Contains(course))
            {
                _school.Courses.Add(course);
            }
        }
        public void AddTrainers(Trainer trainer)
        {
            if (!_school.Trainers.Contains(trainer))
            {
                _school.Trainers.Add(trainer);
            }
        }



        public IEnumerable<Student> GetStudentDue(DateTime date, out DateTime start, out DateTime end)
        {
            end = date;
            start = date;

            while (start.DayOfWeek != DayOfWeek.Monday)
            {
                start = start.AddDays(-1);
            }

            while (end.DayOfWeek != DayOfWeek.Friday)
            {
                end = end.AddDays(1);
            }

            DateTime from = start, to = end;
            return _school.Students.Where(student => student.StudAss.Any(assignment => assignment.SubDateTime >= from && assignment.SubDateTime <= to));
        }
    }
}
