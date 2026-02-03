using System.Text;

public class Program
{
    static string RemoveConsonants(string str1,string str2)
    {
        // storing all consonats from str2 in hashset
        HashSet<char> vowels = new HashSet<char>{'a','e','i','o','u','A','E','I','O','U'};
        HashSet<char> cons = new HashSet<char>();
        str2 = str2.ToLower();
        foreach(char c in str2)
        {
            if(!vowels.Contains(c))
            {
                cons.Add(c);
            }
        }


        StringBuilder sb = new StringBuilder();
        foreach(char c in str1)
        {
            if (!cons.Contains(char.ToLower(c)))
            {
                sb.Append(c);
            }
        }
        StringBuilder result = new StringBuilder();

        for(int i = 0; i < sb.Length; i++)
        {
            if(i==0 || sb[i] != sb[i - 1])
            {
                result.Append(sb[i]);
            }
        }
        return result.ToString();
        
    }

    public static void Main(string[] args)
    {

    }
}