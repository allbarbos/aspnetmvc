using System;
using Benner.MicroondasOnline.Domain.Interfaces;
using Benner.MicroondasOnline.Domain.Entities;

namespace Benner.MicroondasOnline.Application.Application
{
  public class MicroondasApplication : IMicroondasApplication
  {
    public void Esquenta(bool rapido, TimeSpan tempo, int potencia)
    {
      var micro = rapido ? new Microondas(rapido) : new Microondas(tempo, potencia);
      
    }

    public string[] Potencias()
    {
      return new string[10] { ".", "..", "...", "....", ".....", "......", ".......", "........", ".........", ".........." };
    }
  }
}
