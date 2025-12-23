namespace CakeAssignment
{
    public class InvalidFlavourException : Exception
    {
        //constructor chaining, we are calling base class's contructors
        public InvalidFlavourException():base()
        {
            
        }
        public InvalidFlavourException(string errorMsg):base(errorMsg)
        {
            
        }
        
    }
}