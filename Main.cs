// Neste documento você encontrará a resolução das 3 questões da 2ª prova de 2021.1

// Atenção para a ordem do documento:
// Questão 02
// Questão 01
// Questão 03

// Resolução da questão 02, que valia 35 pontos:

using System;
using System.Collections;
public class Empresa { // classe que rege os objetos que representam empresas
  private ContaPagar[] contas;
  public ContaPagar[] Contas {set {contas = value;}}
  public string Nome {get; set;}
  private int qtd;
  public int Qtd {get {return qtd;}}
  private int t;
  private double soma;
  public void Inserir(ContaPagar conta) {
    contas[this.qtd] = conta;
    qtd++; 
  }
  public ContaPagar[] Listar() { // ordena lista de contas a pagar por Vencimento e Fornevedor (para desempate)
    ComparadorFornecedor objeto = new ComparadorFornecedor();
    Array.Sort(contas, objeto);
    Array.Sort(contas);
    return contas;
  }
  public ContaPagar[] Pesquisar(int mes, int ano) { // retorna lista de contas de determinada data
    ContaPagar[] c1 = new ContaPagar[qtd];
    this.t = 0;
    foreach (ContaPagar conta in contas) {
      if (conta.Vencimento.Month == mes && conta.Vencimento.Year == ano) {
        c1[this.t] = conta;
        this.t++;
      }
    }
    return c1;
  }
  public double Total(int mes, int ano) { // retorna soma dos valores das contas de determinada data
    this.soma = 0;
    foreach (ContaPagar conta in contas) {
      if (conta.Vencimento.Month == mes && conta.Vencimento.Year == ano) {
        this.soma += conta.Valor;
      }
    }
    return this.soma;
  }
  public override string ToString() { // Atributos da classe Empresa
    return $"  Nome: {this.Nome}\n" +
      $"  Quantidade contas a pagar: {this.Qtd}";
  } 
}

// Essa é a resolução da questão 01, que valia 35 pontos:

public class ContaPagar : IComparable { // Interface para ordenação por DateTime
  public string Fornecedor {get; set;}
  public DateTime Vencimento {get; set;}
  public double Valor {get; set;}
  public int CompareTo(object obj) {
    ContaPagar c2 = (ContaPagar) obj;
    return this.Vencimento.CompareTo(c2.Vencimento);
  }
  public override string ToString() { // Atributos da classe ContaPagar
    return $"  Fornecedor: {this.Fornecedor}\n" +
      $"  Vencimento: {this.Vencimento:dd/MM/yyyy}\n" +
      $"  Valor: R$ {this.Valor:0.00}";
  } 
}
public class ComparadorFornecedor : IComparer { // Interface para ordenação por string
  public int Compare(object obj1, object obj2) {
    ContaPagar c1 = (ContaPagar) obj1;
    ContaPagar c2 = (ContaPagar) obj2;
    return c1.Fornecedor.CompareTo(c2.Fornecedor);
  }
} 

// Essa é a resolução da questão 03, que valia 30 pontos.

public class Program {
  public static void Main() { // classe principal para testar as classes
    
    ContaPagar[] contas = new ContaPagar[4]; // vetor de contas a pagar

    // criação do objeto empresa
    
    Empresa e1 = new Empresa {Nome = "Taberna Records", Contas = contas};

    // criação de objetos de contas a pagar
    
    ContaPagar c1 = new ContaPagar {Fornecedor = "Zorzal Produções", Vencimento = DateTime.Parse("2022-12-25"), Valor = 302.45};
    ContaPagar c2 = new ContaPagar {Fornecedor = "CDH Cast", Vencimento = DateTime.Parse("2022-12-11"), Valor = 639.93};
    ContaPagar c3 = new ContaPagar {Fornecedor = "New Blueburry", Vencimento = DateTime.Parse("2022-11-03"), Valor = 39.91};
    ContaPagar c4 = new ContaPagar {Fornecedor = "Blueburry", Vencimento = DateTime.Parse("2022-11-03"), Valor = 60.57};

    // inserção de objetos contas a pagar no vetor de contas
    
    e1.Inserir(c1);
    e1.Inserir(c2);
    e1.Inserir(c3);
    e1.Inserir(c4);

    // métodos da classe empresa
    
    ContaPagar[] lista1 = e1.Listar();
    ContaPagar[] lista2 = e1.Pesquisar(11, 2022);
    double total = e1.Total(12, 2022);

    // impressão dos resultados

    Console.WriteLine($"Empresa:\n{e1}\n");
    
    Console.WriteLine("Listar:");
    foreach (ContaPagar conta in lista1) {
      Console.WriteLine($"{conta}\n");
    }

    Console.WriteLine("Pesquisar:");
    foreach (ContaPagar conta in lista2) {
      if (conta != null)
        Console.WriteLine($"{conta}\n");
    }
    
    Console.WriteLine($"Total: R$ {total:0.00}\n");
    
  }
}