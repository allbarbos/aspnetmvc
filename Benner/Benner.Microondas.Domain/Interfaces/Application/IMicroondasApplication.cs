using Benner.MicroondasOnline.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Benner.MicroondasOnline.Domain.Interfaces.Application
{
  public interface IMicroondasApplication
  {
    string Esquenta(bool rapido, TimeSpan tempo, int potencia);

    IEnumerable<Programa> BuscaProgramas();
  }
}
