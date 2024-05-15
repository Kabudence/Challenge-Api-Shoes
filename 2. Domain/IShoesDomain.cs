using _3._Data.Models;

namespace _2._Domain;

public interface IShoesDomain
{
    Boolean Save(Shoes data);
    Boolean Update(Shoes data);
    Boolean Delete(int id);
    public double CalculateFinalPrice(List<String> data);
}