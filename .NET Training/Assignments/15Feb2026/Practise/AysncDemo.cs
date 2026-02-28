namespace AsyncDemo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var result = FetchData();
            System.Console.WriteLine("hahahaha");
            var data = await result;
            System.Console.WriteLine(data.ToString());     
        }

        public static async Task<string> FetchData()
        {
            System.Console.WriteLine("Fetching Data...");
            await Task.Delay(2000);
            return "Fetched Data";
        }
    }
}