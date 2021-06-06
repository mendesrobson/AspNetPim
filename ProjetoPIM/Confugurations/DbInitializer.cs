using ProjetoPIM.Context;
using ProjetoPIM.Models;
using System;
using System.Linq;

namespace ProjetoPIM.Confugurations
{
    public static class DbInitializer
    {
        public static void Initialize(SqlContext context)
        {
            context.Database.EnsureCreated();

            var pessoas = new Pessoa[]
            {
                new Pessoa{Nome="Carson",Cpf=12345677,Endereco=1,Id=1},
                new Pessoa{Nome="Meredith",Cpf=0987654,Endereco=2,Id=2},
                new Pessoa{Nome="Arturo",Cpf=896896896896934,Endereco=3,Id = 3},
                new Pessoa{Nome="Gytis",Cpf=43074032704,Endereco=4,Id = 4},
                new Pessoa{Nome="Yan",Cpf=43024037202,Endereco=5, Id = 5},
                new Pessoa{Nome="Peggy",Cpf=897947543,Endereco=6 , Id = 6},
                new Pessoa{Nome="Laura",Cpf=9709231120,Endereco=7 , Id = 7},
            };

            var endereco = new Endereco[]
            {
                new Endereco{Logradouro="Carson",Numero=1,Cep=1,Id=1,Cidade="teste1",Estado="teste1"},
                new Endereco{Logradouro="Meredith",Numero=2,Cep=2,Id=2,Cidade="teste2",Estado="teste2"},
                new Endereco{Logradouro="Arturo",Numero=3,Cep=3,Id = 3,Cidade="teste3",Estado="teste3"},
                new Endereco{Logradouro="Gytis",Numero=4,Cep=4,Id = 4,Cidade="teste4",Estado="teste4"},
                new Endereco{Logradouro="Yan",Numero=5,Cep=5, Id = 5,Cidade="teste5",Estado="teste5"},
                new Endereco{Logradouro="Peggy",Numero=6,Cep=6 , Id = 6,Cidade="teste6",Estado="teste6"},
                new Endereco{Logradouro="Laura",Numero=7,Cep=7 , Id = 7,Cidade="teste7",Estado="teste7"},
            };


            var Pe = new PessoaTelefone[]
             {
                new PessoaTelefone{IdPessoa=1,IdTelefone=1},
                new PessoaTelefone{IdPessoa=2,IdTelefone=2},
                new PessoaTelefone{IdPessoa=3,IdTelefone = 3},
                new PessoaTelefone{IdPessoa=4,IdTelefone = 4},
                new PessoaTelefone{IdPessoa=5,IdTelefone = 5},
                new PessoaTelefone{IdPessoa=6,IdTelefone = 6},
                new PessoaTelefone{IdPessoa=7,IdTelefone = 7},
             };

            var tt = new TipoTelefone[]
             {
                new TipoTelefone{Id=1,Tipo="teste1"},
                new TipoTelefone{Id=2,Tipo="teste2"},
                new TipoTelefone{Id=3,Tipo="teste3"},
                new TipoTelefone{Id=4,Tipo="teste4"},
                new TipoTelefone{Id=5,Tipo="teste5"},
                new TipoTelefone{Id=6,Tipo="teste6"},
                new TipoTelefone{Id=7,Tipo="teste7"},
             };

            var telefone = new Telefone[]
            {
                new Telefone{Id=1,Numero=1,Ddd=1},
                new Telefone{Id=2,Numero=2,Ddd=2},
                new Telefone{Id=3,Numero=3,Ddd=3},
                new Telefone{Id=4,Numero=4,Ddd=4},
                new Telefone{Id=5,Numero=5,Ddd=5},
                new Telefone{Id=6,Numero=6,Ddd=6},
                new Telefone{Id=7,Numero=7,Ddd=7},
            };

            foreach (Telefone s in telefone)
            {
                context.Telefones.Add(s);
            }

            foreach (TipoTelefone s in tt)
            {
                context.TipoTelefones.Add(s);
            }

            foreach (PessoaTelefone s in Pe)
            {
                context.PessoaTelefones.Add(s);
            }

            foreach (Pessoa s in pessoas)
            {
                context.Pessoas.Add(s);
            }

            foreach (Endereco s in endereco)
            {
                context.Enderecos.Add(s);
            }

            context.SaveChanges();
        }
    }
}
