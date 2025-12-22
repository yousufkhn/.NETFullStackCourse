namespace Assignments;

class Assignment2
{
    public static void AddArr()
    {
        double[] arr1 = {10.0,20.0,30.0};
        double[] arr2 = {20.0,50.0,30.0,70.0,80.0};

        int min = Math.Min(arr1.Length,arr2.Length);
        int max = Math.Max(arr1.Length,arr2.Length);

        int[] ans = new int[max];
        int i =0;
        for(i = 0;i<min; i++)
        {
            ans[i] = (int)(arr1[i] +arr2[i]);
        }
        while (i < max)
        {
            if (i < arr1.Length)
            {
                ans[i] = (int)arr1[i];
            }
            else
            {
                ans[i] = (int)arr2[i];
            }
            i++;
        }

        System.Console.WriteLine(string.Join(" ",ans));

    }
}