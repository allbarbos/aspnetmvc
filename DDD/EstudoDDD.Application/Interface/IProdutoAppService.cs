using EstudoDDD.Domain.Entities;
using System.Collections.Generic;

namespace EstudoDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
