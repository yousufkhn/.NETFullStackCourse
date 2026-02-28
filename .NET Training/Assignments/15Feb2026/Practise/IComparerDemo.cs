namespace IComparerDemo
{
    public static void Main(string[] args)
    {
        // 🔹 STUDENT DEMO
        var students = new List<Student>
            {
                new Student { Name = "Aman", Marks = 85, Age = 20 },
                new Student { Name = "Riya", Marks = 92, Age = 21 },
                new Student { Name = "Kabir", Marks = 85, Age = 19 }
            };

        students.Sort(new StudentComparer());

        Console.WriteLine("Sorted Students:");
        foreach (var s in students)
        {
            Console.WriteLine($"{s.Name} - {s.Marks} - {s.Age}");
        }


        // 🔹 PRODUCT DEMO
        var products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 50000, Quantity = 2 },
                new Product { Name = "Phone", Price = 30000, Quantity = 3 },
                new Product { Name = "Tablet", Price = 20000, Quantity = 5 }
            };

        products.Sort(new ProductComparer());

        Console.WriteLine("\nSorted Products:");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - Total Value: {p.Price * p.Quantity}");
        }

        products.Sort(new ProductComparer());
    }
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public int Age { get; set; }
    }

    public class StudentComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            var result = s1.Marks.CompareTo(s2.Marks);
            if (result == 0)
            {
                return s2.Age.CompareTo(s1.Age);
            }
            return result;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class ProductComparer : IComparer<Product>
    {
        public int Compare(Product p1, Product p2)
        {
            var result = (p2.Price * p2.Quantity).CompareTo(p1.Price * p1.Quantity);
            if (result == 0)
            {
                return p1.Name.CompareTo(p2.Name);
            }
            return result;
        }
    }


}