using System;
public class Frete {
  private double Distancia = 0.0;
  private double Peso = 1.0;
  public Frete() {}
  public Frete(double D, double P) {
    if (D > 0) Distancia = D;
    if (P > 0) Peso = P;
  }
  public void SetDistancia(double D) {
    if (D > 0) Distancia = D;
  }
  public void SetPeso(double P) {
    if (P > 0) Peso = P;
  }
  public double GetDistancia() {
    return Distancia;
  }
  public double GetPeso() {
    return Peso;
  }
  public double CalcFrete() {
    return Distancia * Peso / 100;
  }
  public override string ToString() {
    return $"Distância = {Distancia}\nPeso = {Peso}";
  }
}
public class Program {
  public static void Main() {
    Frete F1 = new Frete(1, 1);
    Console.WriteLine($"F1\n{F1.ToString()}");
    Console.WriteLine($"Frete = {F1.CalcFrete()}");
    Frete F2 = new Frete();
    F2.SetDistancia(2);
    F2.SetPeso(1.5);
    Console.WriteLine($"F2\nFrete = {F2.CalcFrete()}\nDistância = {F2.GetDistancia()}\nPeso = {F2.GetPeso()}");
  }
}