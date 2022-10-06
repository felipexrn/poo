using System;
public class Program {
  public static void Main() {
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double z = x / y;
    Console.WriteLine($"{z:f3} km/l");
  }
}