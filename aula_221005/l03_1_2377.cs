using System;
using System.Linq;
public class Program {
  public static void Main () {
    int[] estrada = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int[] custos = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int custo_km = estrada[0] * custos[0];
    int custo_pedagio = estrada[0] / estrada[1] * custos[1];
    int custo_total = custo_km + custo_pedagio;
    Console.WriteLine($"{custo_total}");
  }
}