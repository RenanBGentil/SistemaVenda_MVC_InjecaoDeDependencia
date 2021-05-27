using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVendas_MVC.Models
{
    public class ItemVendaModel
    {
        public int Produto_Id { get; set; }
        public int Venda_Id { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal QtdeProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public decimal TotalVenda { get; set; }
        public VendaModel Venda { get; set; }
        public ProdutoModel Produto { get; set; }
        public double QtdeVendido { get; set; }
    }
}
