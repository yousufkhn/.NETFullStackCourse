class VowelOrConsonant
{
    public static void IsVowel(){
        Console.Write("Enter a character : ");
        string? input = Console.ReadLine();
        char ch;

        while (true)
        {
            if(!string.IsNullOrEmpty(input) && input.Length == 1)
            {
                ch = input[0];
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid character");
            }
        }

        switch (ch)
        {
            case 'A':
            case 'a':
            case 'E':
            case 'e':
            case 'I':
            case 'i':
            case 'O':
            case 'o':
            case 'U':
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Not a vowel");
                break;
        }       
    }
}