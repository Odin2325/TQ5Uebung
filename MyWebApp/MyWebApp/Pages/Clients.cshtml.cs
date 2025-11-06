using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Data;
using MyWebApp.Models;

namespace MyWebApp.Pages
{
    public class ClientsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ClientsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Client> Clients { get; set; }

        public void OnGet()
        {
            Clients = _context.Client.ToList();
        }
    }
}
