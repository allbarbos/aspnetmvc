using System;
using Benner.Microondas.Domain.Interfaces;

namespace Benner.Microondas.Application.Application
{
  public class MicroondasApplication : IMicroondasApplication
  {
    public void Esquenta(bool rapido, TimeSpan tempo, int potencia)
    {
      var micro = rapido ? new Domain.Entities.Microondas(rapido) : new Domain.Entities.Microondas(tempo, potencia);
      
    }

    public string[] Potencias()
    {
      return new string[10] { ".", "..", "...", "....", ".....", "......", ".......", "........", ".........", ".........." };
    }
  }
}
