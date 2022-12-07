using System;
public class Empresa {
  private ContaPagar[] contas;
  public string Nome {get; set;}
  private int qtd = 10;
  public int Qtd {get {return qtd;}}
  public void Inserir(ContaPagar conta) {
    contas[this.Qtd] = conta;
  }
  public ContaPagar[] Listar() {
    return contas;
  }
  public ContaPagar[] Pesquisar(int mes, int ano) {
    return contas;
  }
  public double Total(int mes, int ano) {
    return mes + ano;
  }
}
public class ContaPagar : IComparable {
  public string Fornecedor {get; set;}
  public DateTime Vencimento {get; set;}
  public double Valor {get; set;}
  public int CompareTo(object obj) {
    return this.Vencimento.CompareTo(((ContaPagar) obj).Vencimento);
  }
  public override string ToString() {
    return $"Fornecedor: {this.Fornecedor}\n" +
      $"Vencimento: {this.Vencimento:dd/MM/yyyy}\n" +
      $"Valor: R$ {this.Valor:0.00}";
  } 
}
public class Program {
  public static void Main() {
    Empresa e1 = new Empresa {Nome = "Taberna Records"};
    ContaPagar c1 = new ContaPagar {Fornecedor = "Zorzal Produções", Vencimento = DateTime.Parse("2022-12-25"), Valor = 300};
    e1.Inserir(c1);
  }
}