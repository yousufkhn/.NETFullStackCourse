class LargestOfThree
{
    public static void Largest()
    {
        int[] numArr = new int[3];

        Console.WriteLine("Please enter the 3 numbers one by one");

        for(int i = 0; i < 3; i++)
        {
            // using goto statement for when the input is invalid to retry inputting the same number
            // but we should avoid using goto in modern c# it leads to spaghetti code, instead use break, return or throw
            // we used goto to demonstrate its working here
            retryInput:
                Console.WriteLine($"Input {i+1} : ");
                string? input = Console.ReadLine();
                if(int.TryParse(input,out int number))
                {
                    numArr[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid input!! Lets try again");
                    goto retryInput;
                }
        }
        int largest = -1;
        foreach(var num in numArr)
        {
            if(num>largest) largest = num;
        }

        Console.WriteLine($"The largest number is {largest}");


    }
}