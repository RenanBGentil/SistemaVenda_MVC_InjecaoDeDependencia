using Microsoft.EntityFrameworkCore;
using SistemaVendas_MVC.Interfaces;
using SistemaVendas_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaVendas_MVC.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
		private readonly ApplicationDbContext _dbContext;

		public ProdutoRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Create(ProdutoModel produto)
		{
			if (produto.Id == null)
			{
				_dbContext.Add(produto);
			}
			else
			{
				_dbContext.Entry(produto).State = EntityState.Modified;
			}

			_dbContext.SaveChanges();
		}

        public void Delete(int id)
        {
			var ent = new ProdutoModel { Id = id };
			_dbContext.Attach(ent);
			_dbContext.Remove(ent);
			_dbContext.SaveChanges();
		}

        public ProdutoModel Read(int id)
		{
			return _dbContext.Produtos.Where(x => x.Id == id).FirstOrDefault();
		}

        public IEnumerable<ProdutoModel> Read()
        {
			return _dbContext.Produtos.ToList();
        }
    }
}
