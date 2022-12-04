using System;
using System.Linq;
public class Data {
  private int Dia = 1, Mes = 1,Ano = 1;
  public Data() {}
  public Data(int Dia, int Mes, int Ano) {
    if (ValidaData(Dia, Mes, Ano)) {
      this.Ano = Ano;
      this.Mes = Mes;
      this.Dia = Dia;
    }
  }
  public Data(string Data) {
    int[] D = Data.Split('/').Select(int.Parse).ToArray(); 
    int Dia = D[0], Mes = D[1], Ano = D[2];
    if (ValidaData(Dia, Mes, Ano)) {
      this.Ano = Ano;
      this.Mes = Mes;
      this.Dia = Dia;
    }
  }
  public void SetData(int Dia, int Mes, int Ano) {
    if (ValidaData(Dia, Mes, Ano)) {
      this.Ano = Ano;
      this.Mes = Mes;
      this.Dia = Dia;
    }
  }
  public int GetDia() {
    return Dia;
  }
  public int GetMes() {
    return Mes;
  }
  public int GetAno() {
    return Ano;
  }
  public override string ToString() {
    return $"Dia = {Dia}\nMês = {Mes}\nAno = {Ano}";
  }
  public bool ValidaData(int Dia, int Mes, int Ano) {
    bool Validacao = true;
    if ((Ano < 1) ||
    (Mes < 1 || Mes > 12) ||
    (Dia < 1 || Dia > 31)) Validacao = false;
    else if ((Mes / 8 + Mes) % 2 == 0) {
      if (Dia > 30) Validacao = false;
    }
    if (Mes == 2) {
      if (Ano % 4 != 0) Validacao = false;
      else if (Ano % 100 == 0) {
        if (Ano % 400 != 0) Validacao = false;  
      }
      if (Dia > 29) Validacao = false;
    }
    return Validacao;
  }
}
public class Program {
  public static void Main() {
    Data D1 = new Data("31/09/2021");
    Console.WriteLine($"D1\n{D1.ToString()}");
    Data D2 = new Data();
    D2.SetData(1, 12, 1995);
    Console.WriteLine($"D2\n{D2.GetDia():00}/{D2.GetMes():00}/{D2.GetAno():0000}");
    Data D3 = new Data(4, 4, 4);
    Console.WriteLine($"D3\n{D3.ToString()}");
  }
}