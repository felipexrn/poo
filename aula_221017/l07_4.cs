using System;
using System.Linq;
public class Program{
  public static int MMC(int x, int y) {
    bool EDivisorComum = false;
    int Mmc = Math.Max(x, y);
    while(! EDivisorComum) {
      if (Mmc % x > 0 || Mmc % y > 0) Mmc++;      
      else EDivisorComum = true;
    }
    return Mmc;  
  }
  public static void Main() {
    Console.WriteLine("Escreva dois números separados por espaço e veja seu MMC");
    int[] numeros = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Console.WriteLine(MMC(numeros[0], numeros[1]));
  }
}