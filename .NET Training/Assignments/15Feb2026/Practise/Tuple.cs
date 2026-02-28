namespace TupleDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] marks = { 50, 30, 80, 20, 60 };
            var results  =AnalyzeResults(marks);
            Console.WriteLine($"{results.passed} { results.failed} { results.passPercentage}");
        }

        public static (int passed,int failed,double passPercentage) AnalyzeResults(int[] marks)
        {
            int passed = 0;
            int failed=0;
            double passPercentage = 0;
            foreach(int mark in marks)
            {
                if (mark > 40)
                {
                    passed++;
                }
                else failed++;
            }
            passPercentage = ((double)passed/(passed+failed))*100;

            return (passed,failed,passPercentage);
        }
    }
}