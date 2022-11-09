/* 
1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. 
A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o 
dobro dos elementos da 1ª coluna.
*/

using System;

namespace atividadeAVMB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //popular matriz
            int i, j;
            int[,] matriz = new int[5,3];
            
            for(i = 0; i < 5; i++){
                for(j = 0; j < 3; j++){
                    if(j == 0){
                        Console.Write("Digite um nº: ");
                        matriz[i,0] = int.Parse(Console.ReadLine() + "");
                    }
                    else if(j == 1){
                        matriz[i,1] = matriz[i,0] + 10;
                    }
                    else if(j == 2){
                        matriz[i,2] = matriz[i,0] * 2;
                    }
                    else{
                        continue;
                    }
                    
                }
            }
            //visualização
            for(i = 0; i < 5; i++){
                Console.WriteLine("");
                for(j = 0; j < 3; j++){ 
                    Console.Write(matriz[i,j] + "         ");      
                }
                //Console.Write("\t");
            }

        }
    }
}
