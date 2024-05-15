using _3._Data.Models;

namespace _3._Data;

public class ShoesMySqlData :IShoesData
{
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
    public List<Shoes> getAll()
    {
        var list = new List<Shoes>();
        
        list.Add(new Shoes(){Name = "Tutrial 1 Mysql",shoeBrand="Nike",shoeSeason="past" });
        list.Add(new Shoes(){Name = "Tutrial 2 Mysql",shoeBrand="Adidas",shoeSeason="current"
        });
        list.Add(new Shoes(){Name = "Tutrial 3 Mysql",shoeBrand="Reebok",shoeSeason="past"
        });

        return list;
    }

    public List<string> GetShoesBrands(List<Shoes> shoes)
    {
        var shoesBrand = new List<string>();
        foreach (var shoe in shoes)
        {
            shoesBrand.Add(shoe.shoeBrand);
        }

        return shoesBrand;
    }

    public List<string> GetShoesSeasons(List<Shoes> shoes)
    {
        var shoesSeasons = new List<string>();
        foreach (var shoe in shoes)
        {
            shoesSeasons.Add(shoe.shoeSeason);
        }

        return shoesSeasons;
    }

    public Shoes getById(int Id)
    {
        throw new NotImplementedException();
    }
}