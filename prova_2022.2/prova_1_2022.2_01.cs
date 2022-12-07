using System;
public class Pais {
  private string nome = "Não declarado";
  private int populacao = 0;
  private double area = 1;
  public Pais() {}
  public Pais(string nome, int populacao, double area) {
    if (nome != "") this.nome = nome;
    if (populacao > 0) this.populacao = populacao;
    if (area > 0) this.area = area;
  }
  public void SetNome(string nome) {
    if (nome != "") this.nome = nome;
  }
  public void SetPopulacao(int populacao) {
    if (populacao > 0) this.populacao = populacao;
  }
  public void SetArea(double area) {
    if (area > 0) this.area = area;
  }
  public string GetNome() {
    return nome;
  }
  public int GetPopulacao() {
    return populacao;
  }
  public double GetArea() {
    return area;
  }
  public double Densidade() {
    return populacao / area;
  }
  public override string ToString() {
    return $"País = {nome}\nPopulação = {populacao}\nÁrea = {area}\nDensidade = {this.Densidade()}";
  }
}
public class Program {
  public static void Main() {
    double maiorDensidade = 0;
    int indicePais = 0;
    Pais[] paises = new Pais[10];
    for (int i = 0; i < 10; i++) {
      Console.WriteLine($"Digite um por linha: nome, população e área do país {i + 1}/10. Descubra qual deles tem maior densidade populacional.");
      paises[i] = new Pais(Console.ReadLine(), int.Parse(Console.ReadLine(), double.Parse(Console.ReadLine()));
      if (paises[i].Densidade() > maiorDensidade) {
        maiorDensidade = paises[i].Densidade();
        indicePais = i;
      }           
    }
    Console.WriteLine(paises[indicePais].ToString());
  }
}