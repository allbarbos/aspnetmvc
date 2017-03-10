using EstudoDDD.Domain.Entities;
using System.Collections.Generic;

namespace EstudoDDD.Domain.Interfaces.Services
{
    public interface IClienteService :IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
