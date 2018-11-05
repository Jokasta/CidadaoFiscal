using G2.CidadaoFiscal.Core.Interfaces;
using G2.CidadaoFiscal.Core.Models;
using G2.CidadaoFiscal.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace G2.CidadaoFiscal.Infra.Repositorio.EF
{
    public class EnderecoEF : IEnderecoEF
    {
        private CFContext Context { get; set; }

        public void CreateEndereco(Endereco endereco)
        {
            using (Context = new CFContext())
            {
                Context.Enderecos.Add(endereco);
                Context.SaveChanges();
            }
        }

        public void DeleteEndereco(Endereco endereco)
        {
            using (Context = new CFContext())
            {
                Context.Entry(endereco).State = EntityState.Deleted;
                Context.SaveChanges();
            }
        }

        public Endereco GetEndereco(Guid enderecoId)
        {
            var endereco = null as Endereco;

            using (Context = new CFContext())
            {
                endereco = Context.Enderecos.Find(enderecoId);
            }

            return endereco;
        }

        public IEnumerable<Endereco> GetEnderecos()
        {
            var enderecos = null as IEnumerable<Endereco>;

            using (Context = new CFContext())
            {
                enderecos = Context.Enderecos.ToList();
            }

            return enderecos;
        }

        public void UpdateEndereco(Endereco endereco)
        {
            using (Context = new CFContext())
            {
                Context.Entry(endereco).State = EntityState.Modified;
                Context.SaveChanges();
            }
        }
    }
}
