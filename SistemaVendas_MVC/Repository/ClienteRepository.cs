using Microsoft.EntityFrameworkCore;
using SistemaVendas_MVC.Interfaces;
using SistemaVendas_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaVendas_MVC.Repository
{
	public class ClienteRepository : IClienteRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public ClienteRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Create(ClienteModel cliente)
		{
            if (cliente.Id == null)
            {
				_dbContext.Clientes.Add(cliente);
            }
            else
            {
				_dbContext.Entry(cliente).State = EntityState.Modified;
            }

			_dbContext.SaveChanges();
		}

		public void Delete(int Id)
		{
			var ent = new ClienteModel { Id = Id };
			_dbContext.Attach(ent);
			_dbContext.Remove(ent);
			_dbContext.SaveChanges();
		}

		public ClienteModel Read(int id)
		{
			return _dbContext.Clientes.Where(x => x.Id == id).FirstOrDefault();
		}

 

        public IEnumerable<ClienteModel> Read()
		{
			return _dbContext.Clientes.AsNoTracking().ToList();
		}
    }
}
