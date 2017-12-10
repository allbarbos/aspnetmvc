using System;

namespace Benner.MicroondasOnline.Domain.Interfaces
{
  public interface IMicroondasApplication
  {
    string[] Potencias();

    void Esquenta(bool rapido, TimeSpan tempo, int potencia);
  }
}
