using SistemaVendas_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas_MVC.Interfaces
{
    public interface IVendaRepository 
    {
        void Create(VendaModel vendaModel);
        VendaModel Read(int Id);
        void Delete(int Id);
        IEnumerable<VendaModel> Read();
        IEnumerable<GraficoProdutos> ListaGrafico();
        IEnumerable<GraficoProdutos> RetornarGrafico();
    }
}
