using System;

namespace ComputerAssignment
{
    public class Computer
    {

        public string Processor{get;set;}
        public int RamSize{get;set;}
        public int HardDiskSize{get;set;}
        public int GraphicCard{get;set;}

        //this is a read only property, after c# 5.0
        public int RamPrice {get;}  = 200;
        public int HardDiskPrice {get;} = 1500;
        public int GraphicCardPrice {get;} = 2500;
        

    }
}