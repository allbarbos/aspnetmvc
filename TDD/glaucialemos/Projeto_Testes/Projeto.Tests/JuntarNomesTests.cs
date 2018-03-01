using NUnit.Framework;
using Projeto_Testes;

namespace Projeto.Tests
{
  [TestFixture]
  public class JuntarNomesTests
  {
    [Test]
    public void DeveRetornarNomeCompleto()
    {
      var sut = new JuntarNomes();
      var nome = sut.Juntar("Allan", "Barbosa");

      Assert.That(nome, Is.EqualTo("Allan Barbosa"));
    }

    [Test]
    public void DeveRetornarNomeCompletoCaseSensitive()
    {
      var sut = new JuntarNomes();
      var nome = sut.Juntar("allan", "BARBOSA");

      Assert.That(nome, Is.EqualTo("Allan Barbosa").IgnoreCase);
    }

    [Test]
    public void DeveRetornarNomeCompletoNaoIgual()
    {
      var sut = new JuntarNomes();
      var nome = sut.Juntar("Bile", "Barbosa");

      Assert.That(nome, Is.Not.EqualTo("Allan Barbosa"));
    }
  }
}
