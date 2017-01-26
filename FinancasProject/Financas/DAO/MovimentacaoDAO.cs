using Financas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas.DAO
{
    public class MovimentacaoDAO
    {
        private FinancasContext ctx;

        public MovimentacaoDAO(FinancasContext context)
        {
            ctx = context;
        }

        public void Adiciona(Movimentacao movimentacao)
        {
            ctx.Movimentacoes.Add(movimentacao);
            ctx.SaveChanges();
        }

        public IList<Movimentacao> Lista()
        {
            return ctx.Movimentacoes.ToList();
        }
    }
}