using G2.CidadaoFiscal.Core.Interfaces;
using G2.CidadaoFiscal.Infra.Repositorio.EF;
using Ninject.Modules;

namespace G2.CidadaoFiscal.Web.Ninject
{
    public class Binding : NinjectModule
    {
        public override void Load()
        {
            Bind<IUsuarioEF>().To<UsuarioEF>();
            Bind<IEnderecoEF>().To<EnderecoEF>();
        }
    }
}