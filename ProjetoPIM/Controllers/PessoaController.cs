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
            return View(await _context.Pessoas.ToListAsync());
        }

        // GET: Employee/Create
        public IActionResult AddorEdit(int id = 0)
        {
            if (id == 0)
                return View(new Pessoa());
            else
                return View(_context.Pessoas.Find(id));
        }


        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddorEdit([Bind("Id , Nome, Cpf , Endereco")] Pessoa employee)
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

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await _context.Pessoas.FindAsync(id);
            _context.Pessoas.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
