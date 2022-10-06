using System;
using System.Linq;
public class Program {
  public static void Main () {
    double[] p1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
    double[] p2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
    double distancia = Math.Sqrt(Math.Pow(p2[0] - p1[0], 2) + Math.Pow(p2[1] - p1[1], 2));
    Console.WriteLine($"{distancia:f4}");
  }
}