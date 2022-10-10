using System;
using System.Linq;
public class Program{
  public static void Main() {
    int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if ((v[1] > v[2]) &&
        (v[3] > v[0]) &&
        (v[2] + v[3] > v[0] + v[1]) &&
        v[2] > 0 &&
        v[3] > 0 &&
        v[0] % 2 == 0) {
      Console.WriteLine("Valores aceitos");
    } else {
      Console.WriteLine("Valores nao aceitos");
    } 
  }
}