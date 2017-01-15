using Financas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Financas.DAO
{
    public class FinancasContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Movimentacao> Movimentacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Movimentação tem FK de Usuario, sendo assim, toda movimentação precisa ter um usuário
            modelBuilder.Entity<Movimentacao>().HasRequired(mov => mov.Usuario);
        }

    }
}