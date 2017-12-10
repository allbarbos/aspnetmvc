using System;
using Benner.Microondas.Domain.Interfaces;
using System.Threading;

namespace Benner.Microondas.Application.Application
{
  public class MicroondasApplication : IMicroondasApplication
  {
    public string[] Potencias()
    {
      return new string[10] { ".", "..", "...", "....", ".....", "......", ".......", "........", ".........", ".........." };
    }
  }
}
