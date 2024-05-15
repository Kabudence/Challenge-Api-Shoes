using _3._Data;
using _3._Data.Models;

namespace _2._Domain;

public class ShoesDomain :IShoesDomain
{
    private IShoesData _tutorialData;
    public ShoesDomain(IShoesData shoesData)
    {
        _tutorialData = shoesData;
    }

    public double CalculateFinalPrice(List<String> data)
    {
        double price = double.Parse(data[0]);
        var membershipStatus = data[1];
        var shoeBrand = data[2];
        var shoeSeason = data[3];
        double discount = 1;
        if (membershipStatus == "premium") discount -= 0.15;
        if (shoeBrand == "Nike" || shoeBrand == "Reebok" || shoeBrand == "Adidas") discount -= 0.10;
        if(shoeSeason =="past")discount -= 0.20;
        if (discount != 0) price = price * discount;
        return price;
    }
    
    public bool Save(Shoes data)
    {
        throw new NotImplementedException();
    }

    public bool Update(Shoes data)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}