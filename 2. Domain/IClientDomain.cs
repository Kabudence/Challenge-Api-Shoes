using _3._Data.Models;

namespace _2._Domain;

public interface IClientDomain
{
    Boolean Save(Client data);
    Boolean Update(Client data);
    Boolean Delete(int id);
}