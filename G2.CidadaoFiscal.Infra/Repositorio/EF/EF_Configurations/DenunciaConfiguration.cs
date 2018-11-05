using G2.CidadaoFiscal.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace G2.CidadaoFiscal.Infra.Repositorio.EF.EF_Configurations
{
    public class DenunciaConfiguration : EntityTypeConfiguration<Denuncia>
    {
        public DenunciaConfiguration()
        {
            HasKey(e => e.DenunciaId);
            Property(e => e.DenunciaId).HasColumnName("ID");
            Property(e => e.DataHora).HasColumnName("Data_Hora");
            Property(e => e.Rua).HasColumnName("Rua");
            Property(e => e.Bairro).HasColumnName("Bairro");
            Property(e => e.Cidade).HasColumnName("Cidade");
            Property(e => e.SiglaEstado).HasColumnName("Sigla_Estado");
            Property(e => e.CEP).HasColumnName("CEP");
            Property(e => e.CategoriaDenuncia).HasColumnName("Categoria_Denuncia");
            Property(e => e.Descricao).HasColumnName("Descricao");
            Property(e => e.Status).HasColumnName("Status");
            Property(e => e.UsuarioId).HasColumnName("Usuario_ID");

            ToTable("Denuncia");
        }
    }
}
