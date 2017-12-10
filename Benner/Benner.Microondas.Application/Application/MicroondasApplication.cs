using System;
using Benner.MicroondasOnline.Domain.Interfaces;
using Benner.MicroondasOnline.Domain.Entities;

namespace Benner.MicroondasOnline.Application.Application
{
  public class MicroondasApplication : IMicroondasApplication
  {
    public string Esquenta(bool rapido, TimeSpan tempo, int potencia)
    {
      var microondas = rapido ? new Microondas(rapido) : new Microondas(tempo, potencia);
      microondas.ValidaPotencia();
      microondas.ValidaTempo();
      microondas.Esquenta();

      return microondas.Status;
    }
  }
}
