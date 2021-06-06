using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoPIM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Controllers
{

    /// <summary>
    ///  documentacao para criacao da api e asp net migration etc...
    ///  https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/crud?view=aspnetcore-5.0
    /// </summary>
    public class CadastroPessoaController : Controller
    {
        private readonly SqlContext _context;

        public CadastroPessoaController(SqlContext sqlContext)
        {
            _context = sqlContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Pessoas.ToListAsync());
        }

        public IActionResult Criar()
        {
            return View();
        }

        //public IActionResult Editar(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    Cliente cliente = db.Clientes.Find(id);

        //    return View(cliente);
        //}
    }
}
