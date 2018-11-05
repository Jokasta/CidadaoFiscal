using G2.CidadaoFiscal.Core.Models;
using System;
using System.Collections.Generic;

namespace G2.CidadaoFiscal.Core.Interfaces
{
    public interface IUsuarioEF
    {
        Usuario GetUsuario(Guid usuarioId);

        Usuario GetUsuarioLoginSenha(string login, string password);

        IEnumerable<Usuario> GetUsuarios();

        void CreateUsuario(Usuario usuario);

        void UpdateUsuario(Usuario usuario);

        void DeleteUsuario(Usuario usuario);
    }
}
