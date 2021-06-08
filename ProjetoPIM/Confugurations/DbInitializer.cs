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
               new Endereco {  Logradouro = "Av Santos", Numero = 133, Cep = 1333333, Cidade = "SÃO PAULO", Estado = "SP", Bairro = "Jardins" },
               new Endereco {  Logradouro = "Rua Mogi Mirim", Numero = 200, Cep = 2444333, Cidade = "RIO DE JANEIRO", Estado = "RJ" , Bairro= "Copacabana" },
               new Endereco {  Logradouro = "Alameda Santos", Numero = 39, Cep = 323432334, Cidade = "MINAS GERAIS", Estado = "MG", Bairro = "TrÊs Corações" },
               new Endereco {  Logradouro = "Marginal Tiete", Numero = 4000, Cep = 444324333, Cidade = "BAHIA", Estado = "BA" , Bairro = "Salvador" }
            };

            foreach (var s in endereco)
            {
                context.Enderecos.Add(s);
            }

            context.SaveChanges();

            var pessoa = new List<Pessoa>
            {
                new Pessoa {  Nome = "Eric Evans", Cpf = 1234569, EnderecoId = 1  },
                new Pessoa {  Nome = "Robert C. Martin", Cpf = 98765, EnderecoId = 2 },
                new Pessoa { Nome = "Vaughn Vernon", Cpf = 12340, EnderecoId = 3 },
                new Pessoa {  Nome = "Martin Fowler", Cpf = 908755, EnderecoId = 4 }
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
                new Telefone {  Ddd = 66, Numero = 133432432, Tipo = 1 },
                new Telefone {  Ddd = 13 , Numero = 243432432, Tipo = 2 },
                new Telefone {  Ddd = 99 , Numero = 34324322, Tipo = 3 },
                new Telefone {  Ddd = 33, Numero = 432432432, Tipo = 3 }
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


            foreach (var s in tipo)
            {
                context.TipoTelefones.Add(s);
            }

            context.SaveChanges();
        }
    }
}
