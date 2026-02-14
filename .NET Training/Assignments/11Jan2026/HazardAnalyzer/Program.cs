namespace HazardAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RobotHazardAuditor rha = new RobotHazardAuditor();

            try
            {
                System.Console.WriteLine($"Robot Hazard Risk Score : {rha.CalculateHazardRisk(1.3,4,"Worn")}");
                
            }
            catch(RobotSafetyException e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}