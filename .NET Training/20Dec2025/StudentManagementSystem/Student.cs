// example of a entity class

namespace StudentManagementSystem
{
    public class Student
    {
        //first approach (why clr properties ? -> useful when we have to apply some conditions or checks or limits in values)
        int rollNo;
        int phy;
        int chem;
        int maths;
        int total;
        float perc;

        //CRL Properties 

        public int RollNo
        {
            set
            {
                rollNo = value;// value is a reserved keyword
            }
            get
            {
                return rollNo;
            }
        }
        public int Phy
        {
            get
            {
                return phy;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    phy = value;
                }
                else
                {
                    throw new InvalidMarksException("Invalid Marks");
                }
            }
        }

        public int Chem
        {
            get
            {
                return chem;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    chem = value;
                }
                else
                {
                    throw new InvalidMarksException("Invalid Marks");
                }
            }
        }

        public int Maths
        {
            get
            {
                return maths;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    maths = value;
                }
                else
                {
                    throw new InvalidMarksException("Invalid Marks");
                }
            }
        }

        // second approach
        // Auto Implicit Property

        public string Name { get; set; }

        public string Address { get; set; }

        //deferred property example below, where get is public and set is protected
        public int Total{
            get
            {
                return total;
            }
            // protected set
            set
            {
                total = value;
            }
        }

        public float Perc{get;set;}

    }

    //never create in same file, just for demosntration
    internal class InvalidMarksException : Exception
    {
        public InvalidMarksException()
        {

        }
        public InvalidMarksException(string? message) : base(message)
        {

        }
        public InvalidMarksException(string? message, Exception? innerException)
        {

        }
    }
}
