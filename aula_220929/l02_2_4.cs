using System;
public class Program {
  public static void Main() {
    Console.WriteLine("Digite a base e a altura do retângulo");
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    double a = b * h;
    double p = (b + h) * 2;
    double d = Math.Sqrt(b * b + h * h);
    Console.WriteLine($"Área = {a:f2} - Perímetro = {p:f2} - Diagonal = {d:f2}");
  }
}