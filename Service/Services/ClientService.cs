using Domain;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ClientService : IClientService
    {
        readonly IClientRepository IClientRepository;

        public ClientService(IClientRepository IClientRepository)
        {
            this.IClientRepository = IClientRepository;
        }
        public bool Delete(int id)
        {
            return this.IClientRepository.Delete(id);
        }
        public ICollection<Client> Get()
        {
            return this.IClientRepository.Get();
        }
        public Client Post(Client t)
        {
            return this.IClientRepository.Post(t);
        }
        public Client Put(Client t)
        {
            return this.IClientRepository.Put(t);
        }
    }
}
