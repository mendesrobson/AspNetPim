using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Models
{
    public class Endereco
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("LOGRADOURO", TypeName = "varchar(100)")]
        public string Logradouro { get; set; }

        [Column("NUMERO")]
        public int Numero { get; set; }

        [Column("CEP")]
        public int Cep { get; set; }

        [Column("BAIRRO", TypeName = "varchar(100)")]
        public string Bairro { get; set; }

        [Column("CIDADE", TypeName = "varchar(100)")]
        public string Cidade { get; set; }

        [Column("ESTADO", TypeName = "varchar(100)")]
        public string Estado { get; set; }

        public virtual ICollection<Pessoa>  Pessoas { get; set; }
    }
}
