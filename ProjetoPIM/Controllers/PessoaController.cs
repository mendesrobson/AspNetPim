using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoPIM.Context;
using ProjetoPIM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Controllers
{
    public class PessoaController : Controller
    {
        private readonly SqlContext _context;

        public PessoaController(SqlContext sqlContext)
        {
            _context = sqlContext;
        }

        public async Task<IActionResult> Index()
        {
            var query = (from Pessoa in _context.Pessoas
                         join endereco in _context.Enderecos on Pessoa.EnderecoId equals endereco.Id
                         where endereco.Id == Pessoa.EnderecoId
                         select new PessoaEnderecoViewModel
                         {
                             Id = Pessoa.Id,
                             Cpf = Pessoa.Cpf,
                             Enderecos = new EnderecoViewModel
                              {
                                Logradouro = endereco.Logradouro,
                                Numero = endereco.Numero,
                                Cidade = endereco.Cidade
                              }
                         });
            //var result = await query.ToListAsync();

            var testw = await query.ToListAsync();

            return View(await _context.Pessoas.ToListAsync());
            //return View(await _context.Pessoas.ToListAsync());
        }

        public IActionResult AddorEdit(int id = 0)
        {
            if (id == 0)
                return View(new Pessoa());
            else
                return View(_context.Pessoas.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddorEdit([Bind("Id , Nome, Cpf , EnderecoId")] Pessoa employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Id == 0)
                    _context.Add(employee);
                else
                    _context.Update(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await _context.Pessoas.FindAsync(id);
            _context.Pessoas.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
