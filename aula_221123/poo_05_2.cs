using Systems;
public class Premio {
  private string cliente = "Não declarado";
  private DateTime data = DateTime.Now;
  private object premio;
  public Premio(string c, DateTime d) {
    if(c != "") cliente = c;
    hoje = DateTime.Now;
    if (d >= hoje) data = d;
  }
  
}