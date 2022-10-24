using System;

public class Circulo {
  private double Raio = 1;
  public void SetRaio(double valor) {
    if (valor > 0) Raio = valor;
  }
  public double GetRaio() {
    return Raio;
  }
  public double CalcArea() {
    return Math.PI * Math.Pow(Raio, 2);
  }
  public double CalcPerimetro() {
    return Raio * 2 * Math.PI;
  }
} 


public class Program {
  public static void Main () {
    Circulo c = new Circulo();
    Console. WriteLine("Digite o valor do raio do cículo e veja o raio, área e perímetro do mesmo.");
    c.SetRaio(double.Parse(Console.ReadLine()));
    Console.WriteLine($"Raio = {c.GetRaio()}");
    Console.WriteLine($"Área = {c.CalcArea()}");
    Console.WriteLine($"Perímetro = {c.CalcPerimetro()}");
  }
}
