using Microsoft.AspNetCore.Mvc;
using SistemaVendas_MVC.Interfaces;
using SistemaVendas_MVC.Models;

namespace SistemaVendas_MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IActionResult Index()
        {
            return View(_clienteRepository.Read());
        }  

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            ClienteModel viewModel = new ClienteModel();

            if (id != null)
            {
                viewModel = _clienteRepository.Read((int)id);
            }

            return View(viewModel);
        } 
        
        [HttpPost]
        public IActionResult Cadastro(ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                _clienteRepository.Create(clienteModel);
            }

            else
            {
                return View(clienteModel);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int Id)
        {
            ViewData["idExcluir"] = Id;
            return View();
        }

        public IActionResult ExcluirCliente(int Id)
        {
            _clienteRepository.Delete(Id);
            return View();
        }
    }
}
