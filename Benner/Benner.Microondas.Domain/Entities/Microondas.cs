using System;

namespace Benner.Microondas.Domain.Entities
{
  public class Microondas
  {
    public Microondas(TimeSpan tempo)
    {
      Status = string.Empty;
      Tempo = tempo;
      Potencia = 10;
    }

    #region props

    public string Status { get; private set; }

    public TimeSpan Tempo { get; private set; }

    public int Potencia { get; private set; }

    #endregion

    #region methods

    public void ValidaTempo()
    {
      if (Tempo == null || Tempo.TotalSeconds == 0)
        throw new Exception("Tempo Cozimento: É necessário parametrizar antes de iniciar o aquecimento");

      if (Tempo.TotalMinutes > 2 || Tempo.TotalSeconds < 1)
        throw new Exception("Tempo Cozimento: Máximo 2 minutos - Mínimo 1 segundo");
    }

    public void ValidaPotencia()
    {
      if (Potencia >= 1 || Potencia <= 10)
        throw new Exception("Potência: Máxima 10 - Mínima 1");
    }

    public void InicioRapido()
    {
      Tempo = TimeSpan.FromSeconds(30);
      Potencia = 8;
    }

    public void AtualizaStatus()
    {
      var potencias = new string[10] { ".", "..", "...", "....", ".....", "......", ".......", "........", ".........", ".........." };

      Status += potencias[Potencia].Length < 10 ? potencias[Potencia] : " aquecida";
    }

    #endregion
  }
}
