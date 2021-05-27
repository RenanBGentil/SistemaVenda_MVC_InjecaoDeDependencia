using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVendas_MVC.Models
{
    public class ProdutoModel : EntityBase
    {

        [Required(ErrorMessage ="Informe o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição")]
        public string Descricao { get; set; }        
        
        [Required(ErrorMessage = "Informe o preco_unitairo")]
        public decimal? Preco_Unitario { get; set; }        
        
        [Required(ErrorMessage = "Informe a quantidade em estoque")]
        public float? Quantidade_Estoque { get; set; }
                
        [Required(ErrorMessage = "Informe a unidade de medida")]
        public string Unidade_Medida { get; set; }
                
        [Required(ErrorMessage = "Informe o link da foto")]
        public string Link_Foto { get; set; }

        public ICollection<ItemVendaModel> Vendas { get; set; }
    }
}
