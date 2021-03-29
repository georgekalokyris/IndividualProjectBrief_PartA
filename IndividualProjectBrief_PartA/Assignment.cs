using System;

namespace IndividualProjectBrief_PartA
{
    class Assignment
    {
        private string _title;

        private string _description;

        private DateTime _subDateTime;
        //Oral is the part of the mark that is used in calculation of the overall
        private int _oralMark;
        //Total is the written mark
        private int _totalMark;

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
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public DateTime SubDateTime
        {
            get
            {
                return _subDateTime;
            }
            set
            {
                _subDateTime = value;
            }
        }

        public int OralMark
        {
            get
            {
                return _oralMark;
            }
            set
            {
                _oralMark = value;
            }
        }

        public int TotalMark
        {
            get
            {
                return _totalMark;
            }
            set
            {
                _totalMark = value;
            }

        }

        public Assignment(string Title, string Description, DateTime SubDateTime, int OralMark, int TotalMark)
        {
            this.Title = Title;
            this.Description = Description;
            this.SubDateTime = SubDateTime;
            this.OralMark = OralMark;
            this.TotalMark = TotalMark;
        }

        public override string ToString()
        {
            return $"Title: {_title}, Description: {Description}, Submission Date:{_subDateTime.ToString("dd/MM/yyyy")}, OralMark: {_oralMark}, TotalMark: {_totalMark}";
        }

    }
    
}
