using System;
public class Program {
  public static void Main (string[] args) {
    string n = Console.ReadLine();
    double s = double.Parse(Console.ReadLine());
    double v = double.Parse(Console.ReadLine());
    double m = v * 15 / 100 + s;
    m = m * 100;
    int truncar = (int) m;
    m = (double) truncar;
    m = m / 100;
    Console.WriteLine($"TOTAL = R$ {m:f2}");
  }
}
/*
JOAO
500.00
1230.30
*/