using System;
using System.Collections;
public class Empresa {
  private ContaPagar[] contas;
  public ContaPagar[] Contas {set {contas = value;}}
  public string Nome {get; set;}
  private int qtd;
  public int Qtd {get {return qtd;}}
  private int t, i; // Não consegui usar i no while dentro do metodo Pesquisar
  private double soma;
  public void Inserir(ContaPagar conta) {
    contas[this.qtd] = conta;
    qtd++; 
  }
  public ContaPagar[] Listar() {
    ComparadorFornecedor objeto = new ComparadorFornecedor();
    Array.Sort(contas, objeto);
    Array.Sort(contas);
    return contas;
  }
  public ContaPagar[] Pesquisar(int mes, int ano) {
    ContaPagar[] c1 = new ContaPagar[qtd];
    this.t = 0;
    this.i = 0;
    foreach (ContaPagar conta in contas) {
      if (conta.Vencimento.Month == mes && conta.Vencimento.Year == ano) {
        c1[this.t] = conta;
        this.t++;
      }
    }// Não consegui usar o while nesse método
    /*private ContaPagar[] c2 = new ContaPagar[this.t];
    while (this.i < this.t) {
      c2[this.i] = c1[this.i];
      this.i++;
    }*/
    return c1;
  }
  public double Total(int mes, int ano) {
    this.soma = 0;
    foreach (ContaPagar conta in contas) {
      if (conta.Vencimento.Month == mes && conta.Vencimento.Year == ano) {
        this.soma += conta.Valor;
      }
    }
    return this.soma;
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
    return $"  Fornecedor: {this.Fornecedor}\n" +
      $"  Vencimento: {this.Vencimento:dd/MM/yyyy}\n" +
      $"  Valor: R$ {this.Valor:0.00}";
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
    ContaPagar[] contas = new ContaPagar[4];
    Empresa e1 = new Empresa {Nome = "Taberna Records", Contas = contas};
    ContaPagar c1 = new ContaPagar {Fornecedor = "Zorzal Produções", Vencimento = DateTime.Parse("2022-12-25"), Valor = 302.45};
    ContaPagar c2 = new ContaPagar {Fornecedor = "CDH Cast", Vencimento = DateTime.Parse("2022-12-11"), Valor = 639.93};
    ContaPagar c3 = new ContaPagar {Fornecedor = "New Blueburry", Vencimento = DateTime.Parse("2022-11-03"), Valor = 39.91};
    ContaPagar c4 = new ContaPagar {Fornecedor = "Blueburry", Vencimento = DateTime.Parse("2022-11-03"), Valor = 60.57};
    
    e1.Inserir(c1);
    e1.Inserir(c2);
    e1.Inserir(c3);
    e1.Inserir(c4);
    
    ContaPagar[] lista1 = e1.Listar();
    ContaPagar[] lista2 = e1.Pesquisar(11, 2022);
    double total = e1.Total(12, 2022);
    
    Console.WriteLine("Listar:\n");
    foreach (ContaPagar conta in lista1) {
      Console.WriteLine($"{conta}\n");
    }

    Console.WriteLine("Pesquisar: \n");
    foreach (ContaPagar conta in lista2) {
      if (conta != null)
        Console.WriteLine($"{conta}\n");
    }
    
    Console.WriteLine($"Total: R$ {total:0.00}\n");
    
  }
}