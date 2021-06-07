using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoPIM.Domain.Models;
using ProjetoPIM.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Controllers
{
    public class PessoaController: Controller
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IActionResult Index() =>
            View(_pessoaRepository.GetAll());


        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var autor = _pessoaRepository.GetById(id);
            if (autor == null)
                return NotFound();

            return View(autor);
        }

        public IActionResult Create() =>
            View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nome,Cpf,Endereco")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _pessoaRepository.Add(pessoa);
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        // GET: Autor/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var autor = _pessoaRepository.GetById(id);
            if (autor == null)
                return NotFound();

            return View(autor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Nome,Cpf,Endereco")] Pessoa pessoa)
        {
            if (id != pessoa.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _pessoaRepository.Update(pessoa);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutorExists(pessoa.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        // GET: Autor/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var autor = _pessoaRepository.GetById(id);
            if (autor == null)
                return NotFound();

            return View(autor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var autor = _pessoaRepository.GetById(id);
            _pessoaRepository.Remove(autor);
            return RedirectToAction(nameof(Index));
        }

        private bool AutorExists(int id) =>
            _pessoaRepository.GetById(id) != null;

        private bool _disposed = false;

        ~PessoaController() =>
            Dispose(false);

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _pessoaRepository.Dispose();
                base.Dispose(disposing);
                _disposed = true;
            }
            GC.SuppressFinalize(this);
        }
    }
}
