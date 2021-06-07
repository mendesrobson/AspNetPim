using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoPIM.Domain.Models
{
    public class TipoTelefone
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("TIPO", TypeName = "varchar(100)")]
        public string Tipo { get; set; }

        //public virtual ICollection<Telefone>  Telefones { get; set; }
    }
}
