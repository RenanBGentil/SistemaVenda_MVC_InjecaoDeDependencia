using MySql.Data.MySqlClient;
using SistemaVendas_MVC.Uteis.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas_MVC.Models
{
    public class LoginModel
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        [Required(ErrorMessage ="Informe o seu email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a sua senha!")]
        public string Senha { get; set; }
    }
}
