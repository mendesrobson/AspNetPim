using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Domain.Models
{
    public class PessoaTelefone
    {
        [Column("ID_PESSOA")]
        public int IdPessoa { get; set; }

        [Column("ID_TELEFONE")]
        public int IdTelefone { get; set; }

       // public virtual Pessoa Pessoa { get; set; }

       // public virtual Telefone Telefone { get; set; }
    }
}
