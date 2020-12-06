using GerCondominiosMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerCondominiosMVC.Controllers
{
    public class FuncoesController : Controller
    {
        public IActionResult Index()
        {
            List<Funcao> list = new List<Funcao>();
            list.Add(new Funcao { Id_Funcao = 1, Nome = "Administrador" });
            list.Add(new Funcao { Id_Funcao = 2, Nome = "Sindico" });
            list.Add(new Funcao { Id_Funcao = 3, Nome = "Morador" });

            return View(list);
        }
    }
}
