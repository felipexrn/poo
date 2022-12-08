using System;
class Triangulo {
  private double b = 1, h = 1;
  public double Base {
    get {return b;}
    set {if (value > 0) b = value;}
  }
  public double Altura {
    get {return h;}
    set {if (value > 0) h = value;}
  }
  public double Area {
    get {return b * h / 2;}
  }
  public string Cor {get; set;}
}
public class Program {
  public static void Main() {
    Triangulo t1 = new Triangulo();
    Console.WriteLine(t1.Base);
    Console.WriteLine(t1.Altura);
    Console.WriteLine(t1.Area);
    Console.WriteLine(t1.Cor);
    t1.Base = 5;
    t1.Altura = 10;
    t1.Cor = "amarelo";
    Console.WriteLine(t1.Base);
    Console.WriteLine(t1.Altura);
    Console.WriteLine(t1.Area);
    Console.WriteLine(t1.Cor);
    Triangulo t2 = new Triangulo {Base = 10, Altura = 20, Cor = "vermelho"};
    Console.WriteLine(t2.Base);
    Console.WriteLine(t2.Altura);
    Console.WriteLine(t2.Area);
    Console.WriteLine(t2.Cor);
  }
}