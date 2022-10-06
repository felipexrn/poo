using System;
using System.Linq; // módulo permite o uso do Array.Selet() para conveter tipos numa linha 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
    int[] tempo = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
    tempo[1] += tempo[0] * 60;
    tempo[2] += tempo[1] * 60;
    int distancia = tempo[2] * 300000;
    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");
  }
}