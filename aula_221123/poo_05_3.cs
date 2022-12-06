using System;
public class Boleto {
  private string codBarras = "0000000000" + "0000000000" + "0000000000" + "0000000000" + "0000" ;
  private DateTime dataEmissao = DateTime.Now;
  private DateTime dataVencimento = DateTime.Now;
  private DateTime dataPagamento;
  private decimal valorBoleto;
  private decimal valorPago;
  private Pagamento situacaoPagamento;
  public Boleto() {}
  public Boleto(string cod, DateTime emissao, DateTime venc, decimal valor) {
    SetCodBarras(cod);
    SetDataEmissao(emissao);
    SetDataVenc(venc);
    SetValorBoleto(valor);
    situacaoPagamento = this.Situacao();
  }
  public void SetCodBarras(string cod) {
    if (cod != "") codBarras = cod;
  }
  public void SetDataEmissao(DateTime emissao) {
    if (emissao >= DateTime.Now ) dataEmissao = emissao;   
  }
  public void SetDataVenc(DateTime venc) {
    if (venc >= DateTime.Now ) dataVencimento = venc;   
  }
  public void SetValorBoleto(decimal valor) {
    if (valor >= 0 ) valorBoleto = valor;   
  }
  public string GetCodBarras() {
    return codBarras;
  }
  public DateTime GetDataEmissao() {
    return dataEmissao;
  }
  public DateTime GetDataVenc() {
    return dataVencimento;
  }
  public DateTime GetDataPag() {
    return dataPagamento;
  }
  public decimal GetValorBoleto() {
    return valorBoleto;
  }
  public decimal GetValorPago() {
    return valorPago;
  }
  public void Pagar(decimal valorPago) {
    if (valorPago > 0 && valorPago <= valorBoleto) {
      this.valorPago = valorPago;
      dataPagamento = DateTime.Now;
      situacaoPagamento = this.Situacao();
    }
  }
  public Pagamento Situacao() {
    if (valorPago > 0 && valorPago < valorBoleto) return Pagamento.PagoParcial;
    else if (valorPago == 0) return Pagamento.EmAberto;
    else return Pagamento.Pago;
  }
  public override string ToString() {
    return $"Código de barras: {codBarras}\n" +
      $"Data de emissão: {dataEmissao:dd/MM/yyyy}\n" +
      $"Data de vencimento: {dataVencimento:dd/MM/yyyy}\n" +
      $"Data de pagamento: {dataPagamento:dd/MM/yyyy}\n" +
      $"Valor do boleto: {valorBoleto:0.00}\n" +
      $"Valor pago: {valorPago:0.00}\n" +
      $"Situação do pagamento: {situacaoPagamento}"; 
  }
}
public enum Pagamento {
  EmAberto,
  PagoParcial,
  Pago
}
public class Program {
  public static void Main() {
    Boleto a = new Boleto();
    Console.WriteLine(a);
    Console.WriteLine();
    Boleto b = new Boleto("1111111111", DateTime.Now, DateTime.Parse("12/30/2022"), 1000);
    b.Pagar(333);
    Console.WriteLine(b);
    Console.WriteLine();
    Boleto c = new Boleto("222222222222222222", DateTime.Now, DateTime.Parse("12/15/2022"), 500);
    c.Pagar(500);
    Console.WriteLine(
      $"{c.GetCodBarras()}\n" +
      $"{c.GetDataEmissao()}\n" +
      $"{c.GetDataVenc()}\n" +
      $"{c.GetDataPag()}\n" +
      $"{c.GetValorBoleto()}\n" +
      $"{c.GetValorPago()}"
    );
  }
}