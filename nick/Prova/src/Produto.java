
public class Produto {
    
    public int Codigo;
    public String Nome;
    public Float Preco;
    public String Marca;
    public int Estoque;
    
    public Produto(){
        
    }
    
    public Produto(int codigo,String nome, Float preco, String marca, int estoque){
        this.Codigo = codigo;
        this.Preco = preco;
        this.Nome = nome;
        this.Marca = marca;
        this.Estoque = estoque;
    }
    
}
