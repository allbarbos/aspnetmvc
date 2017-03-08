using EstudoDDD.Domain.Entities;
using EstudoDDD.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDDD.Infra.Data.Contexto
{
    public class EstudoDDDContext : DbContext
    {
        public EstudoDDDContext()
            : base("EstudoDDD")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Desativa pluralização de tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Evita deleção em cascanta quando há relação 1 para N
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //Evita deleção em cascanta quando há relação N para M
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //tODA VEZ QUE TIVER ENTIDADE, NÃO USAR O PADRÃO QUE TODA PROP ID É UMA PRIMARY KEY
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //Quando informado string sem definicão de valor, o padrão sempre será varchar(100) ao invés do nvarchar(max)
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //Adiciono minha classe de configuração da entidade Cliente
            modelBuilder.Configurations.Add(new ClienteConfiguration());
        }

        public override int SaveChanges()
        {
            //no momento que está fazendo o tracker de uma mudança, verifica se a entidade tem DataCadstro e se está diff de null
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    //Se está fazendo um update, não atualizo a DataCadastro, uma vez que ela entrou, sempre ficará
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
