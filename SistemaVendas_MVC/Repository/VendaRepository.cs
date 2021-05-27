using Microsoft.EntityFrameworkCore;
using SistemaVendas_MVC.Interfaces;
using SistemaVendas_MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaVendas_MVC.Repository
{
    public class VendaRepository : IVendaRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public VendaRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(VendaModel vendaModel)
        {
            if (vendaModel.Id == null)
            {
                _dbContext.Vendas.Add(vendaModel);
            }
            else
            {
                _dbContext.Entry(vendaModel).State = EntityState.Modified;
            }

            _dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var ent = new VendaModel { Id = Id };
            _dbContext.Attach(ent);
            _dbContext.Remove(ent);
            _dbContext.SaveChanges();
        }

        public IEnumerable<GraficoProdutos> ListaGrafico()
        {
            var lista = _dbContext.ItemVendas.Include(x => x.Produto).GroupBy(x => x.Produto_Id)
                  .Select(y => new GraficoProdutos
                  {
                      CodProduto = y.First().Produto_Id,
                      DescricaoProduto = y.First().Produto.Descricao,
                      QtdeVendido = y.Sum(z => z.QtdeVendido)
                      
                  }).ToList();
            return lista;
        }



        public IEnumerable<GraficoProdutos> RetornarGrafico()
        {
            List<GraficoProdutos> lista = new List<GraficoProdutos>();
            var aux = ListaGrafico();

            foreach (var item in aux)
            {
                GraficoProdutos graficoViewModel = new GraficoProdutos()
                {
                    CodProduto = item.CodProduto,
                    DescricaoProduto = item.DescricaoProduto,
                    QtdeVendido = item.QtdeVendido
                };

                lista.Add(graficoViewModel);
            }

            return lista;
        }

        public VendaModel Read(int Id)
        {
            return _dbContext.Vendas.Where(x => x.Id == Id).FirstOrDefault();
        }

        public IEnumerable<VendaModel> Read()
        {
            return _dbContext.Vendas.AsNoTracking().ToList();
        }
    }
}
