public class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the first word : ");
        string word1 = Console.ReadLine();

        System.Console.WriteLine("Enter the second word : ");
        string word2 = Console.ReadLine();

        int count =0;

        foreach(char c in word1)
        {
            if (!word2.Contains(c))
            {
                count++;
            }
        }

        System.Console.WriteLine(count);
    }
}