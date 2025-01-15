using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestingSQLite.Models;

class Program
{
    static void Main()
    {
        // Set up Dependency Injection
        var serviceProvider = new ServiceCollection()
            .AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(@"Data Source=Clients.db"))
            .AddScoped<IRepository<Client>, ClientRepository>()
            .AddScoped<IClientService, ClientService>()
            .BuildServiceProvider();

        // Resolve dependencies and run operations
        using (var scope = serviceProvider.CreateScope())
        {
            var clientService = scope.ServiceProvider.GetRequiredService<IClientService>();

            //// Add a sample client
            clientService.AddClient(new Client
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            });

            // Fetch and display all clients
            foreach (var client in clientService.GetAllClients())
            {
                Console.WriteLine($"ID: {client.ID}, Name: {client.FirstName} {client.LastName}, Email: {client.Email}");
            }
        }
    }
}
