using System;

namespace ComputerAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Lets calculate the price of your machine \nSelect the type of machine 1. Desktop or 2. Laptop 3. Exit (input should be 1 or 2 or 3)");
                int input = Int32.Parse(Console.ReadLine());
                if(input == 1)
                {
                    Desktop desktop1 = new Desktop();
                    System.Console.Write("Enter the processor (i3 or i5 or i7) : ");
                    string processor = Console.ReadLine();
                    desktop1.Processor = processor;

                    System.Console.Write("Enter the ram size : ");
                    int ramSize = Int32.Parse(Console.ReadLine());
                    desktop1.RamSize = ramSize;

                    System.Console.Write("Enter the hard disk size : ");
                    int hdSize = Int32.Parse(Console.ReadLine());
                    desktop1.HardDiskSize = hdSize;

                    System.Console.Write("Enter the graphics card size : ");
                    int gcSize = Int32.Parse(Console.ReadLine());
                    desktop1.GraphicCard = gcSize;

                    System.Console.Write("Enter the Monitor size size : ");
                    int monitorSize = Int32.Parse(Console.ReadLine());
                    desktop1.MonitorSize = monitorSize;

                    System.Console.Write("Enter the power supply volt : ");
                    int power = Int32.Parse(Console.ReadLine());
                    desktop1.PowerSupplyVolt = power;

                    Console.WriteLine(desktop1.DesktopPriceCalculation());

                }
                else if(input == 2)
                {
                    Laptop laptop1 = new Laptop();
                    System.Console.Write("Enter the processor (i3 or i5 or i7) : ");
                    string processor = Console.ReadLine();
                    laptop1.Processor = processor;

                    System.Console.Write("Enter the ram size : ");
                    int ramSize = Int32.Parse(Console.ReadLine());
                    laptop1.RamSize = ramSize;

                    System.Console.Write("Enter the hard disk size : ");
                    int hdSize = Int32.Parse(Console.ReadLine());
                    laptop1.HardDiskSize = hdSize;

                    System.Console.Write("Enter the graphics card size : ");
                    int gcSize = Int32.Parse(Console.ReadLine());
                    laptop1.GraphicCard = gcSize;

                    System.Console.Write("Enter the display size size : ");
                    int displaySize = Int32.Parse(Console.ReadLine());
                    laptop1.DisplaySize = displaySize;

                    System.Console.Write("Enter the battery supply volt : ");
                    int battery = Int32.Parse(Console.ReadLine());
                    laptop1.BatteryVolt = battery;

                    Console.WriteLine(laptop1.LaptopPriceCalculation());
                }
                else if(input == 3)
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("Please enter a valid option");
                }
            }
        }
    }
}