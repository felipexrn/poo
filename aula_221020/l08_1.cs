using System;

public class Circulo {
  public double Raio;
  public double Area() {
    return Math.PI * Math.Pow(Raio, 2);
  }
  public double Perimetro() {
    return Raio * 2 * Math.PI;
  }
} 


public class Program {
  public static void Main () {
    Circulo c = new Circulo();
    Console. WriteLine("Digite o valor do raio do cículo e veja a área e perímetro do mesmo.");
    c.Raio = double.Parse(Console.ReadLine());
    Console.WriteLine($"Raio = {c.Raio}");
    Console.WriteLine($"Área = {c.Area()}");
    Console.WriteLine($"Perímetro = {c.Perimetro()}");
  }
}
