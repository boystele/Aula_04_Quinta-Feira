using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViwesTipadas.Models;

namespace ViwesTipadas.Controllers
{
    public class funcaoController : Controller
    {
        // GET: funcao
        public ActionResult Lista()
        {
            List<FUNCAO> nomeDaLista = new List<FUNCAO>();
            
            nomeDaLista.Add(new FUNCAO() { FuncaoId = 1, Nome = "Dev", Salario = 700 });
            nomeDaLista.Add(new FUNCAO() { FuncaoId = 2, Nome = "Dev Junior", Salario = 750 });

            return View();

            /*
            FUNCAO F1 = new FUNCAO();
            F1.FuncaoId = 1;
            F1.Nome = "Desenvolvedor";
            F1.Salario = 700;


            FUNCAO F2 = new FUNCAO();
            F2.FuncaoId = 2;
            F2.Nome = "Desenvolvedor junior";
            F2.Salario = 750;  

            nomeDaLista.Add(F1);
            nomeDaLista.Add(F2);

            return View();*/
        }
    }
}