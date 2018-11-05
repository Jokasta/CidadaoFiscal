using G2.CidadaoFiscal.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace G2.CidadaoFiscal.Infra.Repositorio.EF.EF_Configurations
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.EnderecoId);
            Property(e => e.EnderecoId).HasColumnName("ID");
            Property(e => e.Rua).HasColumnName("Rua");
            Property(e => e.NumeroCasa).HasColumnName("Numero_Casa");
            Property(e => e.Bairro).HasColumnName("Bairro");
            Property(e => e.Cidade).HasColumnName("Cidade");
            Property(e => e.CEP).HasColumnName("CEP");
            Property(e => e.SiglaEstado).HasColumnName("Sigla_Estado");
            Property(e => e.UsuarioId).HasColumnName("Usuario_ID");

            ToTable("Endereco");
        }
    }
}
