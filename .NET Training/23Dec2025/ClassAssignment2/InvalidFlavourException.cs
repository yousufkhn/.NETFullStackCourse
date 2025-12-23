namespace CakeAssignment
{
    public class InvalidFlavourException : Exception
    {
        public InvalidFlavourException():base()
        {
            
        }
        public InvalidFlavourException(string errorMsg):base(errorMsg)
        {
            
        }
        
    }
}