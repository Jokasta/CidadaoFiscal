using G2.CidadaoFiscal.Core.Interfaces;
using G2.CidadaoFiscal.Core.Models;
using G2.CidadaoFiscal.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace G2.CidadaoFiscal.Infra.Repositorio.EF
{
    public class UsuarioEF : IUsuarioEF
    {
        private CFContext Context { get; set; }

        public void CreateUsuario(Usuario usuario)
        {
            using (Context = new CFContext())
            {
                Context.Usuarios.Add(usuario);
                Context.SaveChanges();
            }
        }

        public void DeleteUsuario(Usuario usuario)
        {
            using (Context = new CFContext())
            {
                Context.Entry(usuario).State = EntityState.Deleted;
                Context.SaveChanges();
            }
        }

        public Usuario GetUsuario(Guid usuarioId)
        {
            var usuario = null as Usuario;

            using (Context = new CFContext())
            {
                usuario =  Context.Usuarios.Find(usuarioId);
            }
            
            return usuario;
        }

        public Usuario GetUsuarioLoginSenha(string login, string senha)
        {
            var usuario = null as Usuario;

            using (Context = new CFContext())
            {
                usuario = Context.Usuarios.Where(p => p.Login == login && p.Senha == senha).FirstOrDefault();
            }

            return usuario;
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            var usuarios = null as IEnumerable<Usuario>;

            using (Context = new CFContext())
            {
                usuarios = Context.Usuarios.ToList();
            }

            return usuarios;
        }

        public void UpdateUsuario(Usuario usuario)
        {
            using (Context = new CFContext())
            {
                Context.Entry(usuario).State = EntityState.Modified;
                Context.SaveChanges();
            }
        }
    }
}
