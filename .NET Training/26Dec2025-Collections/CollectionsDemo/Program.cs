using System;
using System.Collections;
using System.Collections.Generic;

// ArrayList arrayList = new ArrayList();
// arrayList.Add(10);
// arrayList.Add(10.0);
// arrayList.Add("Hello");

// foreach(object i in arrayList)
// {
//     System.Console.WriteLine(i.GetType());
// }

// int[,] twodarr = new int[2,3];
// int[][] jagged = new int[3][];
// jagged[0] = new int[]{1,2,3};
// jagged[2] = new int[]{1,2};
// jagged[1] = new int[]{1,2,3,4};
// System.Console.WriteLine(jagged[0].ToString());
// System.Console.WriteLine(jagged[1].ToString());
// System.Console.WriteLine(jagged[2].ToString());

string input = "123";

if(Int32.TryParse(input,out int number))
{
    System.Console.WriteLine(number);
}
else
{
    System.Console.WriteLine("Not a number");
}
