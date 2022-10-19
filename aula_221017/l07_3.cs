using System;
using System.Linq;
public class Program {
  public static void Intervalo(double x, out int inicio, out int fim) {
    inicio = (int) x;
    fim = inicio + 1;  
  }
  public static void Main() {
    Console.WriteLine("Escreva um número real e veja em qual intervalo ele se encontra");
    int i, f;
    Intervalo(double.Parse(Console.ReadLine()), out i, out f);
    Console.WriteLine($"[{i}, {f}]");
  }
}