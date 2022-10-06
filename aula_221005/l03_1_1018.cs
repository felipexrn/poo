using System;
using System.Linq;
public class Program {
  public static void Main () {
    int[] valores = {100, 50, 20, 10, 5, 2, 1};
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"{n}");
    for (int i = 0; i < valores.Length; i++) {
      int qtd_notas = n / valores[i];
      Console.WriteLine($"{qtd_notas} nota(s) de R$ {valores[i]},00");
      n = n % valores[i];
    }
  }
}