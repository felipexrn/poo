using System;
using System.Linq;
public class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    int[] fib = new int[n];
    for (int i = 0; i < n; i++) {
      if (i == 0) {
        fib[i] = 0;
      } else if (i == 1) {
        fib[i] = 1;
      } else {
        fib[i] = fib[i-2] + fib[i-1];
      }
      Console.Write($"{fib[i]}");
      if (i < n-1) {
        Console.Write(" ");
      }
    }
    Console.WriteLine();
  }
}