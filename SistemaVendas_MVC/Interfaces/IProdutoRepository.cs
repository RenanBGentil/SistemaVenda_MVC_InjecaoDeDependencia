using SistemaVendas_MVC.Models;
using System.Collections.Generic;

namespace SistemaVendas_MVC.Interfaces
{
    public interface IProdutoRepository 
    {
        void Create(ProdutoModel produto);
        ProdutoModel Read(int id);
        void Delete(int id);
        IEnumerable<ProdutoModel> Read();
    }
}
