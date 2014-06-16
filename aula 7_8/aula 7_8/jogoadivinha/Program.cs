using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoadivinha {
    class Program {
        static void Main(string[] args) {
        loop:
            Console.WriteLine("Qual o limite minimo do número a gerar?");
            int limInf = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o limite maximo do número a gerar?");
            int limSup = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas tentativas deseja?");
            int numTent = int.Parse(Console.ReadLine());
            int meuNumero = 0;

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
