using Db3.Models.Client;
using Db3.Models.Manager;
using Tier3___Server.Logic;

namespace Tier3___Server.Implementations;

public class ManagerLogic : IManagerLogic
{
    public Task<Manager> getManagerById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Manager>? getManagerByUsername(string content)
    {
        throw new NotImplementedException();
    }

    public Task<Manager> addClient(Client client)
    {
        throw new NotImplementedException();
    }

    public Task<Manager> deleteClient(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Manager> editClient(Client client)
    {
        throw new NotImplementedException();
    }

    public Task<Manager> deleteManager(int id)
    {
        throw new NotImplementedException();
    }
}