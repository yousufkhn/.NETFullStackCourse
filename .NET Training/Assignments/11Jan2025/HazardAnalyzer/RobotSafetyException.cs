namespace HazardAnalyzer
{
    public class RobotSafetyException : Exception
    {
        // this is constructor chaining
        public RobotSafetyException() : base()
        {
            
        }

        public RobotSafetyException(string errorMsg ) : base(errorMsg)
        {
            
        }
    }
}