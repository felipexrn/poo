using System;
using System.Linq;
public class Program{
  public static void Main() {
    string[] respostas = {"azar", "azar", "azar", "terno", "quadra", "quina", "sena"};
    int[] aposta = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int[] resultados = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int acertos = 0;
    for (int i = 0; i < aposta.Length; i++) {
      for (int j = 0; j < resultados.Length; j++) {
        if (aposta[i] == resultados[j]) {
          acertos++;
        }
      }
    }
    Console.WriteLine($"{respostas[acertos]}");
  }
}
