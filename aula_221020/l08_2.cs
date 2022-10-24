using System;
using System.Linq;
public class Curso {
  private string Disciplina = "não declarada";
  private int Nota1;
  private int Nota2;
  private int Nota3;
  private int Nota4;
  private int ProvaFinal;
  public void SetDisciplina(string Texto) {
    if (string.IsNullOrEmpty(Texto) == false) Disciplina = Texto;
  }
  public string GetDisciplina() {
    return Disciplina;
  }
  public void SetNota1(int Valor) {
    if (Valor >= 0) Nota1 = Valor;
  }
  public int GetNota1() {
    return Nota1;
  }
  public void SetNota2(int Valor) {
    if (Valor >= 0) Nota2 = Valor;
  }
  public int GetNota2() {
    return Nota2;
  }
  public void SetNota3(int Valor) {
    if (Valor >= 0) Nota3 = Valor;
  }
  public int GetNota3() {
    return Nota3;
  }
  public void SetNota4(int Valor) {
    if (Valor >= 0) Nota4 = Valor;
  }
  public int GetNota4() {
    return Nota4;
  }
  public void SetProvaFinal(int Valor) {
    if (Valor >= 0) ProvaFinal = Valor;
  }
  public int GetProvaFinal() {
    return ProvaFinal;
  }
  public int CalcMediaParcial() {
    return (Nota1 * 2 + Nota2 * 2 + Nota3 * 3 + Nota4 * 3) / 10;
  }
  public int CalcMediaFinal() {
    return (CalcMediaParcial() + ProvaFinal) / 2; 
  }
}
public class Program {
  public static void Main () {
    Curso CursoA = new Curso();
    Console.WriteLine("Digite o nome da disciplina. Se vazio, Disciplina = não declarada.");
    CursoA.SetDisciplina(Console.ReadLine());
    Console.WriteLine("Digite em uma única linha as 4 notas da disciplina (de 0 a 100) separadas por espaço. Se vazio ou se os valores forem inválidos, as notas = 0.");
    string Entrada = Console.ReadLine();
    int NotaParcial = 0, NotaFinal = 0;
    if (string.IsNullOrEmpty(Entrada) == false) {
      int[] Notas = Entrada.Split().Select(int.Parse).ToArray();
      CursoA.SetNota1(Notas[0]);
      CursoA.SetNota2(Notas[1]);
      CursoA.SetNota3(Notas[2]);
      CursoA.SetNota4(Notas[3]);
      NotaParcial = CursoA.CalcMediaParcial();
    }
    if (NotaParcial < 60) {
      Console.WriteLine("O aluno ficou em recuperação. Digite o valor na prova final (0 a 100). Se vazio ou se o valor for inválido, Prova Final = 0.");
      Entrada = Console.ReadLine();
      int A;
      if (string.IsNullOrEmpty(Entrada) == false && int.TryParse(Entrada, out A)) {
        CursoA.SetProvaFinal(int.Parse(Entrada));
        NotaFinal = CursoA.CalcMediaFinal();
      }
    } else {
      NotaFinal = NotaParcial;
    }
    Console.WriteLine($"Disciplina: {CursoA.GetDisciplina()}\nNota 1 = {CursoA.GetNota1()}\nNota 2 = {CursoA.GetNota2()}\nNota 3 = {CursoA.GetNota3()}\nNota 4 = {CursoA.GetNota4()}\nProva Final = {CursoA.GetProvaFinal()}\nMédia Parcial = {NotaParcial}\nMédia Final = {NotaFinal}");
  }
}