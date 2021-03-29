using System;
using System.Collections.Generic;

namespace IndividualProjectBrief_PartA
{
    class Student
    {
        public List<Assignment> StudAss = new List<Assignment>();
        public List<Course> StudCourse = new List<Course>();
        //Private fields
        private string _firstName;

        private string _lastName;

        private DateTime _dateOfBirth;

        private int _tuitionFees;


        //Public properties
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }

        public int Fees
        {
            get
            {
                return _tuitionFees;
            }
            set
            {
                _tuitionFees = value;
            }
        }

        public Student(string FirstName, string LastName, DateTime DateOfBirth, int Fees)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Fees = Fees;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return $"Firstname: {_firstName}, Lastname: {_lastName}, Date of birth: {_dateOfBirth.ToString("dd/MM/yyyy")}, Tuition Fees: {_tuitionFees}$";
        }
    }
    
}
