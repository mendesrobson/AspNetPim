using ProjetoPIM.Context;
using ProjetoPIM.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoPIM.Confugurations
{
    public static class DbInitializer
    {
        public static void Initialize(SqlContext context)
        {
            context.Database.EnsureDeleted();

            context.Database.EnsureCreated();

            var endereco = new List<Endereco>
            {
               new Endereco {  Logradouro = "teste1", Numero = 1, Cep = 13333, Cidade = "teste1", Estado = "SP" },
               new Endereco {  Logradouro = "teste2", Numero = 2, Cep = 2444, Cidade = "teste2", Estado = "RJ" },
               new Endereco {  Logradouro = "teste3", Numero = 3, Cep = 3234324, Cidade = "teste3", Estado = "MG" },
               new Endereco {  Logradouro = "teste4", Numero = 4, Cep = 4443243, Cidade = "teste4", Estado = "BA" }
            };

            foreach (var s in endereco)
            {
                context.Enderecos.Add(s);
            }

            context.SaveChanges();

            var pessoa = new List<Pessoa>
            {
                new Pessoa {  Nome = "Eric Evans", Cpf = 1222, EnderecoId = 1  },
                new Pessoa {  Nome = "Robert C. Martin", Cpf = 2344, EnderecoId = 2 },
                new Pessoa { Nome = "Vaughn Vernon", Cpf = 3777, EnderecoId = 3 },
                new Pessoa {  Nome = "Martin Fowler", Cpf = 43432, EnderecoId = 4 }
            };


            foreach (var s in pessoa)
            {
                context.Pessoas.Add(s);

            }

            context.SaveChanges();

            var pessoaTelefone = new List<PessoaTelefone> {
                new PessoaTelefone { IdPessoa = 1, IdTelefone = 1 },
                new PessoaTelefone { IdPessoa = 2, IdTelefone = 2 },
                new PessoaTelefone { IdPessoa = 3, IdTelefone = 3 },
                new PessoaTelefone { IdPessoa = 4, IdTelefone = 4 }
            };

            foreach (var s in pessoaTelefone)
            {
                context.PessoaTelefones.Add(s);
            }

            context.SaveChanges();

            var telefone = new List<Telefone>
            {
                new Telefone {  Ddd = 1, Numero = 1, Tipo = 1 },
                new Telefone {  Ddd = 2 , Numero = 2, Tipo = 2 },
                new Telefone {  Ddd = 3 , Numero = 3, Tipo = 3 },
                new Telefone {  Ddd = 4 , Numero = 4, Tipo = 3 }
            };

            foreach (var s in telefone)
            {
                context.Telefones.Add(s);
            }

            context.SaveChanges();

            var tipo = new List<TipoTelefone>
            {
                 new TipoTelefone {  Tipo = "Celular" },
                new TipoTelefone {  Tipo = "Telefone Fixo" },
                new TipoTelefone {  Tipo = "Telefone Fax" },
                new TipoTelefone {  Tipo = "Telefone Residencial" }
            };


            foreach(var s in tipo)
            {
                context.TipoTelefones.Add(s);
            }

            context.SaveChanges();
        }
    }
}
