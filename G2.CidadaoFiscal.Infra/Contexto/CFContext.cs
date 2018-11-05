using G2.CidadaoFiscal.Core.Models;
using G2.CidadaoFiscal.Infra.Repositorio.EF.EF_Configurations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace G2.CidadaoFiscal.Infra.Contexto
{
    public class CFContext : DbContext
    {
        public CFContext() : base("CIDADAO_FISCAL_CONNECTION")
        { }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Denuncia> Denuncias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<CFContext>(null);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new DenunciaConfiguration());
        }
    }
}
