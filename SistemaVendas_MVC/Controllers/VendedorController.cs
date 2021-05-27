using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas_MVC.Interfaces;
using SistemaVendas_MVC.Models;

namespace SistemaVendas_MVC.Controllers
{
    public class VendedorController : Controller
    {
        private readonly IVendedorRepository _vendedoresRepository;

        public VendedorController(IVendedorRepository vendedoresRepository)
        {
            _vendedoresRepository = vendedoresRepository;
        }

        public IActionResult Index()
        {
            
            return View(_vendedoresRepository.Read());
        }  

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            VendedorModel model = new VendedorModel();
            if (id != null)
            {
               model =  _vendedoresRepository.Read((int)id);
            }

            return View(model);
        } 
        
        [HttpPost]
        public IActionResult Cadastro(VendedorModel vendedorModel)
        {
            if (ModelState.IsValid)
            {
               _vendedoresRepository.Create(vendedorModel);
                
            }
            else
            {
                return View(vendedorModel);

            }

            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int id)
        {
            ViewData["idExcluir"] = id;
            return View();
        }   
        
        public IActionResult ExcluirVendedor(int id)
        {
            _vendedoresRepository.Delete(id);
            return View();
        }
    }
}
