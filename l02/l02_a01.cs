using System;
public class Program {
  public static void Main (string[] args) {
    string n = Console.ReadLine();
    double s = double.Parse(Console.ReadLine());
    double v = double.Parse(Console.ReadLine());
    double m = v * 15 / 100 + s;
    Console.WriteLine($"TOTAL = R$ {m:f2}");
  }
}
