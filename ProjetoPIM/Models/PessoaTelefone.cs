using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Models
{
    public class PessoaTelefone
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("ID_PESSOA")]
        public int IdPessoa { get; set; }

        [Column("ID_TELEFONE")]
        public int IdTelefone { get; set; }
    }
}
