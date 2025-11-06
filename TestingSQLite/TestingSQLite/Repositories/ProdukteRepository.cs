using TestingSQLite.Models;

namespace TestingSQLite.Repositories 
{
    internal class ProdukteRepository : IRepository<Produkte>
    {
        private readonly ApplicationDbContext _context;

        public ProdukteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Produkte produkt)
        {
            _context.Produkte.Add(produkt);
        }

        public void Delete(int id)
        {
            var produkt = GetById(id);
            _context.Produkte.Remove(produkt);
        }

        public IEnumerable<Produkte> GetAll()
        {
            throw new NotImplementedException();
        }

        public Produkte GetById(int id)
        {
            return _context.Produkte.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Produkte entity)
        {
            throw new NotImplementedException();
        }
    }
}
