using System;

namespace ComputerAssignment
{
    public class Laptop : Computer
    {
        public int DisplaySize{get;set;}
        public int BatteryVolt{get;set;}
        public double LaptopPriceCalculation()
        {
            double price ;
            price = (RamSize*200) + (HardDiskSize*1500) + (GraphicCard*2500) + (DisplaySize * 250) + (BatteryVolt * 20);
            if(Processor == "i3")
            {
                price+=2500;
            }
            else if(Processor == "i5")
            {
                price+=5000;
            }
            else
            {
                price+=6500;
            }
            return price;
        }
    }
}