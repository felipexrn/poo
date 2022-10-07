using System;
using System.Linq;
public class Program {
  public static void Main() {
    double[] abc = Console.ReadLine().Split().Select(double.Parse).ToArray();
    string[] rot = {"TRIANGULO:", "CIRCULO:", "TRAPEZIO:", "QUADRADO:", "RETANGULO:"};
    double[] ans = {0, 0, 0, 0, 0};
    ans[0] = abc[0] * abc[2] / 2;
    ans[1] = 3.14159 * Math.Pow(abc[2], 2);
    ans[2] = (abc[0] + abc[1]) * abc[2] / 2;
    ans[3] = Math.Pow(abc[1], 2);
    ans[4] = abc[0] * abc[1];
    for (int i = 0; i < ans.Length; i++) {
      Console.WriteLine($"{rot[i]} {ans[i]:f3}");
    }
  }
}
