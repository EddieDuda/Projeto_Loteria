using System;
class apostas {
 
  //criamos um modulo para a entrada de dados da matriz de aposta
  static void matriz_da_aposta(int [,] matrizaposta){
    int aposta = 0;
    
    Console.WriteLine("Olá jogador! Vamos começar suas apostas!");
    Console.WriteLine("Aposte 1 para a vitória do time 1\nAposte 0 para empate\nAposte 2 para a vitória do time 2\nAposte 3 para a vitória do time 1 e empate\nAposte 4 para a vitória do time 2 e empate\n");
    Console.WriteLine("Qual será sua aposta para:");
    
    //fizemos um jogo de for, if e else if pra conseguir preencher tudo da maneira que o apostador deseja
    //For parar passar as linhas   
    for(int linha = 0; linha < 13; linha++){
        Console.WriteLine($"Jogo {linha+1}\nDiga sua aposta");
        aposta = int.Parse(Console.ReadLine());
        //Aqui colocamos um while que faz o numero ser obrigatoriamente uma aposta valida
        while(aposta > 4){
            Console.WriteLine("Aposta invalida, por favorcoloque um numero entre 0 e 4");
            aposta = int.Parse(Console.ReadLine());
        }
        //Esse if e else if vão identificar a aposta e preencher as colunas correspondentes na matriz
        if(aposta == 1){
            matrizaposta[linha,0] = 1;
        }else if(aposta == 0){
            matrizaposta[linha,1] = 1;
        }else if(aposta == 2){
            matrizaposta[linha,2] = 1;
        }else if(aposta == 3){
            matrizaposta[linha,0] = 1;
            matrizaposta[linha,1] = 1;
        }else if(aposta == 4){
            matrizaposta[linha,1] = 1;
            matrizaposta[linha,2] = 1;
        }
    }  
      
  }
  
  //criamos um modulo para apresentar os resultados da aposta
  static void resultado(int[,] matrizaposta, int[,] matrizresultado){
    int linha = 0, coluna = 0, iguais = 0;
   
    //um for que vai ler cada elemento de cada coluna e linha da matrizaposta
    //e caso o elemento da matriz aposta seja igual a 1
    //e um elemento na mesma posição na matriz de resultado seja igual a 1
    //irá se somado 1 a uma variavel chamada iguais, que será responsavel por dizer a quantidade de acertos na aposta
    for (linha = 0; linha < 13; linha++){
        for (coluna = 0; coluna < 3; coluna++){
            if(matrizaposta[linha, coluna] == 1 && matrizresultado[linha, coluna] == 1){
                iguais++;
            }
        }
    }
    
    //mostrando o número de acertos
    Console.WriteLine("\n");
    Console.WriteLine($"Resultado = {iguais}");
        
  }
  static void Main() {
    
    //criando as duas matrizes e declarando as variaveis
    int[,] matrizaposta = new int[13,3];
    int[,] matrizresultado = new int[13,3]{{ 0,0,1 }, { 1,0,0 }, { 1,0,0 }, { 0,0,1 }, { 0,0,1 }, { 0,1,0 }, { 0,0,1 }, { 1,0,0 }, { 1,0,0 }, { 0,1,0}, { 0,0,1 }, { 0,1,0 }, { 0,0,1 }};
    
    //chamando o modulo que faz a matriz de aposta
    matriz_da_aposta(matrizaposta);

    //chamando o modulo que mostra o resultado
    resultado(matrizaposta, matrizresultado);
    }
}
