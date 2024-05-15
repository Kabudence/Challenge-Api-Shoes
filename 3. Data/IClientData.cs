using _3._Data.Models;

namespace _3._Data;

public interface IClientData
{
    Boolean Save(Client data);
    Boolean Update(Client data);
    Boolean Delete(int id);
    List<Client> getAll();
    List<string> GetAllClientNames(List<Client> clients); // Método que devuelve una lista de nombres de clientes
    Client getById(int Id);
}