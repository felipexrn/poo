using System;
public class ContaBancaria {
  private string Titular = "Não declarado";
  private int Numero;
  private double Saldo;
  public void SetTitular(string Texto) {
    if (string.IsNullOrEmpty(Texto) == false) Titular = Texto;
  }
  public string GetTitular() {
    return Titular;
  }
  public void SetNumero(int Valor) {
    if (Valor > 0) Numero = Valor;
  }
  public int GetNumero() {
    return Numero;
  }
  public double GetSaldo() {
    return Saldo;
  }
  public double Sacar(int Valor) {
    if (Saldo - Valor > 0) Saldo -= Valor;
    else Valor = 0;
    return Valor;
  }
  public double Depositar(int Valor) {
    if (Valor > 0) Saldo += Valor;
    else Valor = 0;
    return Valor;
  }
}
public class Program {
  public static void Main() {
    bool fim = false;
    ContaBancaria Conta1 = new ContaBancaria();
    Console.WriteLine($"Digite o nome do titular da conta");
    Conta1.SetTitular(Console.ReadLine());
    Console.WriteLine($"Digite o número da conta");
    Conta1.SetNumero(int.Parse(Console.ReadLine()));
    while(! fim) {
      Console.WriteLine($"Bem vinde {Conta1.GetTitular()}!\nO saldo atual da conta {Conta1.GetNumero()} é de R$ {Conta1.GetSaldo():f2}.\nPara sacar um valor de sua conta digite 1.\nPara depositar um valor em sua conta Digite 2.");
      int Escolha = int.Parse(Console.ReadLine());
      if (Escolha == 1) {
        Console.WriteLine($"Digite o valor do saque desejado");
        double Saque = int.Parse(Console.ReadLine());
        if (Conta1.GetSaldo() - Saque > 0) {
          Saque = Conta1.Sacar((int) Saque);
          Console.WriteLine($"Saque de R$ {Saque:f2} efetuado");
        } else Console.WriteLine($"Saldo insuficiente");
      } else if (Escolha == 2) {
        Console.WriteLine($"Digite o valor do depósito");
        double Deposito = Conta1.Depositar(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Depósito de R$ {Deposito:f2} efetuado");
      }
    }
  }
  
}