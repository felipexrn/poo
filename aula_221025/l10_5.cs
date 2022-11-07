using System;
public class Data {
  private int Dia = 1;
  private int Mes = 1;
  private int Ano = 1;
  public Data() {}
  public Data(int Dia, int Mes, int Ano) {
    if (Ano > 0) this.Ano = Ano;
    if (Mes > 0 && Mes < 13) this.Mes = Mes;
    if (Dia > 0 && Dia < 32) this.Dia = Dia;
    
  }
  public class bool ValidaData() {
    if ((Ano < 1) ||
    (Mes < 1 || Mes > 12) ||
    (Dia < 1 || Dia > 31)) return false;
    
    return true;
  }
  / 4
  / 100
  / 400
  
}
public class Program {
  public static void Main() {
    
  }
}