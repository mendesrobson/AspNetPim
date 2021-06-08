using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Models
{
    public class PessoaEnderecoViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public float Cpf { get; set; }

        public int DDD { get; set; }

        public int NumeroTelefone { get; set; }

        public string TipoTelefone { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public int Cep { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int EnderecoId { get; set; }
        public int PessoaTelefoneId { get; set; }
        public int TelefoneId { get; set; }
        public int TipoTelefoneId { get; set; }
    }
}
