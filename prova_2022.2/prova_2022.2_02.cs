using System;
public class PecaDomino {
  private int lado1 = 0;
  private int lado2 = 0;
  public PecaDomino() {}
  public PecaDomino(int lado1, int lado2) {
    if (lado1 >= 0 && lado1 <= 6) this.lado1 = lado1;
    if (lado2 >= 0 && lado2 <= 6) this.lado2 = lado2;
  }
  public void SetLado1(int lado1) {
    if (lado1 >= 0 && lado1 <= 6) this.lado1 = lado1;
  }
  public void SetLado2(int lado2) {
    if (lado2 >= 0 && lado2 <= 6) this.lado2 = lado2;
  }
  public int GetLado1() {
    return lado1;
  }
  public int GetLado2() {
    return lado2;
  }
  public bool Encaixa(PecaDomino peca) {
    bool encaixa = false;
    if (peca.lado1 == this.lado1 || peca.lado2 == this.lado2 || peca.lado2 == this.lado1 || peca.lado1 == this.lado2) encaixa = true;
    return encaixa;
  }
  public override string ToString() {
    return $"Lado 1 = {lado1}\nLado 2 = {lado2}";
  }
}
public class Program {
  public static void Main() {
    Console.WriteLine("Digite um por linha: lado 1 e lado 2 da peça 1.");
    PecaDomino p1 = new PecaDomino(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite um por linha: lado 1 e lado 2 da peça 2.");
    PecaDomino p2 = new PecaDomino(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
    if (p1.Encaixa(p2)) Console.WriteLine("As peças combinam");
    else Console.WriteLine("As peças não combinam");
    Console.WriteLine(p1.ToString());
    Console.WriteLine(p2.ToString());
  }
}