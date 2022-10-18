using System;
using System.Linq;
public class Program {
  public static void Main() {
    int contador = 1;
    int n = int.Parse(Console.ReadLine());
    while (n != 0) {
      bool temIntersec = true;
      int[] coordenadas = Console.ReadLine().Split().Select(int.Parse).ToArray();
      int x1 = coordenadas[0];
      int y1 = coordenadas[1];
      int u1 = coordenadas[2];
      int v1 = coordenadas[3];
      for (int i = 0; i < n -1; i++) {
        coordenadas = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int x2 = coordenadas[0];
        int y2 = coordenadas[1];
        int u2 = coordenadas[2];
        int v2 = coordenadas[3];
        if (Math.Max(x1, x2) <= Math.Min(u1, u2) && Math.Min(y1, y2) <= Math.Max(v1, v2)) {
          x1 = Math.Max(x1, x2);
          y1 = Math.Min(y1, y2);
          u1 = Math.Min(u1, u2);
          v1 = Math.Max(v1, v2);
        } else {
          temIntersec = false;
        }
      }      
      Console.WriteLine($"Teste {contador}");
      contador++;
      if (temIntersec) {
        Console.WriteLine($"{x1} {y1} {u1} {v1}");
      } else {
        Console.WriteLine("nenhum");
      }
      Console.WriteLine();
      n = int.Parse(Console.ReadLine());
    }
  }
}