using G2.CidadaoFiscal.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace G2.CidadaoFiscal.Infra.Repositorio.EF.EF_Configurations
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(e => e.UsuarioId);
            Property(e => e.UsuarioId).HasColumnName("ID");
            Property(e => e.NomeCompleto).HasColumnName("Nome_Completo");
            Property(e => e.DataNascimento).HasColumnName("Data_Nascimento");
            Property(e => e.Sexo).HasColumnName("Sexo");
            Property(e => e.RG).HasColumnName("RG");
            Property(e => e.CPF).HasColumnName("CPF");
            Property(e => e.Email).HasColumnName("Email");
            Property(e => e.Login).HasColumnName("Login");
            Property(e => e.Senha).HasColumnName("Senha");
            Property(e => e.Status).HasColumnName("Status");
            
            HasMany(m => m.Enderecos).WithRequired(r => r.Usuario).HasForeignKey(fk => fk.UsuarioId);

            HasMany(m => m.Denuncias).WithRequired(r => r.Usuario).HasForeignKey(fk => fk.UsuarioId);

            ToTable("Usuario");
        }
    }
}
