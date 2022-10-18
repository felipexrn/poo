using System;
using System.Linq;
public class Program {
  public static void Main() {
    string entrada = Console.ReadLine();
    while(string.IsNullOrEmpty(entrada) == false) {
      int[] valores = entrada.Split().Select(int.Parse).ToArray();
      double aguasInternacionais = 12;
      double hipotenusa = Math.Sqrt(Math.Pow(valores[0], 2) + Math.Pow(aguasInternacionais, 2));
      double fuga = aguasInternacionais / valores[1];
      double captura = hipotenusa / valores[2];
      string ans = "S";
      if (fuga < captura) {
        ans = "N";
      }
      Console.WriteLine(ans);
      entrada = Console.ReadLine();
    }
  }
}