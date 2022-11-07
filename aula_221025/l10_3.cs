using System;
public class Conversor {
  private int Num = 1;
  public Conversor() {}
  public Conversor(int Num) {
    if (Num > 0) this.Num = Num;
  }
  public void SetNum(int Num) {
    if (Num > 0) this.Num = Num;
  }
  public int GetNum() {
    return Num;
  }
  public string Binario() {
    int N = Num;
    string Bin = "";
    while(N > 0) {
      Bin = N % 2 + Bin;
      N = N / 2;
    }
    return Bin;
  }
  public override string ToString() {
    return $"Num = {Num}";
  }
}
public class Program {
  public static void Main() {
    Conversor N1 = new Conversor(42);
    Console.WriteLine($"N1 = {N1.ToString()}\nBinário = {N1.Binario()}");
    Conversor N2 = new Conversor();
    N2.SetNum(37);
    Console.WriteLine($"N2 = {N2.GetNum()}\nBinário = {N2.Binario()}");
  }
}