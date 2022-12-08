using Db3.Models.Client;
using Tier3___Server.Logic;
using Tier3_Db.Models.Bill;

namespace Tier3___Server.Implementations;

public class ClientLogic : IClientLogic
{
    private readonly DataContext context;
    
    
    public async Task<Client?> getClientByUsername(string content)
    {

        Client client = await context.Clients.FindAsync(content);
        return client;
    }

    public async Task<Client> createClientAccount(Client c)
    {
        throw new NotImplementedException();
    }

    public Task<Client?> getClientById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Client> registerClient(Client client)
    {
        throw new NotImplementedException();
    }


    public Task<Client> deleteClientAccount(Client client)
    {
        throw new NotImplementedException();
    }


    public Task<List<Bill>> getBills(string content)
    {
        throw new NotImplementedException();
    }

    public Task<Bill> getBillById(string content)
    {
        throw new NotImplementedException();
    }
}