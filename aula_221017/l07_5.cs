using System;
using System.Linq;
public class Program {
  public static string FormatarTexto(string texto) {
    string TextoFormatado = "";
    char CaracterAnterior = texto[0];
    TextoFormatado += CaracterAnterior;
    int t = texto.Length;
    for (int i = 1; i < t; i++) {
      if(! (CaracterAnterior == ' ' && texto[i] == ' ')) {
        TextoFormatado += texto[i]; 
      }
      CaracterAnterior = texto[i];
    }
    return TextoFormatado;
  }
  public static void Main() {
    Console.WriteLine("Escreva um texto e veja ele exibido sem espaços");
    string texto = Console.ReadLine();
    Console.WriteLine(FormatarTexto(texto));
  }
}