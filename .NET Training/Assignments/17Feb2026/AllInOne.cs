using System.Text.RegularExpressions;

namespace AllInOne
{
    public class InvalidEmployeeException : Exception{
        public InvalidEmployeeException():base(){}
        public InvalidEmployeeException(string errMsg) : base(errMsg)
        {
            
        }
    }

    public abstract class Employee : IComparable<Employee>
    {
        private int id;
        private string name;
        private string email;
        private decimal baseSalary;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidEmployeeException();
                }
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                string emailRegex = @"^[A-Za-z0-9_.-]+@[A-Za-z0-9.-]+\.(com|in)$";
                if (!Regex.IsMatch(value, emailRegex))
                {
                    throw new InvalidEmployeeException();
                }
                email = value;
            }
        }

        public Employee(int id,string name,string email,decimal baseSalary)
        {
            Id= id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
        }

        public decimal BaseSalary
        {
            get{return baseSalary;}
            set{baseSalary = value;}
        }

        public int CompareTo(Employee other)
        {
            return this.baseSalary.CompareTo(other.baseSalary);
        }

        public abstract decimal CalculateSalary();

        public override string ToString()
        {
            return $"{Name} {Email} {Id}";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Employee emp)
            {
                return this.Id == emp.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

    }

    public class PermanentEmployee : Employee
    {
        public decimal BonusPercentage { get; set; }

        public override decimal CalculateSalary()
        {
            return this.BaseSalary + this.BaseSalary * BonusPercentage /100;
        }
    }

    public class ContractEmployee : Employee
    {
        public int ContractDurationMonths { get; set; }

        public override decimal CalculateSalary()
        {
            return this.BaseSalary;
        }
    }
}