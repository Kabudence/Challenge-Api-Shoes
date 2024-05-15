namespace _3._Data.Models;

public class Shoes
{
    public int Id {get;set; }
    
    public string Name { get; set; }
    public string Description { get; set; }
    public string shoeBrand { get; set; }
    public string shoeSeason { get; set; }
    public string Price { get; set; }

    public Boolean IsDeleted { get; set; }
    
}