
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;

public class Arquivo {
   
    public boolean cadastrar(Produto Produto){
        boolean status = false;
        try{
            BufferedWriter bw = new BufferedWriter(new FileWriter(Produto.Codigo+".dat"));
            bw.write(Produto.Nome + ";" + Produto.Preco + ";" + Produto.Marca + ";" + Produto.Estoque);
            bw.close();
            status = true;
        }catch(Exception e) {
            System.out.println("Erro: " + e);
        }
        return status;
    }
    
    public Produto consultar(String Codigo){
        Produto Produto = null;
        try {
            Produto = new Produto();
            BufferedReader br = new BufferedReader(new FileReader(Codigo+".dat"));
            String linha;
            String registro[] = new String[3];
            while ((linha = br.readLine()) != null) {
                 registro = linha.split(";");
                 Produto.Codigo = Integer.parseInt(Codigo);
                 Produto.Nome = registro[0];
                 Produto.Preco =  Float.parseFloat(registro[1]);
                 Produto.Marca = registro[2];
                 Produto.Estoque = Integer.parseInt(registro[3]);
            }
            /*while ((linha = br.readLine()) != null) {
                 registro = linha.split(";");
                 Produto.Codigo = Integer.parseInt(Codigo);
                 Produto.Nome = "aaa";
                 Produto.Preco =  Float.parseFloat("1.0");
                 Produto.Marca = "Marca";
                 Produto.Estoque = Integer.parseInt("56");
            }*/
            br.close();
        } catch (Exception e) {
            System.out.println("Erro: " + e);
        }
        return Produto;
    }

}
