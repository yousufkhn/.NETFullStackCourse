using System;

namespace MyKhata
{
    public class Khata
    {
        public Dictionary<string,int> KhataBook {get;private set;} = null;
        public Khata(Dictionary<string,int> record)
        {
            KhataBook = record;
        }

        public int GetTotal()
        {
            int total = 0;
            foreach(var item in KhataBook)
            {
                total+=item.Value;
            }
            return total;
        }
        
        public int GetRepeatAmount()
        {
            int count = 0;
            Dictionary<int,int> dict = new Dictionary<int,int>();

            foreach(var item in KhataBook)
            {
                if (dict.ContainsKey(item.Value))
                {
                    dict[item.Value]++;
                }
                else
                {
                    dict.Add(item.Value,1);
                }
            }
            foreach(var c in dict.Values)
            {
                if (c > 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}