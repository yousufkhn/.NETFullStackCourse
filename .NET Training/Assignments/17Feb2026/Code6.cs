// using System;

// using System.Reflection;
// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine ("Try programiz.pro");
//         Type t = typeof(string);
//         foreach(MethodInfo i in t.GetMethods()){
//             Console.WriteLine(i);
//         }
//         foreach(FieldInfo f in t.GetFields())
//         {
//             Console.WriteLine(f);
//         }
//     }
// }







using System;
using System.Reflection;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
        Type t = typeof(Math);
        foreach(MethodInfo i in t.GetMethods()){
            Console.WriteLine(i);
        }
        foreach(FieldInfo f in t.GetFields())
        {
            Console.WriteLine(f);
        }
    }
}



// using System;
// using System.Reflection;
// using System.Collections.Generic;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine ("Try programiz.pro");
//         Type t = typeof(List<int>);
//         foreach(MethodInfo i in t.GetMethods()){
//             Console.WriteLine(i);
//         }
//         foreach(FieldInfo f in t.GetFields())
//         {
//             Console.WriteLine(f);
//         }
//     }
// }