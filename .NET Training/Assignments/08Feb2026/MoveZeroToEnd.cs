namespace MoveZeroToEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1,2,0,3,4,0,5,0,5,0};
            int length = arr.Length;

            int i = 0;
            int j = 0;

            while (j < length)
            {
                if(arr[j] != 0)
                {
                    arr[i] = arr[j];
                    i++;
                    j++;
                }
                else
                {
                    j++;
                }
            }
            while (i < length)
            {
                arr[i] = 0;
                i++;
            }
            System.Console.WriteLine(string.Join(",",arr));
        }
    }
}