using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas_MVC.Interfaces;
using SistemaVendas_MVC.Models;

namespace SistemaVendas_MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            
            return View(_produtoRepository.Read());
        }  

        [HttpGet]
        public IActionResult Cadastro(int? id)
        {
            ProdutoModel model = new ProdutoModel();

            if (id != null)
            {
                model = _produtoRepository.Read((int)id);
            }

            return View(model);
        } 
        
        [HttpPost]
        public IActionResult Cadastro(ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                _produtoRepository.Create(produtoModel);
                
            }
            else
            {
                return View(produtoModel);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int Id)
        {
            ViewData["idExcluir"] = Id;
            return View();
        }

        public IActionResult ExcluirProduto(int Id)
        {
            _produtoRepository.Delete(Id);
            return View();
        }

    }
}