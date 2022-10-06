using System;
public class Program {
  public static void Main () {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int nota1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    int nota2 = int.Parse(Console.ReadLine());
    int media = (nota1 * 2 + nota2 * 3) / 5; 
    Console.WriteLine($"{media}");
  }
}