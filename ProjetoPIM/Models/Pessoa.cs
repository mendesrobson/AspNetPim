using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Models
{
    public class Pessoa
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NOME", TypeName = "varchar(100)")]
        public string Nome { get; set; }

        [Column("CPF")]
        public float Cpf { get; set; }

        [ForeignKey("EnderecoId")]
        public int? EnderecoId { get; set; }

       //public virtual ICollection<PessoaTelefone> pessoaTelefones { get; set; } = new List<PessoaTelefone>();
    }
}
