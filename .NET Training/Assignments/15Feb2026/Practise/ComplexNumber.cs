namespace Complex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real,double img)
        {
            Real = real;
            Imaginary = img;
        }

        public static ComplexNumber operator +(ComplexNumber c1,ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real+c2.Real,c1.Imaginary+c2.Imaginary);    
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}";
        }
    }
}