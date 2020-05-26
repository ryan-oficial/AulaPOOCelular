using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = null;
            string enviarmensagem;
            

            Celular samsung = new Celular();
            Console.WriteLine ("Qual a cor do celular?");
            samsung.cor = Console.ReadLine();

            Console.WriteLine ("\nQual o modelo?");
            samsung.cor = Console.ReadLine();

            Console.WriteLine ("\nQual tamanho do celular?\nPequeno\nMédio\nGrande");
            samsung.cor = Console.ReadLine();
            
            do  {
                Console.WriteLine ("Deseja ligar o celular?");
                samsung.ligado = samsung.TraduzConsole(Console.ReadLine());
            }while(!samsung.ligado);
                Console.WriteLine("\nSeu celular esta ligado!");
            
            
                do{
                    Console.WriteLine("Voce pode escolher entre:\n\nFazer ligaçao\nEnviar mensagem\nDesligar"); 
                    resposta = Console.ReadLine();
                
                    switch(resposta){
                        case "fazer ligaçao":
                        Console.WriteLine("Fazendo a ligaçao . . . \n");
                        break;

                        case "enviar mensagem":
                        Console.WriteLine("Qual a sua mensagem? ");
                        enviarmensagem = Console.ReadLine();
                        Console.WriteLine("Sua mensagem foi enviada \n");
                        break;

                        case "desligar":
                        Console.WriteLine("Desligando . . . \n");
                        break;


                        default:
                        Console.WriteLine("Desculpe mas voce nao pode fazer isso \n");
                        break;
                   
                   
                    }
                }while(resposta != "0");
              

         }
    }
}
