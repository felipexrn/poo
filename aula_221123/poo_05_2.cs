using System;
public class Premio {
  private string cliente = "Não declarado";
  private DateTime data = DateTime.Now;
  private object premio;
  public Premio(string c, DateTime d) {
    if(c != "") cliente = c;
    DateTime hoje = DateTime.Now;
    if (d >= hoje) data = d;
  }
  public void SetPremio(object p) {
    premio = p;
  }
  public object GetPremio() {
    return premio;
  }
  public override string ToString() {
    return $"Cliente: {cliente}\n" +
      $"Data: {data:dd/MM/yyyy}\n" +
      $"Prêmio: {premio}";
  }
}
public class ValeCompras {
  private DateTime dataValidade = DateTime.Now;
  private decimal valor;
  public ValeCompras(DateTime d, decimal v) {
    if (d >= DateTime.Now) dataValidade = d;
    if (v >= 0) valor = v;
  }
  public override string ToString() {
    return $"Data de validade: {dataValidade:dd/MM/yyyy}\n" +
      $"Valor: {valor:0.00}";
  }
}
public class Produto {
  private string descricao = "Não Declarado";
  private decimal valor;
  public Produto(string d, decimal v) {
    if (d != "") descricao = d;
    if (v >= 0) valor = v;
  }
  public override string ToString() {
    return $"Descrição: {descricao}\n" +
      $"Valor: {valor:0.00}";
  }
}
public class Program {
  public static void Main() {
    Premio p = new Premio("Felipe", DateTime.Parse("2023-01-01"));
    ValeCompras v1 = new ValeCompras(DateTime.Parse("2023-03-01"), 99);
    p.SetPremio(v1);
    Console.WriteLine(p);
    Produto v2 = new Produto("Camisa", 25);
    p.SetPremio(v2);
    Console.WriteLine(p.GetPremio());
  }
}