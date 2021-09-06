namespace DIO.TESTE
{
    public class serie : entidadebase
    { 
        // atriburos
      private genero genero {get; set;}

      private string titulo {get; set;}

      private string descricao {get; set;}

      private int ano {get; set;}

      private bool Excluido {get; set;}
      

    }
    public serie(int id, genero genero, string titulo, string descricao,int ano)
    {
        // metodos 
        this.id = id;
        this.genero = genero;
        this. titulo = titulo;
        this.descricao = descricao;
        this.ano = ano;
        this.excluido = false;
    }    
    public override string ToString()
    {
        string retorno = "";
        retorno += "genero: " + this.genero + Environment.NewLine;
        retorno +=  "titulo: " + this.titulo + Environment.NewLine;
        retorno +=  " descricao: " + this.descricao + Environment.NewLine;
        retorno += " ano de inicio: "  this.ano;
        return retorno;
    }
    public string retornaTitulo()
    {
        return this.titulo;
    }
    internal int retornarid()
     { 
             return this.id;
     }
     public void Excluir()
     {
         this.Excluir = true;
     }
}


