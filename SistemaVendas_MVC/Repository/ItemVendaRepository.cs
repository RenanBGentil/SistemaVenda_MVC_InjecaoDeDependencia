using Microsoft.EntityFrameworkCore;
using SistemaVendas_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas_MVC.Repository
{
    public class ItemVendaRepository : IItemVendaReposiyory
    {
        private readonly ApplicationDbContext _dbContext;

        public ItemVendaRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(ItemVendaModel itemVenda)
        {
            if (itemVenda.Produto_Id == null && itemVenda.Venda_Id == null)
            {
                _dbContext.ItemVendas.Add(itemVenda);
            }
            else
            {
                _dbContext.Entry(itemVenda).State = EntityState.Modified;
            }

            _dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public ItemVendaModel Read(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemVendaModel> Read()
        {
            throw new NotImplementedException();
        }
    }
}
