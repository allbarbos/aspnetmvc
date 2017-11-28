using System;

namespace LINQ
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("== Collatz ==\n");
      Collatz();
      Console.Read();
    }

    private static void Collatz()
    {
      const long fim = 1000000;
      long numTermos = 1;
      long maiorNumTermos = 0, result = 0, numMaior = 0;

      Console.Write("Calculando...");

      for (var i = 1; i <= fim; i++) // Percorre de 1 ate 1 000 000
      {
        long inicio = i;

        while (result != 1) // Descobre o numero de elementos de i
        {
          if (inicio % 2 == 0) // Par
          {
            result = inicio / 2;
          }

          else  // Impar
          {
            result = 3 * inicio + 1;
          }

          inicio = result;
          numTermos++;
        }

        if (numTermos > maiorNumTermos) // Verifica se os elementos o nº de elementos do i (numTermos) é maior que o armazenado dos anteriores (maiorNumTermos)
        {
          maiorNumTermos = numTermos; // Armazena o nº de elemento maior
          numMaior = i; // Armazena quem é nº o que possui mais 
        }

        result = 0;
        numTermos = 1;
      }
      Console.WriteLine("\nNumero inicial que possui mais termos: {0}", numMaior);
      Console.WriteLine("Quantidade de termos: {0}", maiorNumTermos);
      Console.ReadKey();
    }
  }
}
