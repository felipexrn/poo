using System;
using System.Linq;
public class Program {
  public static void Ordenar(ref int x, ref int y, ref int z) {
    int menor;
    if (y < x) {
      menor = x;
      x = y;
      y = menor;
    }
    if (z < x) {
      menor = x;
      x = z;
      z = menor;
    }
    if (z < y) {
      menor = y;
      y = z;
      z = menor;
    }
  }
  public static void Print(int[] lista) {
    int t = lista.Length;
    for (int i = 0; i < t; i++) {
      Console.Write(lista[i]);
      if (i < t - 1) {
        Console.Write(" ");
      }
    }
    Console.WriteLine();
  }
  public static void Main() {
    Console.WriteLine("Escreva três números na mesma linha e veja eles em ordem crescente");
    int[] valores = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Ordenar(ref valores[0], ref valores[1], ref valores[2]);
    Print(valores);
  }
}