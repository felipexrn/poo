using System;
public class Equacao {
  private double A = 1, B = 1, C = 1;
  public Equacao() {}
  public Equacao(double A, double B, double C) {
    if (A != 0) this.A = A;
    this.B = B;
    this.C = C;
  }
  public void SetABC(double A, double B, double C) {
    if (A != 0) this.A = A;
    this.B = B;
    this.C = C;
  }
  public void GetABC(out double A, out double B, out double C) {
    A = this.A;
    B = this.B;
    C = this.C;
  }
  public double Delta() {
    return (B*B) - (4 * A * C);
  }
  public bool RaizesReais(out double X1, out double X2) {
    X1 = X2 = 0;
    bool Raiz = false;
    double D = Delta();
    if (D >= 0) {
      Raiz = true;
      X1 = (-B + Math.Sqrt(D)) / 2 * A;
      X2 = (-B - Math.Sqrt(D)) / 2 * A;
    }
    return Raiz;
  }
  public override string ToString() {
    return $"A = {A}\nB = {B}\nC = {C}";
  }
}
public class Program {
  public static void Main() {
    double R1 = 0;
    double R2 = 0;
    Equacao E1 = new Equacao(1, 2 ,1);
    Console.WriteLine($"E1\n{E1.ToString()}");
    if (E1.RaizesReais(out R1, out R2)) {
      Console.WriteLine($"Raizes de E1 = {R1}, {R2}");
    }
    else Console.WriteLine("E1 não tem Raizes reais");
    Equacao E2 = new Equacao();
    
    E2.SetABC(4, -2, 0);
    double A = 0, B = 0, C = 0;
    E2.GetABC(out A, out B, out C);
    Console.WriteLine($"A = {A}\nB = {B}\nC = {C}");
  }
  
}