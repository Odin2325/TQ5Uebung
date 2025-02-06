using System.Collections.Generic;
using TestingSQLite.Models;

public interface IClientService
{
    IEnumerable<Client> GetAllClients();
    Client GetClientById(int id);
    void AddClient(Client client);
}

public class ClientService : IClientService
{
    private readonly IRepository<Client> _repository;

    public ClientService(IRepository<Client> repository)
    {
        _repository = repository;
    }

    public IEnumerable<Client> GetAllClients() => _repository.GetAll();

    public Client GetClientById(int id) => _repository.GetById(id);

    public void AddClient(Client client) => _repository.Add(client);
}
