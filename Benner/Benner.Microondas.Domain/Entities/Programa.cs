using System;

namespace Benner.MicroondasOnline.Domain.Entities
{
  public class Programa : Microondas
  {
    #region ctor

    protected Programa() { }

    public Programa(string nome, string instrucao, string caractere, TimeSpan tempo, int potencia = 10)
      : base(tempo, potencia)
    {
      Nome = nome;
      Instrucao = instrucao;
      Caractere = caractere;
    }

    #endregion

    #region props 

    public string Nome { get; private set; }

    public string Instrucao { get; private set; }

    public string Caractere { get; private set; }

    #endregion

    #region methods


    #endregion
  }
}
