﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Models
{
    public class TipoTelefone
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("TIPO", TypeName = "varchar(100)")]
        public string Tipo { get; set; }

        //public virtual ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();
    }
}
