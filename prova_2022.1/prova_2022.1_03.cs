using System;

public class CartaBaralho {
  private string[] naipes = {"espadas", "copas", "ouros", "paus"};
  private int valor = Aleatorio.valorCarta;
  private string naipe = naipes[indiceNaipe];
  public override string ToString() {
    return $"Valor = {valor}\nNaipe = {naipe}";
  }
}
public class Program {

  Random num = new Random();
  public int valorCarta = num.Next(1, 14);
  public int indiceNaipe = num.Next(0, 4);

  public static void Main() {
    CartaBaralho c1 = new CartaBaralho();
    Console.WriteLine(c1.ToString());
  }
}