using System;
using System.Linq;
public class Program {
  public static void Main() {
    int alg = 0;
    if (alg ==0) {
      int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
      int menor = v[0];
      int[] s = new int[3];
      for (int i = 0; i < v.Length; i++) {
        s[i] = v[i];
      }
      Array.Sort(v);
      for (int i = 0; i < v.Length; i++) {
        Console.WriteLine($"{v[i]}");
      }
      Console.WriteLine("\n");
      for (int i = 0; i < s.Length; i++) {
        Console.WriteLine($"{s[i]}");
      }
    } else if (alg ==1) {
      
    }
  }
}