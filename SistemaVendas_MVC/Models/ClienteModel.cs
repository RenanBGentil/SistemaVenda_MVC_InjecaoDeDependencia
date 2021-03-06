using System.ComponentModel.DataAnnotations;

namespace SistemaVendas_MVC.Models
{
    public class ClienteModel : EntityBase
    {

        [Required(ErrorMessage ="Informe o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o CPF/CNPJ")]
        public string Cpf_Cnpj { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="O e-mail informado é inválido")]
        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
