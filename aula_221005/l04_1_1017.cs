using System;
using System.Linq;
public class Program {
  public static void Main() {
    double horas = double.Parse(Console.ReadLine());
    double velocidade = double.Parse(Console.ReadLine());
    double litros = horas * velocidade / 12;
    Console.WriteLine($"{litros:f3}");
  }
}