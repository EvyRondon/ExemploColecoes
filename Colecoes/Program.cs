using System;
using System.Collections.Generic;
using System.Linq;
using Colecoes.Helper;

namespace Colecoes
{
  class Program
  {
    static void Main(string[] args)
    {
      Stack<string> pilhaLivros = new Stack<string>();

      pilhaLivros.Push(".NET");
      pilhaLivros.Push("DDD");
      pilhaLivros.Push("Código Limpo");

      System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

      while (pilhaLivros.Count > 0)
      {
        System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
        System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
      }

      System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

      // Queue<string> fila = new Queue<string>();

      // fila.Enqueue("Evelym");
      // fila.Enqueue("Leandro");
      // fila.Enqueue("André");

      // System.Console.WriteLine($"Pessoas na fila:{fila.Count}");
      // while (fila.Count > 0)
      // {
      //   System.Console.WriteLine($"Vez de: {fila.Peek()}");
      //   System.Console.WriteLine($"{fila.Dequeue()} atendido(a)");
      // }
      // System.Console.WriteLine($"Pessoas na fila:{fila.Count}");
      // OperacoesArray op = new OperacoesArray();
      // int[] array = new int[5] { 6, 3, 8, 1, 9 };
      // int[] arrayCopia = new int[10];

      // int valorProcurado = 15;

      // string[] arrayString = op.ConverterParaArrayString(array);

      // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

      // op.RedimensionarArray(ref array, array.Length * 2);

      // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

      // int indice = op.ObterIndice(array, valorProcurado);

      // if (indice > -1)
      // {
      //   System.Console.WriteLine($"O indice do elemento {valorProcurado} é {indice}");
      // }
      // else
      // {
      //   System.Console.WriteLine($"O indice do elemento {valorProcurado} não foi encontrado");
      // }
      // int valorAchado = op.ObterValor(array, valorProcurado);

      // if (valorAchado > 0)
      // {
      //   System.Console.WriteLine($"Encontrei o valor");
      // }
      // else
      // {
      //   System.Console.WriteLine($"Encontrei o valor");
      // }

      // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

      // if (todosMaiorQue)
      // {
      //   System.Console.WriteLine($"Todos os valores são maior que {valorProcurado}");
      // }
      // else
      // {
      //   System.Console.WriteLine($"Existe valores que não são maiores do que {valorProcurado}");
      // }

      // bool existe = op.Existe(array, valorProcurado);

      // if (existe)
      // {
      //   System.Console.WriteLine($"Encontrei o valor {valorProcurado}");
      // }
      // else
      // {
      //   System.Console.WriteLine($"Não encontrei o valor {valorProcurado}");
      // }

      // System.Console.WriteLine("Array original:");
      // op.ImprimirArray(array);

      // op.OrdenarBubbleSort(ref array);
      // op.Ordenar(ref array);


      // System.Console.WriteLine("Array ordenado:");
      // op.ImprimirArray(array);

      // System.Console.WriteLine("Array antes da cópia");
      // op.ImprimirArray(arrayCopia);

      // op.Copiar(ref array, ref arrayCopia);
      // System.Console.WriteLine("Array após a cópia");
      // op.ImprimirArray(arrayCopia);
      // int[] numbers = { 100, 100, 5, 10, 8, 0, 3, 10, 6, 12 };

      // var minimo = numbers.Min();
      // var maximo = numbers.Max();
      // var medio = numbers.Average();
      // var soma = numbers.Sum();
      // var diferente = numbers.Distinct().ToArray();

      // System.Console.WriteLine($"Mínimo: {minimo}");
      // System.Console.WriteLine($"Máximo: {maximo}");
      // System.Console.WriteLine($"Médio: {medio}");
      // System.Console.WriteLine($"Soma: {soma}");
      // System.Console.WriteLine($"Array Original: {string.Join(",", numbers)}");
      // System.Console.WriteLine($"Array distindo: {string.Join(",", diferente)}");
      // Query syntax:
      // IEnumerable<int> numQuery1 =
      //   from num in numbers
      //   where num % 2 == 0
      //   orderby num
      //   select num;

      // var numerosParesMetodo = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

      // System.Console.WriteLine("Números pares query: " + string.Join(",", numQuery1));
      // System.Console.WriteLine("Números pares método: " + string.Join(",", numerosParesMetodo));
      // Dictionary<string, string> estados = new Dictionary<string, string>();
      // estados.Add("SP", "São Paulo");
      // estados.Add("MT", "Mato Grosso");
      // estados.Add("RO", "Rondonia");
      // estados.Add("BA", "Bahia");

      // foreach (KeyValuePair<string, string> estado in estados)
      // {
      //   System.Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
      // }

      // string valorProcurado = "SC";
      // if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
      // {
      //   System.Console.WriteLine(estadoEncontrado);
      // }
      // else
      // {
      //   System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
      // }

      //   System.Console.WriteLine($"Removendo o valor {valorProcurado}");

      //   estados.Remove(valorProcurado);

      //   foreach (KeyValuePair<string, string> estado in estados)
      //   {
      //     System.Console.WriteLine($"Chave: {estado.Key}, Valor: {estado.Value}");
      //   }

      //   System.Console.WriteLine($"Valor original: {estados[valorProcurado]}");

      //   estados[valorProcurado] = "BA - teste atualização";

      //   System.Console.WriteLine($"Valor alterado: {estados[valorProcurado]}");

      // OperacoesLista opl = new OperacoesLista();
      // List<string> estados = new List<string>() { "SP", "MG", "BA", "RO", "MT" };
      // string[] estadosArray = new string[2] { "SC", "MS" };

      // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

      // opl.ImprimirListaString(estados);

      // System.Console.WriteLine("Removendo o elemento");
      // estados.Remove("MG");
      // estados.AddRange(estadosArray);
      // estados.Insert(1, "RJ");

      // opl.ImprimirListaString(estados);


      // int[,] matrix = new int[4, 2]
      // {
      //   {8,8},
      //   {10,20},
      //   {50,100},
      //   {90, 200}
      // };

      // for (int i = 0; i < matrix.GetLength(0); i++)
      // {
      //   for (int x = 0; x < matrix.GetLength(1); x++)
      //   {
      //     System.Console.WriteLine(matrix[i, x]);
      //   }
      // }

      // int[] arrayInteros = new int[3] { 10, 20, int.Parse("30") };

      // System.Console.WriteLine("Percorrendo o array pelo for");
      // for (int i = 0; i < arrayInteros.Length; i++)
      // {
      //   System.Console.WriteLine(arrayInteros[i]);
      // }

      // System.Console.WriteLine("Percorrendo o array pelo forEach");
      // foreach (int item in arrayInteros)
      // {
      //   System.Console.WriteLine(item);
      // }
    }
  }
}
