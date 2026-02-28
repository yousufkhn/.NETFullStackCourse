namespace PatternMatching
{
    public class Program
    {
        public static void Main(string[] args)
        {

            
        }

        public interface IShape
        {
            
        }

        public class Circle : IShape
        {
            public double Radius{get;set;}
        }
        public class Rectangle: IShape
        {
            public double Width {get;set;}
            public double Length{get;set;}
        }

        public static double GetArea(IShape shape)
        {
            return shape switch
            {
                Circle c => Math.PI * c.Radius * c.Radius,
                Rectangle r => r.Length * r.Width,
                _ => throw new ArgumentException("Unknown shape")
            };
        }
    }
}