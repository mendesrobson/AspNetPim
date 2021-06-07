using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Models
{
    public class Pessoa
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("NOME", TypeName = "varchar(100)")]
        public string Nome { get; set; }

        [Column("CPF")]
        public float Cpf { get; set; }

        [Column("ENDERECO")]
        public int Endereco { get; set; }

       public virtual ICollection<PessoaTelefone> pessoaTelefones { get; set; } = new List<PessoaTelefone>();
    }
}
