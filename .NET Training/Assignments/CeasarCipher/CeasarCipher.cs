using System;
using System.Text;

namespace CeasarCipherSpace
{
    public class CeasarCipher
    {
        public static void CeasarCipherMain()
        {
            while (true)
            {
                System.Console.WriteLine("====Ceasar Cipher====");
                System.Console.WriteLine("1. Encrypt");
                System.Console.WriteLine("2. Decrypt");
                System.Console.WriteLine("3. Exit");
                System.Console.Write("Choose an option : ");

                string input = Console.ReadLine();

                if(input == "3")
                {
                    break;
                }
                
                System.Console.Write("Enter the Text : ");
                string text = Console.ReadLine();

                System.Console.WriteLine("Enter the key (number) : ");
                int key = Int32.Parse(Console.ReadLine());

                if(input == "1")
                {
                    string encrypted = Encrypt(text,key);
                    System.Console.WriteLine($"Encrypted text : {encrypted}");
                }
                else if(input == "2")
                {
                    string decrypted = Decrypt(text,key);
                    System.Console.WriteLine($"Decrypted text : {decrypted}");
                }
                else
                {
                    System.Console.WriteLine("Invalid input");
                }
            }
        }

        static string Encrypt(string text,int key)
        {
            StringBuilder result = new StringBuilder();
            key = key%26;

            foreach(char ch in text)
            {
                if (char.IsUpper(ch))
                {
                result.Append((char)((ch - 'A' + key) %26 + 'A'));
                    
                }
                else if (char.IsLower(ch))
                {
                    result.Append((char)((ch - 'a' + key) % 26 + 'a'));
                }
                else
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }

        static string Decrypt(string text,int key)
        {
            StringBuilder result = new StringBuilder();
            key = key%26;

            foreach(char ch in text)
            {
                if (char.IsUpper(ch))
                {
                    result.Append((char) ((ch - 'A' - key + 26) %26 + 'A'));
                }
                else if (char.IsLower(ch))
                {
                    result.Append((char) ((ch - 'a' - key + 26) %26 + 'a'));
                }
                else
                {
                    result.Append(ch);
                }

            }
            return result.ToString();
        }
    }
}