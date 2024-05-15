namespace _3._Data.Models;

public class Client
{
    public int Id {get;set; }
    
    public string Name { get; set; }
    public string Description { get; set; }
    public Boolean IsDeleted { get; set; }
    public string membershipStatus { get; set; }
    public Boolean isFirstPurchase { get; set; }
}