using System;

namespace Benner.MicroondasOnline.Domain.Interfaces
{
  public interface IMicroondasApplication
  {
    string Esquenta(bool rapido, TimeSpan tempo, int potencia);
  }
}
