using System;
class HelloWorld {
  static void resultado(int[,] matrizaposta, int[,] matrizresultado){
    int linha = 0, coluna = 0, iguais = 0;
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
    int[,] matrizaposta = new int[13,3];//matriz pronta pra teste{{ 1,0,0 }, { 1,1,0 }, { 0,1,1 }, { 0,0,1 }, { 1,1,0 }, { 0,0,1}, { 1,0,0 }, {1,1,0}, { 0,0,1 }, { 1,1,0}, { 0,1,1}, { 0,0,1 }, {1,1,0}};
    int[,] matrizresultado = new int[13,3]{{ 0,0,1 }, { 1,0,0 }, { 1,0,0 }, { 0,0,1 }, { 0,0,1 }, { 0,1,0 }, { 0,0,1 }, { 1,0,0 }, { 1,0,0 }, { 0,1,0}, { 0,0,1 }, { 0,1,0 }, { 0,0,1 }};
    int linha = 0, coluna = 0, iguais = 0;
    string confirmacao = " ";
    Console.WriteLine("Olá jogador! Vamos começar suas apostas!\nQual será sua aposta para:");
    for(linha = 0; linha < 13; linha++){
        Console.WriteLine($"jogo {linha+1}");
        for(coluna = 0; coluna < 3; coluna++){
            if(coluna == 0){
                Console.WriteLine("Deseja apostar na vitória do time 1?\ns = sim n = não");
                confirmacao = Console.ReadLine();
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
    resultado(matrizaposta, matrizresultado);
    }
}
