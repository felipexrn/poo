using System;
using System.Linq;

public class Program {
  public static double Maior(double x, double y) {
    double maior = x;
    if (maior < y) {
      maior = y;
    }
    return maior;
  }
  
  public static void Main() {
    Console.WriteLine("Escreva dois números separados por linha e verifique qual é o maior");
    double num1 = double.Parse(Console.ReadLine());
    double num2 = double.Parse(Console.ReadLine());
    Console.WriteLine(Maior(num1, num2));
  }
}