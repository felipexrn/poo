using System;
public class Paciente {
  private string nome = "Sem nome";
  private string cpf = "Não declarado";
  private string telefone = "Não declarado";
  private DateTime nascimento = DateTime.Now;
  public Paciente() {}
  public Paciente(string n, string c, string t, DateTime nasc) {
    this.SetNome(n);
    this.SetCpf(c);
    this.SetTelefone(t);
    this.SetNascimento(nasc); 
  }
  public void SetNome(string n) {
    if(n != "") nome = n;
  }
  public void SetCpf(string c) {
    if(c != "") cpf = c;
  }
  public void SetTelefone(string t) {
    if(t != "") telefone = t;
  }
  public void SetNascimento(DateTime nasc) {
    hoje = DateTime.Now;
    if(nasc <= hoje) nascimento = nasc;
  }
  public string Idade() {
    DateTime hoje = DateTime.Now;
    int ano = hoje.Year - nascimento.Year;
    int mes = hoje.Month - nascimento.Month;
    if(mes < 0) {
      mes = 12 + mes;
      ano--;
    }
    return ano.ToString() + " anos e " + 
      mes.ToString() + " meses.";
  }
  public override string ToString() {
    return $"Nome: {nome}\n" +
      $"CPF: {cpf}\n" +
      $"Telefone: {telefone}\n" +
      $"Nascimento: {nascimento:dd/MM/yyyy}";
  }
}
public class Program {
  public static void Main() {
    Paciente p = new Paciente("Felipe", "0000000000000", "99999999999", DateTime.Parse("2000-01-01"));
    Console.WriteLine(p);
    Console.WriteLine(p.Idade());
  }
}