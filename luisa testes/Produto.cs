using System;

class Produto{
  private static List<Produto> prods = new List<Produto>();
  protected string Nome;
  protected static int Id;
  protected double Preco;
  protected string Estudio;
  protected int Qtd;
  
  public string nome{
    get{
      return Nome;
    }set{
      if(value != null)Nome = value;
    }
  }
  public int id{
    get{
      return Id;
    }set{
      if(value > 0)Id = value;
    }
  }
  public double preco{
    get{
      return Preco;
    }set{
      if(value > 0)Preco = value;
    }
  }
  public string estudio{
    get{
      return Estudio;
    }set{
      if(value != null)Estudio = value;
    }
  }
  public int qtd{
    get{
      return Qtd;
    }set{
      if(value <= 0) Qtd = 0;
      else{
        value = Qtd;  
      }
    }
  }
  public Produto(string nome, int id, double preco, string estudio, int qtd){
    this.nome = nome;
    this.id = id;
    this.preco = preco;
    this.estudio = estudio;
    this.qtd = qtd;
  }
  public override string ToString() {
    return $"{nome} - {id} - {preco} - {estudio} - {qtd}"; 
  }
}
class Jogo:Produto{
  public Jogo(string nome, int id, double preco, string estudio, int qtd):base(nome, id, preco, estudio, qtd){
    this.nome = nome;
    this.id = id;
    this.preco = preco;
    this.estudio = estudio;
    this.qtd = qtd;
  }
}
class HQ:Produto
  { 
  private int Edicao;

  public int edicao{
    get{
      return Edicao;
    }set{
      if(value > -1)Edicao = value;
    }
  }

  public HQ(string nome, int id, double preco, int edicao, string estudio, int qtd):base(nome, id, preco, estudio, qtd){
    this.edicao = edicao;
    this.nome = nome;
    this.id = id;
    this.preco = preco;
    this.estudio = estudio;
    this.qtd = qtd;
  }
  
  public override string ToString() {
    return $"{nome} - {id} - {preco} - {edicao} - {estudio}";  
  }
}