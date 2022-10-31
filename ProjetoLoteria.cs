using System;
class HelloWorld {
 
  //criamos um modulo para apresentar os resultados da aposta
  static void resultado(int[,] matrizaposta, int[,] matrizresultado){
    int linha = 0, coluna = 0;
   
    //um for que vai ler cada elemento de cada coluna e linha da matrizapost
    //e caso o elemento da matriz aposta seja igual a 1
    //e um elemento na mesma posição na matriz de resultado seja igual a 13
    //irá se somado 1 a uma variavel chamada oguais, que será responsavel por dizer a quantidade de acertos na aposta
    for (linha = 0; linha < 13; linha++){
        for (coluna = 0; coluna < 3; coluna++){
            if(matrizaposta[linha, coluna] == 1 && matrizresultado[linha, coluna] == 1){
                iguais++;
            }
        }
    }
    Console.WriteLine("\n");
    Console.WriteLine($"Resultado = {iguais}");
        
  }
  static void Main() {
    
    //criando as duas matrizes e declarando as variaveis
    int[,] matrizaposta = new int[13,3];//matriz pronta pra teste{{ 1,0,0 }, { 1,1,0 }, { 0,1,1 }, { 0,0,1 }, { 1,1,0 }, { 0,0,1}, { 1,0,0 }, {1,1,0}, { 0,0,1 }, { 1,1,0}, { 0,1,1}, { 0,0,1 }, {1,1,0}};
    int[,] matrizresultado = new int[13,3]{{ 0,0,1 }, { 1,0,0 }, { 1,0,0 }, { 0,0,1 }, { 0,0,1 }, { 0,1,0 }, { 0,0,1 }, { 1,0,0 }, { 1,0,0 }, { 0,1,0}, { 0,0,1 }, { 0,1,0 }, { 0,0,1 }};
    int linha = 0, coluna = 0, iguais = 0;
    string confirmacao = " ";
   
    //Aqui começa a entrada de dados do codigo
    //fizemos um jogo de for e if else if pra conseguir preencher tudo da maneira que o apostador deseja
    Console.WriteLine("Olá jogador! Vamos começar suas apostas!\nQual será sua aposta para:");
   
    //for parar passar as linhas   
    for(linha = 0; linha < 13; linha++){
        Console.WriteLine($"jogo {linha+1}");
        
      //for para passar as colunas
        for(coluna = 0; coluna < 3; coluna++){
            
          //if e else if para preencher os espaços da matriz de aposta
            if(coluna == 0){
                Console.WriteLine("Deseja apostar na vitória do time 1?\ns = sim n = não");
                confirmacao = Console.ReadLine();
              
              //if e else if para preencher com 1 ou 0 onde o apostador deseja marcar
                if(confirmacao == "s"){
                    matrizaposta[linha,coluna] = 1;
                }else if(confirmacao == "n"){
                    matrizaposta[linha,coluna] = 0;
                }
            }else if(coluna == 1){
                Console.WriteLine("Deseja apostar no empate ?");
                confirmacao = Console.ReadLine();
                if(confirmacao == "s"){
                    matrizaposta[linha,coluna] = 1;
                }else if(confirmacao == "n"){
                    matrizaposta[linha,coluna] = 0;
                }
            }else if(coluna == 2){
                Console.WriteLine("Deseja apostar na vitória do time 2?");
                confirmacao = Console.ReadLine();
                if(confirmacao == "s"){
                    matrizaposta[linha,coluna] = 1;
                }else if(confirmacao == "n"){
                    matrizaposta[linha,coluna] = 0;
                }
            }
        }
    }
   
    //chamando o modulo
    resultado(matrizaposta, matrizresultado);
    }
}
