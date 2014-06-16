/*
O Jogo da adivinha.
O jogo é muito simples. O computador sorteia um número aleatório num intervalo definido
pelo utilizador. Posteriormente o utilizador tem um
número pré-definido de tentativas
para adivinhar o número sorteado. A cada tentativa o computador emite uma mensagem
que indica se número sorteado é maior ou menor que o número indicado pelo utilizador.
Se o utilizador exceder o número máximo de tentativas o jogo termina. Se o utilizador
acertar o número escolhido ganha o jogo.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoadivinhaDll {
    public class Jogo {

        private int limInferior;
        private int limSuperior;
        private int numeroSorteado;
        private int numMaxTentativas;
        private int numTentado;
        private int numTentativas;

        public int LimInferior {
            get {
                return limInferior;
            }
            set {
                limInferior = value;
            }
        }
        public int LimSuperior {
            get {
                return limSuperior;
            }
            set {
                limSuperior = value;
            }
        }
        public int NumeroSorteado {
            get {
                return numeroSorteado;
            }
            set {
                numeroSorteado = value;
            }
        }
        public int NumMaxTentativas {
            get {
                return numMaxTentativas;
            }
            set {
                numMaxTentativas = value;
            }
        }
        public int NumTentado {
            get {
                return numTentado;
            }
            set {
                numTentado = value;
            }
        }
        public int NumTentativas {
            get {
                return numTentativas;
            }
            set {
                numTentativas = value;
            }
        }

        public Jogo(int limInferior, int limSuperior, int numMaxTentativas) {
            this.LimSuperior = limSuperior;
            this.LimInferior = limInferior;
            this.NumMaxTentativas = numMaxTentativas;
            this.NumeroSorteado = RandomNumber(LimInferior, LimSuperior);
        }

        public string Ajuda() {
            if (NumTentado > NumeroSorteado)
                return "Maior";
            else
                return "Menor";

        }

        public bool PodeJogar() {
            if (NumTentativas < NumMaxTentativas)
                return true;
            else
                return false;
        }

        private int RandomNumber(int min, int max) {
            Random random = new Random();
            return random.Next(min, max);
        }

        public bool Tentativa(int numTentado) {
            NumTentado = numTentado;
            NumTentativas++;
            if (numTentado == NumeroSorteado)
                return true;
            else
                return false;
        }

    }
}
