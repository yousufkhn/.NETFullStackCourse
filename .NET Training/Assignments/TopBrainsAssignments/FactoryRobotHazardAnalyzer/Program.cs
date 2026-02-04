namespace FactoryQuestion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RobotHazardAuditor rHA = new RobotHazardAuditor();
            while (true)
            {
                System.Console.Write("Enter Arm Precision(0.0 - 1.0) : ");
                double armPrecision = Double.Parse(Console.ReadLine());

                System.Console.Write("Enter Worker Density(1-20) : ");
                int workerDensity = Int32.Parse(Console.ReadLine());

                System.Console.Write("Enter Machinery State(Worn/Faulty/Critical) : ");
                string machineryState = Console.ReadLine();

                try
                {
                    double hazardRisk = rHA.CalculateHazardRisk(armPrecision,workerDensity,machineryState);
                    System.Console.WriteLine($"Robot Hazard Risk Score: {hazardRisk}");
                }
                catch(RobotSafetyException errMsg)
                {
                    System.Console.WriteLine(errMsg);
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e);
                }
            }
        }
    }

    public class RobotHazardAuditor
    {
        public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
            if(armPrecision < 0.0 || armPrecision > 1.0)
            {
                throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
            } 

            if(workerDensity < 1 || workerDensity > 20)
            {
                throw new RobotSafetyException("Error: Worker density must be 1-20");
            }

            if(!machineryState.Equals("Worn") && !machineryState.Equals("Faulty") && !machineryState.Equals("Critical"))
            {
                throw new RobotSafetyException("Error: Unsupported machinery state");
            }
            double machineRiskFactor;
            if (machineryState.Equals("Worn"))
            {
                machineRiskFactor = 1.3;
            }
            else if (machineryState.Equals("Faulty"))
            {
                machineRiskFactor = 2.0;
            }
            else
            {
                machineRiskFactor = 3.0;
            }

            return ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
        }
    }

    public class RobotSafetyException : Exception
    {
        public RobotSafetyException() : base(){}

        public RobotSafetyException(String errMsg) : base(errMsg){}
    }


}