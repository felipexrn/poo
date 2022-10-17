using System;
using System.Linq;
public class Program {
  public static void Main() {
    int notasValidas = 0;
    double[] notas = {0, 0};
    string[] respostas = {"nota invalida", "media ="};
    while (notasValidas < 2) {
      double nota = double.Parse(Console.ReadLine());
      if (nota >= 0 && nota <= 10) {
        notasValidas += 1;
        for (int i = 0; i < notas.Length; i++) {
          if (notas[i] == 0) {
            notas[i] = nota;
            break;
          }
        }
      } else {
        Console.WriteLine(respostas[0]);
      }
    }
    double media = (notas[0] + notas[1]) / 2;
    Console.WriteLine($"{respostas[1]} {media:f2}");
  }
}