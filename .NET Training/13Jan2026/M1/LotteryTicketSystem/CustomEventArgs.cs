using System;

namespace LotterySystem
{
    public class CustomEventArgs : EventArgs
    {
        int Quantity {get;set;}

        public QuantityEventArgs(int balance)

    }
}