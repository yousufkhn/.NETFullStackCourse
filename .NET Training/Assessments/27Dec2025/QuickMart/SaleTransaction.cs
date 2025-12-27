public class SaleTransaction
{
    public string InvoiceNo { get; set; }
    public string CustomerName { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public decimal PurchaseAmount { get; set; }
    public decimal SellingAmount { get; set; }
    public string ProfitOrLossStatus { get; set; }
    public decimal ProfitOrLossAmount { get; set; }
    public decimal ProfitMarginPercent { get; set; }

    // updated the logic from the last question to shift the bl into the sale transaction
    public void ComputeProfitLoss()
    {

        if (SellingAmount > PurchaseAmount)
        {
            ProfitOrLossStatus = "PROFIT";
            ProfitOrLossAmount = SellingAmount - PurchaseAmount;
        }
        else if (SellingAmount < PurchaseAmount)
        {
            ProfitOrLossStatus = "LOSS";
            ProfitOrLossAmount = PurchaseAmount - SellingAmount;
        }
        else
        {
            ProfitOrLossStatus = "BREAK_EVEN";
            ProfitOrLossAmount = 0;
        }
        ProfitMarginPercent = (ProfitOrLossAmount / PurchaseAmount) * 100;
    }
}
