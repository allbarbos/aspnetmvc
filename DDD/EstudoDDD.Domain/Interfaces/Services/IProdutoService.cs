using EstudoDDD.Domain.Entities;
using System.Collections.Generic;

namespace EstudoDDD.Domain.Interfaces.Services
{
    interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
