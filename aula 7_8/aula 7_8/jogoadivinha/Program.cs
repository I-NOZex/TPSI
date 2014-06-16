using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoadivinha {
    class Program {
        static void Main(string[] args) {
            int limInf = 0;
            int limSup = 10;
            int numTent = 5;
            int meuNumero = 0;

        loop:
            Console.Clear();

            Jogo j = new Jogo(limSup, limInf, numTent);

            Console.WriteLine("Acabei de pensar num número entre {0} e {1}.\nConsegue adivinhá-lo em {2} tentativas?", limInf, limSup, numTent);

            while(j.PodeJogar()){
                try {
                    meuNumero = int.Parse(Console.ReadLine());

                    if (j.Tentativa(meuNumero) == true) {
                        Console.WriteLine("Parabéns!\nAcertou em cheio!");
                        break;
                    }
                    else {
                        if (j.PodeJogar() == false) {
                            Console.WriteLine("Esgotou todas as tentativas :(\nO número era {0}.",j.NumeroSorteado);
                        }
                        else {
                            Console.WriteLine("O seu número é {0} que o meu.", j.Ajuda());
                        }
                    }
                }catch (FormatException){
                    Console.WriteLine("Cuidado, deve inserir um número!");
                }
                
            }
            Console.WriteLine("Deseja voltar a jogar? :D\nS/N");
            if (Console.ReadLine().ToUpper() == "S")
                goto loop;
            Console.WriteLine("Dogh!");
        }
    }
}
