using System;
public class Program {
  public static void Main () {
    Console.WriteLine("Escreva seu nome completo");
    string[] nome = Console.ReadLine().Split();
    Console.WriteLine($"Bem vindo ao C#, {nome[0]}");
  }
}