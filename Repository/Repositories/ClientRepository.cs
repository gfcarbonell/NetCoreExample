using Domain;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Client> Get()
        {
            var clients = new HashSet<Client>()
            {
                new Client()
                {
                    ClientId = 1, 
                    Name = "Nicole Dayana Rojas Torres"
                }, 
                new Client()
                {
                    ClientId = 2, 
                    Name = "Carbonell Saravia, Roberto Gian Franco"
                },
                new Client()
                {
                    ClientId = 3,
                    Name = "Milena Bende"
                }
            };

            return clients;
        }

        public Client Post(Client t)
        {
            throw new NotImplementedException();
        }

        public Client Put(Client t)
        {
            throw new NotImplementedException();
        }
    }
}
