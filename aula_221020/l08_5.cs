using System;
public class SessaoCinema {
  private string Filme = "Sem Título";
  private double Ingresso = 16.0;
  private string Data;
  private int Semana;
  private int Horario;
  public void SetFilme(string Texto) {
    if (string.IsNullOrEmpty(Texto) == false) Filme = Texto;
  }
  public string GetFilme() {
    return Filme;
  }
  public double GetIngresso() {
    return Ingresso;
  }
  public void SetData(string Texto) {
    if (string.IsNullOrEmpty(Texto) == false) Data = Texto;
    string[] Valores = Texto.Split('/');
    int Dia = int.Parse(Valores[0]);
    int Mes = int.Parse(Valores[1]);
    int Ano = int.Parse(Valores[2]);
    if (Mes == 1) {
      Mes = 13;
      Ano = Ano - 1;
    }
    if (Mes == 2) {
      Mes = 14;
      Ano = Ano - 1;
    }
    int q = Dia;
    int m = Mes;
    int k = Ano % 100;
    int j = Ano / 100;
    int h = q + 13 * (m + 1) / 5 + k + k / 4 + j / 4 + 5 * j;
    Semana = h % 7;
  }
  public string GetData() {
    return Data;
  }
  public string GetDiaSemana() {
    string DiaSemana = "";
    switch (Semana) {
      case 1: DiaSemana = "Domingo"; break;
      case 2: DiaSemana = "Segunda-feira"; break;
      case 3: DiaSemana = "Terça-feira"; break;
      case 4: DiaSemana = "Quarta-feira"; break;
      case 5: DiaSemana = "Quinta-feira"; break;
      case 6: DiaSemana = "Sexta-feira"; break;
      case 0: DiaSemana = "Sábado"; break;
    }
    return DiaSemana;
  }
  public void SetHorario(string Texto) {
    string[] Tempo = Texto.Split(':');
    Horario += int.Parse(Tempo[0]) * 60;
    Horario += int.Parse(Tempo[1]);
  }
  public string GetHorario() {
    string Texto = "";
    int Hora = Horario / 60;
    int Minuto = Horario % 60;
    if (Hora >= 10) Texto += Hora.ToString();
    else Texto += '0' + Hora.ToString();
    Texto += ':';
    if (Minuto >= 10) Texto += Minuto.ToString();
    else Texto += '0' + Minuto.ToString();
    return Texto;
  }
  public void CalcIngresso() {
    if (Semana >= 6 || Semana == 1) Ingresso = 20.0;
    if (Horario >= 1020) Ingresso += Ingresso / 2.0;
    if (Semana == 4) Ingresso = 8.00;
  }
}
public class Program {
  public static void Main() {
    SessaoCinema Sessao1 = new SessaoCinema();
    Console.WriteLine("Digite o nome do Filme");
    Sessao1.SetFilme(Console.ReadLine());
    Console.WriteLine("Digite a data da sessão no formato DD/MM/AAAA");
    Sessao1.SetData(Console.ReadLine());
    Console.WriteLine("Digite o horário da sessão no formato HH:MM");
    Sessao1.SetHorario(Console.ReadLine());
    Sessao1.CalcIngresso();
    Console.WriteLine($"Filme: {Sessao1.GetFilme()}\nData: {Sessao1.GetData()} {Sessao1.GetDiaSemana()}\nHorário: {Sessao1.GetHorario()}\nIngresso: R$ {Sessao1.GetIngresso():f2}");
  }
}