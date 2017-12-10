using System;

namespace Benner.MicroondasOnline.Domain.Entities
{
  public class Microondas
  {
    #region ctor

    protected Microondas() { }

    public Microondas(bool inicioRapido)
    {
      Status = string.Empty;
      Tempo = TimeSpan.FromSeconds(30);
      Potencia = 8;
    }

    public Microondas(TimeSpan tempo, int potencia = 10)
    {
      Status = string.Empty;
      Tempo = tempo;
      Potencia = potencia;
    }

    #endregion

    #region props

    public string Status { get; private set; }

    public TimeSpan Tempo { get; private set; }

    public int Potencia { get; private set; }

    #endregion

    #region methods

    public string[] Potencias()
    {
      return new string[10] { ".", "..", "...", "....", ".....", "......", ".......", "........", ".........", ".........." };
    }

    public void ValidaTempo()
    {
      if (Tempo == null || Tempo.TotalSeconds < 1)
        throw new Exception("Tempo Cozimento: É necessário parametrizar antes de iniciar o aquecimento");

      if (Tempo.TotalMinutes > 2 || Tempo.TotalSeconds < 1)
        throw new Exception("Tempo Cozimento: Máximo 2 minutos - Mínimo 1 segundo");
    }

    public void ValidaPotencia()
    {
      if (Potencia < 1 || Potencia > 10)
        throw new Exception("Potência: Máxima 10 - Mínima 1");
    }

    public void Esquenta()
    {
      for (int i = 0; i < Tempo.TotalSeconds; i++)
      {
        var potencias = Potencias();

        Status += potencias[Potencia - 1];
      }

      Status += " Aquecido!";
      //var potencias = new string[10] { ".", "..", "...", "....", ".....", "......", ".......", "........", ".........", ".........." };

      //Status += potencias[Potencia].Length < 10 ? potencias[Potencia] : " aquecida";
    }

    #endregion
  }
}
