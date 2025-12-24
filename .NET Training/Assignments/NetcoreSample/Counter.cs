using System;

namespace CounterSpace
{
    public class Counter
    {
        public int[] data = null;

        public Counter(){}

        public Counter(int[] arr)
        {
            data = arr;
        }

        public string getCount()
        {
            int count0 = data.Count(n=> n == 0);
            int count1 = data.Count(n=> n == 1);

            if((count0 % 2 == 0 && count1%2 == 0) || (count0 % 2 != 0 && count1%2 != 0) )
            {
                return "Great";
            }
            else if(count0 %2 == 0 && count1 %2 != 0)
            {
                throw new ExceptionOne("One Comes odd times");
            } 
            else if(count1 %2 == 0 && count0 %2 != 0)
            {
                throw new ExceptionZero("Zero comes odd times");
            }
            else
            {
                return "invalid response";
            }
        }

    }

    public class ExceptionZero : Exception
    {
        public ExceptionZero():base(){}

        public ExceptionZero(string errorMessage) : base(errorMessage){}
    }

    public class ExceptionOne: Exception
    {
        public ExceptionOne():base(){}

        public ExceptionOne(string errorMessage) : base(errorMessage)
        {
            
        }
    }
}