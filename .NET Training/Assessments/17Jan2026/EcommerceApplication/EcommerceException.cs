namespace Ecommerce{
	public class InsufficientWalletBalanceException : Exception{
		public InsufficientWalletBalanceException() : base(){}
		
		public InsufficientWalletBalanceException(string errorMsg) : base(errorMsg){}
	}
}