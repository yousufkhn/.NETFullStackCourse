class Number
{
    public static void PrimeNumbers()
    {
        Console.WriteLine("2 ");
        for(int i = 3 ; i < 25; i+=2)
        {
            bool isPrime = true;

            for(int j = 3; j<=Math.Sqrt(i); j+=2)
            {
                if(i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(i + " ");
                
            }

        }
    }
}