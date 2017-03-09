using EstudoDDD.Domain.Entities;
using System.Collections.Generic;

namespace EstudoDDD.Domain.Interfaces
{
    public interface IProdutoRepository :IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
