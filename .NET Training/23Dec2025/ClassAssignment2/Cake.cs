namespace CakeAssignment
{
    public class Cake
    {
        public string Flavour { get; set; }
        public int QuantityInKg { get; set; }
        public double PricePerKg { get; set; }

        public bool CakeOrder()
        {
            if (Flavour != "Chocolate" && Flavour != "RedVelvet" && Flavour != "Vanilla")
            {
                throw new InvalidFlavourException("Flavour not available!");
            }
            if (QuantityInKg <= 0)
            {
                throw new InvalidQuantityException("Invalid QUantity");
            }
            return true;

        }
        
        public double CalculatePrice()
        {
            double totalPrice = QuantityInKg * PricePerKg;
            if (Flavour == "Vanilla")
            {
                return totalPrice - (totalPrice * 0.03);
            }
            else if (Flavour == "Chocolate")
            {
                return totalPrice - (totalPrice * 0.05);
            }
            else
            {
                return totalPrice - (totalPrice * 0.10);
            }
        }
    }
}