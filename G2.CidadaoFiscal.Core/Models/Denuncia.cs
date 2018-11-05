using System;

namespace G2.CidadaoFiscal.Core.Models
{
    public class Denuncia
    {
        public Guid DenunciaId { get; set; }
        public DateTime DataHora { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string SiglaEstado { get; set; }
        public string CEP { get; set; }
        public string CategoriaDenuncia { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
        public Guid UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
