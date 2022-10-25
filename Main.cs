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
  public void SetData(string Texto) {
    if (string.IsNullOrEmpty(Texto) == false) Data = Texto;
    string[] Valores = Texto.Split('/');
    int Dia = int.Parse(Valores[0]);
    int Mes = int.Parse(Valores[1]);
    int Ano = int.Parse(Valores[2]);
    Semana = (Dia + 2 * Mes + (3 * (Mes + 1) / 5) + Ano + Ano / 4 - Ano / 100 + Ano / 400 + 2) % 7;
  }
  public int GetData() {
    return Data;
  }
  public void SetHorario(string Texto) {
    string[] Tempo = Texto.Split();
    Horario += int.Parse(Tempo[0]) * 60;
    Horario += int.Parse(Tempo[1]);
  }
  public string GetHorario() {
    string Texto;
    int Hora = Horario / 60;
    int Minuto = Horario % 60;
    if (Hora > 10) Texto = Hora.ToString();
    else Texto = '0' + Hora.ToString();
    Texto += ':';
    if (Minuto > 10) Texto = Minuto.ToString();
    else Texto = '0' + Minuto.ToString();
    return Texto;
  }
  public void CalcIngresso() {
    if (Semana >= 6 || Semana == 1) Ingresso = 20.0
    if (Horario >= 1020) Ingresso += Ingresso / 2.0;
    if (Semana == 4) Ingresso = 8.00;
    
  }
}
public class Program {
  public static void Main() {
    SessaoCinema Sessao1 = new SessaoCinema();
    Console.WriteLine("Digite o nome do Filme");
    Sessao1.SetFilme(Console.ReadLine());
    
    Sessao1.SetData("26/10/2022");
    Console.WriteLine(Sessao1.GetData());
  }
}