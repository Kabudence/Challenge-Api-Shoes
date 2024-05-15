using _3._Data.Models;

namespace _3._Data;

public interface IShoesData
{
    Boolean Save(Shoes data);
    Boolean Update(Shoes data);
    Boolean Delete(int id);
    List<Shoes> getAll();
    List<string> GetShoesBrands(List<Shoes> shoes); // Método que devuelve una lista de nombres de clientes
    List<string> GetShoesSeasons(List<Shoes> shoes); // Método que devuelve una lista de nombres de clientes

    Shoes getById(int Id);
}