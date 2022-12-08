using Db3.Models.Client;
using Db3.Models.Manager;

namespace Tier3___Server.Logic;

public interface IManagerLogic
{
    Task<Manager> getManagerById(int id);
    Task<Manager>? getManagerByUsername(string content);
    Task<Manager> addClient(Client client);
    Task<Manager> deleteClient(int id);
    Task<Manager> editClient(Client client);
    Task<Manager> deleteManager(int id);
    
}