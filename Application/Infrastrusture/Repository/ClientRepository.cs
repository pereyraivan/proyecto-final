using Domain.Entities;
using Domain.Interfaces;
using Infrastrusture.DataBase;

namespace Infrastrusture.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly SqlServerContext _context;
        public ClientRepository(SqlServerContext context)
        {
            _context = context;
           
        }
        public List<Client> GetClients()
        {
            var listClient = _context.Clients.Where(x => x.id_cliente != 1).ToList();
            return listClient;
            
        }
        public Client GetClientById(int id)
        {
            var client = _context.Clients.Where(x => x.id_cliente == id).SingleOrDefault();
            return client;
        }
    }
}
