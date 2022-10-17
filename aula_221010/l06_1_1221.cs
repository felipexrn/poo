using System;
using System.Linq;
public class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++) {
      uint num = uint.Parse(Console.ReadLine());
      uint raizNum = (uint) Math.Sqrt(num) + 1;
      string ans = "Prime";
      for (uint j = 2; j < raizNum; j++) {
        if (num % j == 0) {
          ans = "Not Prime";
          break;
        }
      }
      Console.WriteLine(ans);
    }
  }
}