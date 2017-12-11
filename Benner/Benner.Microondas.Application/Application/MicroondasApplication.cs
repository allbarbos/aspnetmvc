using System;
using System.Collections.Generic;
using Benner.MicroondasOnline.Domain.Entities;
using Benner.MicroondasOnline.Domain.Interfaces.Application;
using Benner.MicroondasOnline.Domain.Interfaces.Repository;

namespace Benner.MicroondasOnline.Application.Application
{
  public class MicroondasApplication : IMicroondasApplication
  {
    private readonly IMicroondasRepository _microondasRepo;

    public MicroondasApplication(IMicroondasRepository microondasRepo)
    {
      _microondasRepo = microondasRepo;
    }

    public IEnumerable<Programa> BuscaProgramas()
    {
      var programas = _microondasRepo.BuscaProgramas();

      return programas;
    }

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
