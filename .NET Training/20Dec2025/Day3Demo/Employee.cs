namespace Day3Demo
{
    internal class Employee : Person // IS - A relationship
    {

        #region Fields
        string Skill;
        string Designation;
        int empId;
        int bSal;

        #endregion

        public Employee()
        {
            Console.WriteLine("Employee Class Constructor Invoked");
        }

        ~Employee()
        {
            Console.WriteLine("Employee Class Destructor Invoked");
        }
    }
}

