using ProjetoPIM.Data.Context;
using ProjetoPIM.Data.Repositories.Common;
using ProjetoPIM.Domain.Models;
using ProjetoPIM.Domain.Repositories;

namespace ProjetoPIM.Data.Repositories
{
    public class TelefoneRepository : RepositoryBase<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(AppDbContext context) : base(context) { }
    }
}
