using System;

namespace ComputerAssignment
{
    public class Desktop : Computer
    {
        public int MonitorSize{get;set;}
        public int PowerSupplyVolt{get;set;}

        public double DesktopPriceCalculation()
        {
            double price ;
            price = (RamSize*RamPrice) + (HardDiskSize*HardDiskPrice) + (GraphicCard*GraphicCardPrice) + (MonitorSize * 250) + (PowerSupplyVolt * 20);
            if(Processor == "i3")
            {
                price+=1500;
            }
            else if(Processor == "i5")
            {
                price+=3000;
            }
            else
            {
                price+=4500;
            }
            return price;
        }
    }
}