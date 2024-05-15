using _3._Data.Models;

namespace _3._Data;

public class ClientMySqlData :IClientData
{
    public bool Save(Client data)
    {
        throw new NotImplementedException();
    }

    public bool Update(Client data)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Client> getAll()
    {
        var list = new List<Client>();
        
        list.Add(new Client(){Name = "Josue", membershipStatus="premium"});
        list.Add(new Client(){Name = "Pepe 2 Mysql",membershipStatus="regular"});
        list.Add(new Client(){Name = "Tito Mysql",membershipStatus="regular"});

        return list;
    }

    public List<string> GetAllClientNames(List<Client> clients)
    {
        var clientStatus = new List<string>();
        // Iterar sobre cada cliente y obtener su nombre
        foreach (var client in clients)
        {
            clientStatus.Add(client.membershipStatus);
        }

        return clientStatus;
    }
    public Client getById(int Id)
    {
        throw new NotImplementedException();
    }
}