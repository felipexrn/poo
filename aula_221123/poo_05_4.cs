using System;
public class Estagiario {
  private string nome = "Não declarado";
  private string cpf = "Não declarado";
  private string telefone = "Não declarado";
  private Dias dias;
  private Turno turno;
  public Estagiario() {}
  public Estagiario(string n, string c, string t) {
    this.SetNome(n);
    this.SetCpf(c);
    this.SetTelefone(t);
  }
  public void SetNome(string n) {
    if (n != "") nome = n;
  }
  public void SetCpf(string c) {
    if (c != "") cpf = c;
  }
  public void SetTelefone(string t) {
    if (t != "") telefone = t;
  }
  public void SetDias(Dias d) {
    if (d > 0) dias = d;
  }
  public void SetTurno(Turno t) {
    turno = t;
  }
  public Dias GetDias() {
    return dias;
  }
  public Turno GetTurno() {
    return turno;
  }
  public override string ToString() {
    return $"Nome: {nome}\n" +
      $"CPF: {cpf}\n" +
      $"Telefone: {telefone}\n" +
      $"Dias: {this.GetDias()}\n" +
      $"Turno: {this.GetTurno()}";
  } 
}
[Flags]
public enum Dias {
  Nenhum = 0,
  Segunda = 1,
  Terça = 2,
  Quarta = 4,
  Quinta = 8,
  Sexta = 16
}
public enum Turno {
  Matutino,
  Vespertino,
  Noturno
}
public class Program {
  public static void Main() {
    Estagiario e1 = new Estagiario("Fulano", "1234567890000", "99999999999");
    e1.SetDias(Dias.Segunda | Dias.Quarta | Dias.Sexta);
    e1.SetTurno(Turno.Noturno);
    Console.WriteLine(e1);
  }
}
