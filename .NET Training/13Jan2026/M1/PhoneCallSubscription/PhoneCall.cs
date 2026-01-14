using System;

namespace PhoneCallSub
{
    delegate void Notify();
    public class PhoneCall
    {
        event Notify PhoneCallEvent;
        public string Message {get; private set;}

        private void OnSubscribe()
        {
            Message = "Subscribed To Call";
        }

        private void OnUnSubscribe()
        {
            Message = "Unsubscribed to call";
        }

        public void MakeAPhoneCall(bool notify)
        {
            PhoneCallEvent = null;
            if (notify)
            {
                PhoneCallEvent += OnSubscribe;
            }
            else
            {
                PhoneCallEvent += OnUnSubscribe;
            }

            if(PhoneCallEvent != null)
            {
                PhoneCallEvent();
            }
        }
    }

}