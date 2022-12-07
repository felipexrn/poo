using System;
using System.Collections;
public class Empresa {
  private ContaPagar[] contas;
  public ContaPagar[] Contas {set {contas = value;}}
  public string Nome {get; set;}
  private int i = 0;
  private int qtd;
  public int Qtd {get {return qtd;}}
  public void Inserir(ContaPagar conta) {
    contas[this.i] = conta;
    qtd++; 
    i++;
  }
  public ContaPagar[] Listar() {
    ComparadorFornecedor objeto = new ComparadorFornecedor();
    Array.Sort(contas, objeto);
    Array.Sort(contas);
    return contas;
  }
  public ContaPagar[] Pesquisar(int mes, int ano) {
    return contas;
  }
  public double Total(int mes, int ano) {
    return mes + ano;
  }
  public override string ToString() {
    return $"Contas: {this.contas}\n" +
      $"Nome: {this.Nome}\n" +
      $"Quantidade: {this.Qtd}";
  } 
}
public class ContaPagar : IComparable {
  public string Fornecedor {get; set;}
  public DateTime Vencimento {get; set;}
  public double Valor {get; set;}
  public int CompareTo(object obj) {
    ContaPagar c2 = (ContaPagar) obj;
    return this.Vencimento.CompareTo(c2.Vencimento);
  }
  public override string ToString() {
    return $"Fornecedor: {this.Fornecedor}\n" +
      $"Vencimento: {this.Vencimento:dd/MM/yyyy}\n" +
      $"Valor: R$ {this.Valor:0.00}";
  } 
}
public class ComparadorFornecedor : IComparer {
  public int Compare(object obj1, object obj2) {
    ContaPagar c1 = (ContaPagar) obj1;
    ContaPagar c2 = (ContaPagar) obj2;
    return c1.Fornecedor.CompareTo(c2.Fornecedor);
  }
} 
public class Program {
  public static void Main() {
    ContaPagar[] contas = new ContaPagar[3];
    Empresa e1 = new Empresa {Nome = "Taberna Records", Contas = contas};
    ContaPagar c1 = new ContaPagar {Fornecedor = "Zorzal Produções", Vencimento = DateTime.Parse("2022-12-25"), Valor = 300};
    ContaPagar c2 = new ContaPagar {Fornecedor = "CDH Cast", Vencimento = DateTime.Parse("2022-12-11"), Valor = 600};
    ContaPagar c3 = new ContaPagar {Fornecedor = "Blueburry", Vencimento = DateTime.Parse("2022-12-03"), Valor = 59};
    e1.Inserir(c1);
    e1.Inserir(c2);
    e1.Inserir(c3);
    ContaPagar[] lista = e1.Listar();
    foreach (ContaPagar conta in lista) {
      Console.WriteLine($"{conta}\n");
    }
    
  }
}