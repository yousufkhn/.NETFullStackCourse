using System;

namespace LogginExtensionsDemo
{
    public static class StringLogExtensions
    {
        public static void ToInfoLog(this string message)
        {
            Console.WriteLine($"{message} ");
        }

        public static void ToWarningLog(this string message)
        {
            System.Console.WriteLine(message);
        }

        public static void ToErrorLog(this string message)
        {
            System.Console.WriteLine(message);
        }
    }
}