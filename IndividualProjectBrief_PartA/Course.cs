using System;
using System.Collections.Generic;

namespace IndividualProjectBrief_PartA
{
    class Course
    {
        private string _title;

        private string _stream;

        private string _type;

        private DateTime _start_date;

        private DateTime _end_date;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Stream
        {
            get
            {
                return _stream;
            }
            set
            {
                _stream = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return _start_date;
            }
            set
            {
                _start_date = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return _end_date;
            }
            set
            {
                _end_date = value;
            }
        }

        //Each course can have multiple trainers
        public List<Trainer> Trains = new List<Trainer>();
        //Each course can have multiple students
        public List<Student> Studs = new List<Student>();
        //Each course can have multiple assignments
        public List<Assignment> Assigns = new List<Assignment>();

        public Course(string Title, string Stream, string Type, DateTime Start_Date, DateTime End_Date)
        {
            this.Title = Title;
            this.Stream = Stream;
            this.Type = Type;
            this.StartDate = Start_Date;
            this.EndDate = End_Date;
        }

        public override string ToString()
        {
            return $"Title: {_title}, Stream: {_stream}, Type: {_type}, Start Date: {_start_date.ToString("dd/MM/yyyy")}, End Date: {_end_date.ToString("dd/MM/yyyy")}";
        }
    }
    
}
