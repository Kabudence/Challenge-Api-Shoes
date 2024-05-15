using _3._Data;
using _3._Data.Models;

namespace _2._Domain;

public class ClientDomain :IClientDomain
{

    private readonly IClientData _clientData;

    public ClientDomain(IClientData clientData)
    {

        _clientData = clientData;

    }
    public bool Save(Client data)
    {
        return true;
    }

    public bool Update(Client data)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}