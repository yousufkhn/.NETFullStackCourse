// See https://aka.ms/new-console-template for more information
namespace Day3Demo
{
    internal class Program
    {   
        static void SwapMe(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Inside swap func \n value for Num1 ; {0} Num2 : {1}",x,y);
        }

        // Method overloading, access modifier and return type should be same across all the functions
        public int AddToCart(int p1)
        {
            return p1;
        }

        public int AddToCard(params int[] prices)
        {
            int total =0;
            foreach(int i in prices)
            {
                total+=i;
            }
            return total;
        } // params ->  enables us to have n number of inputs, instead of overloading it many times

        // public int AddToCart(int p1,int p2)
        // {
        //     return p1+p2;
        // }

        // public int AddToCart(int p1,int p2,int p3)
        // {
        //     return p1+p2+p3;
        // }
        static void Main(string[] args)
        {
            // Person persObj = new Person();
            // Person persObj2 = new Person();




            // Employee empObj = new Employee(); // bad practise because it will activate all the parent class objects making it a heavy object

            // Employee empObj = null; // declare here and initiliaze with null to get and handle null exception in future
            // empObj = new Employee(); // initialize it only where needed




            Person p1 = new Person();
            p1.Display(100);
            p1.Display(100.25f);
            p1.Display("LPU");
            p1.Display(new Employee()); // anonymous object





            // Casting Demo Below

            int x = 100;
            long z = x; //Implicit casting ( lower datatype to higher datatype)

            // short y = x; can't do this (-31768 to 32767)
            short y = (short)x; // as x is in limit -> (-31768 to 32767) we can convert it explicitly


            // Boxing & unboxing demo below
            // boxing is converting a value type to reference type

            // int num = 120;
            // object op = num; // boxing -> Value to Ref type

            // // int num2 = op; // cannot directly do this
            // int num = (int)op; // correct way to do unboxing -> Ref to Value type

            // int num1 = 100;
            // int num2 = 200;
            // Console.WriteLine("Prior swap func \n value for Num1 ; {0} Num2 : {1}",num1,num2);
            // // SwapMe(num1,num2);// this is pass by value
            // SwapMe(ref num1,ref num2); // this is to pass by reference
            // Console.WriteLine("After swap func \n value for Num1 ; {0} Num2 : {1}",num1,num2);

            Program pObj = new Program();
            pObj.AddToCart(1);        
        }
    }
}
