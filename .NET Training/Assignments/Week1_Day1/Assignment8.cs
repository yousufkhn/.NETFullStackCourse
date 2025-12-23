namespace Assignment8NameSpace;

class Assignment8
{
    static int input1;
    static int input2;
    static int output;

    public static void Assignment8Main()
    {
        input1 = 20;
        input2 = 40;

        output = input1*input2;
        System.Console.WriteLine(output);
        System.Console.WriteLine(Add(10,20));
        System.Console.WriteLine(Substract(10,20));
        System.Console.WriteLine(Divide(10,20));
        System.Console.WriteLine(Multiply(10,20));
    }

    public static int Add(int num1 , int num2)
    {
        return num1+num2;
    }

    public static int Substract(int num1 , int num2)
    {
        return num1-num2;
    }

    public static float Divide(int num1,int num2){
        return num1/num2;
    } 

    public static float Multiply(int num1,int num2)
    {
        return num1*num2;
    }
}