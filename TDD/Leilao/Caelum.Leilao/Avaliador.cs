using System;
using System.Collections.Generic;
using System.Linq;

namespace Caelum.Leilao
{
  public class Avaliador
  {
    private double maiorDeTodos = Double.MinValue;
    private double menorDeTodos = Double.MaxValue;
    private double media = 0;
    private List<Lance> maiores;

    public void Avalia(Leilao leilao)
    {
      double total = 0;

      foreach (Lance lance in leilao.Lances)
      {
        if (lance.Valor > maiorDeTodos)
          maiorDeTodos = lance.Valor;
        if (lance.Valor < menorDeTodos)
          menorDeTodos = lance.Valor;
        total += lance.Valor;
      }

      media = total / leilao.Lances.Count;

      pegaOsMaioresNo(leilao);
    }

    public double MaiorLance { get { return maiorDeTodos; } }
    public double MenorLance { get { return menorDeTodos; } }
    public double Media { get { return media; } }

    private void pegaOsMaioresNo(Leilao leilao)
    {
      maiores = new List<Lance>(leilao.Lances.OrderByDescending(x => x.Valor));
      maiores = maiores.GetRange(0, 3);
    }
  }
}
