using System;
public class Viagem {
  private int Distancia; // km
  private Double Tempo = 1; // horas (ler formato hh:mm)
  public void SetDistancia(int Valor) {
    if (Valor > 0) Distancia = Valor;
  }
  public int GetDistancia() {
    return Distancia;
  }
  public void SetTempo(string Texto) {
    string[] Palavras = Texto.Split(':');
    Double Valor = double.Parse(Palavras[0]);
    Valor += double.Parse(Palavras[1]) / 60.0;
    Tempo = Valor;
  }
  public string GetTempo() {
    string Texto; 
    int Hora = (int) Tempo;
    if (Hora < 10) Texto = '0' + Hora.ToString();
    else Texto = Hora.ToString();
    Texto += ':';
    int Minuto = (int) (Tempo * 60 % 60);
    if (Minuto < 10) Texto += '0' + Minuto.ToString();
    else Texto += Minuto.ToString();
    return Texto;
  }
  public double CalcVeloMed() {
    return Distancia / Tempo;
  }
}
public class Program {
  public static void Main() {
    Viagem Minas = new Viagem();
    Console.WriteLine("Digite a distãncia a ser percorrida na viagem em kilometros.");
    Minas.SetDistancia(int.Parse(Console.ReadLine()));
    Console.WriteLine("Digite o tempo da viagem no formato HH:MM.");
    Minas.SetTempo(Console.ReadLine());
    double Velocidade = Minas.CalcVeloMed();
    Console.WriteLine($"Distância = {Minas.GetDistancia()} km\nTempo = {Minas.GetTempo()} horas\nVelocidade Média = {Velocidade:f2} km/h");
  }
}
