using System.ComponentModel.DataAnnotations;

namespace SistemaVendas_MVC.Models
{
    public class EntityBase
    {
        [Key]
        public int? Id { get; set; }
    }
}
