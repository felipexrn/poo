using System;
using System.Linq;
public class Program {
  public static string FormatarTexto(string texto) {
    string TextoFormatado = "";
    for (int i = 0; i < texto.Length; i++) {
      if(texto[i] != ' ') {
        TextoFormatado += texto[i];
      }
    }
    return TextoFormatado;
  }
  public static void Main() {
    Console.WriteLine("Escreva um texto e veja ele exibido sem espaços");
    string texto = Console.ReadLine();
    Console.WriteLine(FormatarTexto(texto));
  }
}