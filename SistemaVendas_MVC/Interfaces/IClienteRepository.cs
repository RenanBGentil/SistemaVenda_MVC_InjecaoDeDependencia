using SistemaVendas_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas_MVC.Interfaces
{
    public interface IClienteRepository 
    {
        void Create(ClienteModel cliente);
        ClienteModel Read(int id);
        void Delete(int Id);
        IEnumerable<ClienteModel> Read();
    }
}
