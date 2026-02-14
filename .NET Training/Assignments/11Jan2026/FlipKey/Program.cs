using System.Text;

namespace FlipKey
{
    public class Program
    {
        public static string CleanseAndInvert(string input)
        {
            StringBuilder sb = new StringBuilder();
            if(String.IsNullOrEmpty(input) || input.Length <6)
            {
                return "";
            }
            else
            {
                foreach(char c in input)
                {
                    if (!char.IsAsciiLetter(c))
                    {
                        return "";
                    }
                }
                input = input.ToLower();
                foreach(char c in input)
                {
                    if(c.GetHashCode() % 2 != 0)
                    {
                        sb.Append(c);
                    }
                }
                input = sb.ToString();
                sb.Clear();
                foreach(char c in input)
                {
                    sb.Insert(0,c);
                }
                for(int i = 0; i < sb.Length; i++)
                {
                    if(i %2 == 0)
                    {
                        sb[i] = char.ToUpper(sb[i]);
                    }
                }
                return sb.ToString();
            }
        }
        public static void Main(string[] args)
        {
            System.Console.Write("Enter a string : ");
            string input = Console.ReadLine();
            string result = CleanseAndInvert(input);
            if(result == "")
            {
                System.Console.WriteLine("Invalid Input");
            }
            else
            {
                System.Console.WriteLine(result);
            }
        }
    }
}