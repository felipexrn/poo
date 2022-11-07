using System;
public class Retangulo {
  private double b;
  private double h;
  public Retangulo() {}
  public Retangulo(double b, double h) {
    if (b > 0) this.b = b;
    if (h > 0) this.h = h;
  }
  public void SetBase(double b) {
    if (b > 0) this.b = b;
  }
  public void SetAltura(double h) {
    if (h > 0) this.h = h;
  }
  public double GetBase() {
    return b;
  }
  public double GetAltura() {
    return h;
  }
  public double CalcArea() {
    return b * h;
  }
  public double CalcDiagonal() {
    return Math.Sqrt(b * b + h * h);
  }
  public override string ToString() {
    return $"Base = {b}\nAltura = {h}";
  }
}
public class Program {
  public static void Main() {
    Retangulo r1 = new Retangulo();
    Retangulo r2 = new Retangulo(-1, -1);
    Retangulo r3 = new Retangulo(3, 4);
    r1.SetBase(-1);
    r1.SetAltura(-1);
    Console.WriteLine($"r1\nBase = {r1.GetBase()}\nAltura = {r1.GetAltura()}");
    Console.WriteLine($"r2\n{r2.ToString()}");
    Console.WriteLine($"r3\nArea = {r3.CalcArea()}\nDiagonal = {r3.CalcDiagonal()}");
  }
}