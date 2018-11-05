using G2.CidadaoFiscal.Core.Models;
using System;
using System.Collections.Generic;

namespace G2.CidadaoFiscal.Core.Interfaces
{
    public interface IEnderecoEF
    {
        void CreateEndereco(Endereco endereco);
        void DeleteEndereco(Endereco endereco);
        Endereco GetEndereco(Guid enderecoId);
        IEnumerable<Endereco> GetEnderecos();
        void UpdateEndereco(Endereco endereco);
    }
}
