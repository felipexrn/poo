using System;
using System.Linq;
public class Program {
  public static void Main() {
    int alg = 1;
    if (alg ==0) {
      int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
      int menor = v[0];
      int[] s = new int[3];
      for (int i = 0; i < v.Length; i++) {
        s[i] = v[i];
      }
      Array.Sort(v);
      for (int i = 0; i < v.Length; i++) {
        Console.WriteLine($"{v[i]}");
      }
      Console.WriteLine();
      for (int i = 0; i < s.Length; i++) {
        Console.WriteLine($"{s[i]}");
      }
    } else if (alg ==1) {
      int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
      int menor = v[0];
      if (v[1] < menor) {
        menor = v[1];
      }
      if (v[2] < menor) {
        menor = v[2]
      }
      int maior = v[0];
      if (v[1] > maior) {
        maior = v[1];
      }
      if (v[2] > maior) {
        maior = v[2]
      }
      int medio = v[0];
      if (medio >= menor && medio <= maior) {
        medio = v[0];
      }
      medio = v[1];
      if (medio >= menor && medio <= maior) {
        medio = v[1];
      }
      medio = v[2];
      if (medio >= menor && medio <= maior) {
        medio = v[2];
      }
      Console.WriteLine($"{menor}");
      Console.WriteLine($"{medio}");
      Console.WriteLine($"{maior}");
      Console.WriteLine();
      Console.WriteLine($"{v[0]}");
      Console.WriteLine($"{v[1]}");
      Console.WriteLine($"{v[2]}");
    }
  }
}