using System;
using System.Collections.Generic;

namespace G2.CidadaoFiscal.Core.Models
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<Denuncia> Denuncias { get; set; }
    }
}
