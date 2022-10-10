using System;
using System.Linq;
public class Program {
  public static void Main() {
    string[] ans = {"Intervalo [0,25]", "Intervalo (25,50]", "Intervalo (50, 75]", "Intervalo (75,100]", "Fora de intervalo"};
    double n = double.Parse(Console.ReadLine()); 
    int i = 0;
    if (n >= 0 && n <= 25) {
      i = 0;
    } else if (n > 25 && n <= 50) {
      i = 1;
    } else if (n > 50 && n <= 75) {
      i = 2;
    } else if (n > 75 && n <= 100) {
      i = 3;
    } else {
      i = 4;
    }
    Console.WriteLine(ans[i]);
  }    
}