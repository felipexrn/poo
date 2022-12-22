// Questão 03
using System;
using System.Collections;
namespace Modelo {
  public class CompArt : IComparer {
    public int Compare(object obj1, object obj2) {
      Jogador j1 = (Jogador) obj1;
      Jogador j2 = (Jogador) obj2;
      return j1.NumGols.CompareTo(j2.NumGols);
    }
  }
  public class CompCam : IComparer {
    public int Compare(object obj1, object obj2) {
      Jogador j1 = (Jogador) obj1;
      Jogador j2 = (Jogador) obj2;
      return j1.Camisa.CompareTo(j2.Camisa);
    }
  }
}

