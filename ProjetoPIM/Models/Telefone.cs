using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Models
{
    public class Telefone
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("NUMERO")]
        public int Numero { get; set; }

        [Column("DDD")]
        public int Ddd { get; set; }

        [Column("TIPO")]
        public int Tipo { get; set; }

        public virtual ICollection<PessoaTelefone> pessoaTelefones { get; set; }
    }
}
