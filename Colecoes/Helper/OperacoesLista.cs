using System.Collections.Generic;

namespace Colecoes.Helper
{
  public class OperacoesLista
  {
    public void ImprimirListaString(List<string> lista)
    {
      for (int i = 0; i < lista.Count; i++)
      {
        System.Console.WriteLine($"índice {i}, valor: {lista[i]}");
      }
    }
  }
}