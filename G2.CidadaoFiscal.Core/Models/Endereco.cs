using System;

namespace G2.CidadaoFiscal.Core.Models
{
    public class Endereco
    {
        public Guid EnderecoId { get; set; }
        public string Rua { get; set; }
        public int NumeroCasa { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string SiglaEstado { get; set; }
        public Guid UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
