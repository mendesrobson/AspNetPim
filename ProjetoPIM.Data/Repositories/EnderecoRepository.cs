using ProjetoPIM.Data.Context;
using ProjetoPIM.Data.Repositories.Common;
using ProjetoPIM.Domain.Models;
using ProjetoPIM.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPIM.Data.Repositories
{
    public class EnderecoRepository: RepositoryBase<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext context) : base(context) { }
    }
}
