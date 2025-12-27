internal class Customer
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public Address? BillingAddress { get; set; }
    public Address? ShippingAddress { get; set; }
}

internal class Address
{
    public string? FlatNo { get; set; }
    public string? BuildingName { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; } 

}

