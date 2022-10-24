using System;

public class Circulo {
  public int Raio;
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
    c.Raio = 1;
    Console.WriteLine($"Raio = {c.Raio}");
    Console.WriteLine($"Área = {c.Area()}");
    Console.WriteLine($"Perímetro = {c.Perimetro()}");
  }
}
