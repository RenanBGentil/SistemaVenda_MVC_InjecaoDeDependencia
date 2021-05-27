using Microsoft.AspNetCore.Mvc;
using SistemaVendas_MVC.Interfaces;
using SistemaVendas_MVC.Models;

namespace SistemaVendas_MVC.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IVendedorRepository _vendedoresRepository;

        public VendaController(
        IVendaRepository vendaRepository,
        IClienteRepository clienteRepository,  
        IProdutoRepository produtoRepository, 
        IVendedorRepository vendedoresRepository)
        {
            _vendaRepository = vendaRepository;
            _clienteRepository = clienteRepository;
            _produtoRepository = produtoRepository;
            _vendedoresRepository = vendedoresRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
           
            return View(_vendaRepository.Read());
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            CarregarDados();
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(VendaModel vendaModel)
        {
            VendedorModel vendedorModel = new VendedorModel();
            vendaModel.Vendedor_Id = vendedorModel.Id;
            _vendaRepository.Create(vendaModel);
            CarregarDados();
            return View();
        }

        private void CarregarDados()
        {
            ViewBag.ListaClientes = _clienteRepository.Read() ;
            ViewBag.ListaVendedores = _vendedoresRepository.Read();
            ViewBag.ListaProdutos = _produtoRepository.Read();
        }
    }
}
