namespace HazardAnalyzer
{
    public class RobotHazardAuditor
    {
        public double CalculateHazardRisk(double armPrecision,int workerDensity,string machineryState)
        {
            if(armPrecision < 0.0 || armPrecision > 1.0)
            {
                throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
            }
            else if(workerDensity < 1 || workerDensity >20)
            {
                throw new RobotSafetyException("Error: Worker density must be 1-20");
            }
            else if(!machineryState.Equals("Worn") && !machineryState.Equals("Faulty") && !machineryState.Equals("Critical"))
            {
                throw new RobotSafetyException("Error: Unsupported machinery state");
            }
            else
            {
                double hazardRisk;
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
                hazardRisk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);

                return hazardRisk;

            }
        }
    }
}