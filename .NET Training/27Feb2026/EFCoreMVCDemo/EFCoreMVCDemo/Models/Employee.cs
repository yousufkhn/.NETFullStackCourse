namespace EFCoreMVCDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DeptID { get; set; }

        public virtual Department Department { get; set; }
    }
}
