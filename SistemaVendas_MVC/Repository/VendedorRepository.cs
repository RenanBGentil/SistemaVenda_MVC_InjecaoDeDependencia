using Microsoft.EntityFrameworkCore;
using SistemaVendas_MVC.Interfaces;
using SistemaVendas_MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaVendas_MVC.Repository
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public VendedorRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(VendedorModel vendedorModel)
        {
            if (vendedorModel.Id == null)
            {
                _dbContext.Vendedores.Add(vendedorModel);
            }
            else
            {
                _dbContext.Entry(vendedorModel).State = EntityState.Modified;
            }

            _dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var ent = new VendedorModel { Id = Id };
            _dbContext.Attach(ent);
            _dbContext.Remove(ent);
            _dbContext.SaveChanges();
        }

        public VendedorModel Read(int Id)
        {
            return _dbContext.Vendedores.Where(x => x.Id == Id).FirstOrDefault();
        }

        public IEnumerable<VendedorModel> Read()
        {
            return _dbContext.Vendedores.AsNoTracking().ToList();
        }

        public bool ValidarLogin(string email, string senha)
        {
            var vendedor = _dbContext.Vendedores.Where(x => x.Email == email && x.Senha.ToUpper() == senha.ToUpper()).FirstOrDefault();
            return (vendedor == null) ? false : true;
        }

        public VendedorModel RetornarDadosDoUsuario(string email, string senha)
        {
            return _dbContext.Vendedores.Where(x => x.Email == email && x.Senha.ToUpper() == senha.ToUpper()).FirstOrDefault();
        }

    }
}
