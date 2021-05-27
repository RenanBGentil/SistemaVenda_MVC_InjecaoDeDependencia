using SistemaVendas_MVC.Uteis.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SistemaVendas_MVC.Models
{
    public class VendaModel : EntityBase
    {
        public DateTime Data { get; set; }
        public int? Cliente_Id { get; set; }
        public int? Vendedor_Id { get; set; }
        public IEnumerable<ProdutoModel> ListaProdutos { get; set; }
        public decimal TotalVenda { get; set; }
        public ICollection<ItemVendaModel> Produtos { get; set; }
    }
}