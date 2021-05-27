 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Helpers;
using SistemaVendas_MVC.Interfaces;
using SistemaVendas_MVC.Models;
using SistemaVendas_MVC.Uteis.DAL;

namespace SistemaVendas_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IVendedorRepository _vendedorRepository;
        public HomeController(IHttpContextAccessor httpContextAccessor, IVendedorRepository vendedorRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _vendedorRepository = vendedorRepository;
        }
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Login(int? id)
        {
            if (id != null)
            {
                if (id == 0)
                {
                    _httpContextAccessor.HttpContext.Session.Clear();
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            ViewData["ErroLogin"] = string.Empty;
            if (ModelState.IsValid)
            {

                bool validarLogin = _vendedorRepository.ValidarLogin(login.Email, login.Senha);
                var vendedor = _vendedorRepository.RetornarDadosDoUsuario(login.Email, login.Senha);
                if (validarLogin)
                {
                    _httpContextAccessor.HttpContext.Session.SetString(Sessao.NOME_USUARIO, vendedor.Nome);
                    _httpContextAccessor.HttpContext.Session.SetString(Sessao.EMAIL_USUARIO, vendedor.Email);
                    _httpContextAccessor.HttpContext.Session.SetInt32(Sessao.CODIGO_USUARIO, (int)vendedor.Id);
                    _httpContextAccessor.HttpContext.Session.SetInt32(Sessao.LOGADO_USUARIO, 1);
                    return RedirectToAction("Menu");


                }
                else
                {
                    ViewData["ErroLogin"] = "O usuario ou senha não existe no sistema";
                    return View(login);
                }

            }
            else
            {
                return View();
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
