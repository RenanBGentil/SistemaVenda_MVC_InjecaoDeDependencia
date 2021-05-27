using SistemaVendas_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas_MVC.Interfaces
{
    public interface IVendedorRepository 
    {
        void Create(VendedorModel vendedorModel);
        VendedorModel Read(int Id);
        void Delete(int Id);
        IEnumerable<VendedorModel> Read();
        bool ValidarLogin(string email, string senha);
        VendedorModel RetornarDadosDoUsuario(string email, string senha);
    }
}
