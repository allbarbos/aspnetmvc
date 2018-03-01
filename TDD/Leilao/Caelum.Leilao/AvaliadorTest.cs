using NUnit.Framework;

namespace Caelum.Leilao
{
  [TestFixture]
  public class AvaliadorTest
  {
    [Test]
    public void DeveEntenderLancesEmOrdemCrescente()
    {
      // cenario: 3 lances em ordem crescente
      Usuario joao = new Usuario("Joao");
      Usuario jose = new Usuario("José");
      Usuario maria = new Usuario("Maria");

      Leilao leilao = new Leilao("Playstation 3 Novo");

      leilao.Propoe(new Lance(maria, 250.0));
      leilao.Propoe(new Lance(joao, 300.0));
      leilao.Propoe(new Lance(jose, 400.0));

      // executando a acao
      Avaliador leiloeiro = new Avaliador();
      leiloeiro.Avalia(leilao);

      // comparando a saida com o esperado
      Assert.AreEqual(400, leiloeiro.MaiorLance, 0.0001);
      Assert.AreEqual(250, leiloeiro.MenorLance, 0.0001);
    }

    [Test]
    public void DeveEntenderLancesEmOrdemCrescenteComOutrosValores()
    {
      Usuario joao = new Usuario("Joao");
      Usuario jose = new Usuario("José");
      Usuario maria = new Usuario("Maria");

      Leilao leilao = new Leilao("Playstation 3 Novo");

      leilao.Propoe(new Lance(maria, 1000.0));
      leilao.Propoe(new Lance(joao, 2000.0));
      leilao.Propoe(new Lance(jose, 3000.0));

      Avaliador leiloeiro = new Avaliador();
      leiloeiro.Avalia(leilao);

      Assert.AreEqual(3000, leiloeiro.MaiorLance, 0.0001);
      Assert.AreEqual(1000, leiloeiro.MenorLance, 0.0001);
    }

    [Test]
    public void DeveEntenderLeilaoComApenasUmLance()
    {
      Usuario joao = new Usuario("Joao");
      Leilao leilao = new Leilao("Playstation 3 Novo");

      leilao.Propoe(new Lance(joao, 1000.0));

      Avaliador leiloeiro = new Avaliador();
      leiloeiro.Avalia(leilao);

      Assert.AreEqual(1000, leiloeiro.MaiorLance, 0.0001);
      Assert.AreEqual(1000, leiloeiro.MenorLance, 0.0001);
    }

    [Test]
    public void DeveCalcularAMedia()
    {
      // cenario: 3 lances em ordem crescente
      Usuario joao = new Usuario("Joao");
      Usuario jose = new Usuario("José");
      Usuario maria = new Usuario("Maria");

      Leilao leilao = new Leilao("Playstation 3 Novo");

      leilao.Propoe(new Lance(maria, 300.0));
      leilao.Propoe(new Lance(joao, 400.0));
      leilao.Propoe(new Lance(jose, 500.0));

      // executando a acao
      Avaliador leiloeiro = new Avaliador();
      leiloeiro.Avalia(leilao);

      // comparando a saida com o esperado
      Assert.AreEqual(400, leiloeiro.Media, 0.0001);
    }
  }
}