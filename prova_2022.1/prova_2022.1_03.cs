using System;
public class CartaBaralho {
  private string[] naipes = {"espadas", "copas", "ouros", "paus"};
  private int valor = 1;
  private string naipe = "espadas";
  public CartaBaralho() {}
  public CartaBaralho(int valor, string naipe) {
    this.SetValor(valor);
    this.SetNaipe(naipe);
  }
  public void SetValor(int valor) {
    if(valor > 0 && valor < 14) this.valor = valor;
  }
  public void SetNaipe(string naipe) {
    if(naipe != "") {
      bool naipeValido = false;
      for (int i = 0; i < 4; i++) {
        if(naipe == naipes[i]) {
          naipeValido = true;
          break;
        } 
      }
      if(naipeValido) this.naipe = naipe;
    } 
  }
  public int GetValor() {
    return valor;
  }
  public string GetNaipe() {
    return naipe;
  }
  public bool Comparar(CartaBaralho carta) {
    bool iguais = false;
    if(this.valor == carta.valor && this.naipe == carta.naipe) iguais = true;
    return iguais;
  }
  public override string ToString() {
    return $"Valor = {valor}\nNaipe = {naipe}";
  }
}
public class Program {
  public static void Main() { 
    Console.WriteLine("Digite um por linha: valor da carta e o naipe da carta 1");
    CartaBaralho c1 = new CartaBaralho(int.Parse(Console.ReadLine()), Console.ReadLine());
    Console.WriteLine("Digite um por linha: valor da carta e o naipe da carta 2");
    CartaBaralho c2 = new CartaBaralho(int.Parse(Console.ReadLine()), Console.ReadLine());
    if (c1.Comparar(c2)) Console.WriteLine("As cartas são iguais.");
    else Console.WriteLine("As cartas são diferentes.");
    Console.WriteLine(c1.ToString());
    Console.WriteLine("--------------------");
    Console.WriteLine(c2.ToString());
  }
}