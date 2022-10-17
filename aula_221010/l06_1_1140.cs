using System;
using System.Linq;
public class Program {
  public static void Main() {
    string frase = Console.ReadLine();
    string[] palavras = frase.Split();
    while (frase != "*") {
      string palavra0 = palavras[0].ToLower();
      char letra0 = palavra0[0];
      string ans = "Y";
      for (int i = 0; i < palavras.Length; i++) {
        string palavra = palavras[i].ToLower();
        char letra = palavra[0];
        if (letra0 != letra) {
          ans = "N";
          break;
        }
      }
      Console.WriteLine(ans);
      frase = Console.ReadLine();
      palavras = frase.Split();
    }
  }
}