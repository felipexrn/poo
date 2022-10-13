using System;
using System.Linq;
public class Program {
  public static void Main() {
    int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
    char[] respostas = {'C', 'D', 'N'};
    int cre = 0, dec = 0;
    char ans = ' ';
    int atual = v[0];
    for (int i = 0; i < v.Length; i++) {
      if (atual <= v[i]) {
        cre += 1;
      }
      if (atual >= v[i]) {
        dec += 1;
      }
      atual = v[i];
    }
    if (cre == v.Length) {
      ans = respostas[0];
    } else if ((dec == v.Length)) {
      ans = respostas[1];
    } else {
      ans = respostas[2];
    }
    Console. WriteLine($"{ans}");
  }
}