namespace Assignments;

class Assignment1
{
    public static void BubbleSort()
    {
        int[] arr = {5,1,4,2,8};
        int n = arr.Length;


        for(int j = 0; j < n; j++)
        {   
            bool swapped = false;
            Console.WriteLine($"After {j+1} iteration : " + string.Join(" ",arr));
            for(int i = 0; i < n - 1; i++)
            {
               if(arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                    swapped = true;
                }  
            }

            if (!swapped)
            {
                break;
            }         
        }
    }
}