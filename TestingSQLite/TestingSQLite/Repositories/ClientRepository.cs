using TestingSQLite.Models;

public class ClientRepository : IRepository<Client>
{
    private readonly ApplicationDbContext _context;

    public ClientRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Client> GetAll() => _context.Clients.ToList();

    public Client GetById(int id) => _context.Clients.Find(id);

    public void Add(Client entity)
    {
        _context.Clients.Add(entity);
        Save();
    }

    public void Update(Client entity)
    {
        _context.Clients.Update(entity);
        Save();
    }

    public void Delete(int id)
    {
        var client = GetById(id);
        if (client != null)
        {
            _context.Clients.Remove(client);
            Save();
        }
    }

    public void Save() => _context.SaveChanges();
}
