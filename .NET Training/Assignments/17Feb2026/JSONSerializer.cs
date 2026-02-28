using System.Text.Json;
namespace JsonSerializerDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id,string name)
        {
            Id = id;
            Name = name;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee(1,"Yousuf");

            string data = JsonSerializer.Serialize(emp);
            File.WriteAllText("data.json",data);

            string data2 = File.ReadAllText("data.json");

            Employee emp2 = JsonSerializer.Deserialize<Employee>(data2);

        
        }
    }
}