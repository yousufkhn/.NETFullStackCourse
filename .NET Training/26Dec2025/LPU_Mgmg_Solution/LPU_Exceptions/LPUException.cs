namespace LPU_Exceptions
{
    /// <summary>
    /// Custom Exception Class Created for LPU Project 
    /// By Yousuf on Date 29 Dec 2025 at 11.34AM
    /// </summary>
    public class LPUException : Exception
    {
        public LPUException() : base() { }

        public LPUException(string errorMsg) : base(errorMsg)
        {
            
        }
    }
}
