using System;
public class Frete {
  private double Distancia = 0.0;
  private double Peso = 1.0;
  public Frete() {}
  public Frete(double D, double P) {
    if (D > 0) Distancia = D;
    if (P > 0) Peso = P;
  }
}
public class Program {
  public static void Main() {
    
  }
}