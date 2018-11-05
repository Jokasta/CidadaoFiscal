using G2.CidadaoFiscal.Core.Interfaces;
using G2.CidadaoFiscal.Core.Models;
using G2.CidadaoFiscal.Infra.Repositorio.EF;
using Ninject;
using System;
using System.Reflection;
using System.Web.Mvc;

namespace G2.CidadaoFiscal.Web.Controllers
{
    public class HomeController : Controller
    {
        public IUsuarioEF UsuarioEF { get; set; }
        public IEnderecoEF EnderecoEF { get; set; }

        public HomeController()
        {
            IKernel _Kernal = new StandardKernel();
            _Kernal.Load(Assembly.GetExecutingAssembly());
            UsuarioEF = _Kernal.Get<IUsuarioEF>();
            EnderecoEF = _Kernal.Get<IEnderecoEF>();
        }

        public ActionResult Index()
        {
            //exemplos de consumo do crud;
            //var usuario = null as Usuario;
            
            //UsuarioEF.CreateUsuario(new Usuario
            //{
            //    UsuarioId = Guid.NewGuid(),
            //    NomeCompleto = "Jokasta",
            //    DataNascimento = DateTime.Parse("1991-06-16"),
            //    Sexo = "F",
            //    RG = "123435",
            //    CPF = "edjgnewpr",
            //    Email = "jokasta.design@gmail.com",
            //    Login = "jokasta.design",
            //    Senha = "123",
            //    Status = true
            //});

            //usuario = UsuarioEF.GetUsuarioLoginSenha("jokasta.design", "123");

            //EnderecoEF.CreateEndereco(new Endereco
            //{
            //    EnderecoId = Guid.NewGuid(),
            //    Rua = "rua teste",
            //    NumeroCasa = 123,
            //    Bairro = "bairro teste",
            //    Cidade = "LS",
            //    CEP = "33400000",
            //    SiglaEstado = "MG",
            //    UsuarioId = usuario.UsuarioId
            //});




            return View(new Usuario());
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}