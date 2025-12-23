using System;

namespace Assignments;

class Assignment3
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public static void DisplayMenu()
    {
        System.Console.Write("Enter day number (0= Monday ... 6 = Sunday) : ");
        int input = Int32.Parse(Console.ReadLine());

        if (input >= 0 && input <= 6)
        {
            Days day = (Days)input;
            switch (day)
            {
                case Days.Monday:
                    Console.WriteLine("Monday Menu:");
                    Console.WriteLine("Breakfast: Idli & Sambar");
                    Console.WriteLine("Lunch: Veg Thali");
                    Console.WriteLine("Dinner: Paneer Butter Masala");
                    break;

                case Days.Tuesday:
                    Console.WriteLine("Tuesday Menu:");
                    Console.WriteLine("Breakfast: Dosa");
                    Console.WriteLine("Lunch: Rajma Chawal");
                    Console.WriteLine("Dinner: Chicken Curry");
                    break;

                case Days.Wednesday:
                    Console.WriteLine("Wednesday Menu:");
                    Console.WriteLine("Breakfast: Poha");
                    Console.WriteLine("Lunch: Dal Tadka");
                    Console.WriteLine("Dinner: Fish Fry");
                    break;

                case Days.Thursday:
                    Console.WriteLine("Thursday Menu:");
                    Console.WriteLine("Breakfast: Upma");
                    Console.WriteLine("Lunch: Veg Biryani");
                    Console.WriteLine("Dinner: Kadai Paneer");
                    break;

                case Days.Friday:
                    Console.WriteLine("Friday Menu:");
                    Console.WriteLine("Breakfast: Paratha");
                    Console.WriteLine("Lunch: Chicken Biryani");
                    Console.WriteLine("Dinner: Butter Chicken");
                    break;

                case Days.Saturday:
                    Console.WriteLine("Saturday Menu:");
                    Console.WriteLine("Breakfast: Chole Bhature");
                    Console.WriteLine("Lunch: Special Thali");
                    Console.WriteLine("Dinner: BBQ Night");
                    break;

                case Days.Sunday:
                    Console.WriteLine("Sunday Menu:");
                    Console.WriteLine("Breakfast: Pancakes");
                    Console.WriteLine("Lunch: Buffet");
                    Console.WriteLine("Dinner: Chef’s Special");
                    break;

                default:
                    Console.WriteLine("Invalid day");
                    break;

            }
        }
        else
        {
            System.Console.WriteLine("Invalid day number");
        }


    }
}