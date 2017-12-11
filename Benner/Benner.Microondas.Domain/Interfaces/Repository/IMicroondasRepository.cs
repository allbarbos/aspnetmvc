using Benner.MicroondasOnline.Domain.Entities;
using System.Collections.Generic;

namespace Benner.MicroondasOnline.Domain.Interfaces.Repository
{
  public interface IMicroondasRepository
  {
    IEnumerable<Programa> BuscaProgramas();
  }
}
