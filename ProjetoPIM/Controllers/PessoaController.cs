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
            var querys = from pessoa in _context.Pessoas
                         from endereco in _context.Enderecos
                         from pessoaTelefone in _context.PessoaTelefones
                         from telefone in _context.Telefones
                         from tipo in _context.TipoTelefones
                         where pessoa.EnderecoId == endereco.Id
                         && pessoaTelefone.IdPessoa == pessoa.Id
                         && pessoaTelefone.IdTelefone == telefone.Id
                         && tipo.Id == telefone.Tipo
                         select new PessoaEnderecoViewModel
                         {
                             Id = pessoa.Id,
                             Nome = pessoa.Nome,
                             Cpf = pessoa.Cpf,
                             DDD = telefone.Ddd,
                             NumeroTelefone = telefone.Numero,
                             TipoTelefone = tipo.Tipo,
                             Logradouro = endereco.Logradouro,
                             Numero = endereco.Numero,
                             Cep = endereco.Cep,
                             Bairro = endereco.Bairro,
                             Cidade = endereco.Cidade,
                             Estado = endereco.Estado,
                             EnderecoId = endereco.Id,
                             PessoaTelefoneId = pessoaTelefone.Id,
                             TelefoneId = telefone.Id,
                             TipoTelefoneId = tipo.Id
                         };

            return View(await querys.ToListAsync());
        }

        public IActionResult AddorEdit(int id = 0)
        {
            if (id == 0)
                return View(new PessoaEnderecoViewModel());
            else
            {
                var querys = from pessoa in _context.Pessoas
                             from endereco in _context.Enderecos
                             from pessoaTelefone in _context.PessoaTelefones
                             from telefone in _context.Telefones
                             from tipo in _context.TipoTelefones
                             where pessoa.Id == id
                             && pessoa.EnderecoId == endereco.Id
                             && pessoaTelefone.IdPessoa == pessoa.Id
                             && pessoaTelefone.IdTelefone == telefone.Id
                             && tipo.Id == telefone.Tipo
                             select new PessoaEnderecoViewModel
                             {
                                 Id = pessoa.Id,
                                 Nome = pessoa.Nome,
                                 Cpf = pessoa.Cpf,
                                 DDD = telefone.Ddd,
                                 NumeroTelefone = telefone.Numero,
                                 TipoTelefone = tipo.Tipo,
                                 Logradouro = endereco.Logradouro,
                                 Numero = endereco.Numero,
                                 Cep = endereco.Cep,
                                 Bairro = endereco.Bairro,
                                 Cidade = endereco.Cidade,
                                 Estado = endereco.Estado,
                                 EnderecoId = endereco.Id,
                                 PessoaTelefoneId = pessoaTelefone.Id,
                                 TelefoneId = telefone.Id,
                                 TipoTelefoneId = tipo.Id
                             };

                return View(querys.SingleOrDefault());
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddorEdit(
            [Bind("Id, Nome, Cpf,DDD, NumeroTelefone, TipoTelefone, Logradouro, Numero, Cep, Bairro, Cidade, Estado, EnderecoId, PessoaTelefoneId, TelefoneId, TipoTelefoneId")]
        PessoaEnderecoViewModel  viewModel)
        {
            if (ModelState.IsValid)
            {
                if (viewModel.Id == 0)
                {
                    return RedirectToAction(nameof(Index));
                }

                Endereco e = new Endereco
                {
                    Id = viewModel.EnderecoId,
                    Logradouro = viewModel.Logradouro,
                    Numero = viewModel.Numero,
                    Cep = viewModel.Cep,
                    Bairro = viewModel.Bairro,
                    Cidade = viewModel.Cidade,
                    Estado = viewModel.Estado
                };

                _context.Update(e);
                await _context.SaveChangesAsync();

                var pessoa = new Pessoa { 
                    Id = viewModel.Id,
                    Nome = viewModel.Nome, 
                    Cpf = viewModel.Cpf, 
                    EnderecoId = viewModel.EnderecoId };

                _context.Update(pessoa);
                await _context.SaveChangesAsync();

                var pessoaTelefone = new PessoaTelefone { Id = viewModel.PessoaTelefoneId, 
                                                        IdPessoa = viewModel.Id, IdTelefone = viewModel.TelefoneId };

                _context.Update(pessoaTelefone);
                await _context.SaveChangesAsync();

                var telefone = new Telefone {  
                                        Id = viewModel.TelefoneId,
                                        Ddd = viewModel.DDD, 
                                        Numero = viewModel.NumeroTelefone, 
                                        Tipo = viewModel.TipoTelefoneId };

                _context.Update(telefone);
                await _context.SaveChangesAsync();

                var tipo = new TipoTelefone { Id = viewModel.TipoTelefoneId,
                                            Tipo = viewModel.TipoTelefone };

                _context.Update(tipo);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
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
