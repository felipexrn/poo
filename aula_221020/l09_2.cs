using System;
public class Curso {
  public string Disciplina;
  public int Peso1 = 2;
  public int Peso2 = 2;
  public int Peso3 = 3;
  public int Peso4 = 3;
  public int Nota1;
  public int Nota2;
  public int Nota3;
  public int Nota4;
  public int ProvaFinal;
  public int MediaParcial() {
    int MP = (Nota1 * Peso1 + Nota2 * Peso2 + Nota3 * Peso3 + Nota4 * Peso4) / Peso1 + Peso2 + Peso3 + Peso4;
    return MP; 
  }
  public int MediaFinal() {
    return MediaParcial() + ProvaFinal / 2; 
  }
}
public class Program {
  public static void Main () {
    Curso c = new Curso();
    Console.WriteLine("Digite o nome da disciplina");
    c.Disciplina = Console.ReadLine();
    
  }
}