using System.Collections.Generic;
using EstudoDDD.Domain.Entities;
using EstudoDDD.Domain.Interfaces;
using System.Linq;

namespace EstudoDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
