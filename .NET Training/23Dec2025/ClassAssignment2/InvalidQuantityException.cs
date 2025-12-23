namespace CakeAssignment
{
    public class InvalidQuantityException : Exception
    {   
        //constructor chaining, we are calling base class's contructors
        public InvalidQuantityException():base()
        {
            
        }
        public InvalidQuantityException(string errorMsg):base(errorMsg)
        {
            
        }
    }
}