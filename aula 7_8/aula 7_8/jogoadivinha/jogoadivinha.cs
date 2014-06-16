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

namespace jogoadivinha {
    class Jogo {

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
                limInferior = value;
            }
        }
        public int NumeroSorteado {
            get {
                return numeroSorteado;
            }
            set {
                limInferior = value;
            }
        }
        public int NumMaxTentativas {
            get {
                return numMaxTentativas;
            }
            set {
                limInferior = value;
            }
        }
        public int NumTentado {
            get {
                return numTentado;
            }
            set {
                limInferior = value;
            }
        }
        public int NumTentativas {
            get {
                return numTentativas;
            }
            set {
                limInferior = value;
            }
        }

        public Jogo(int limSuperior, int limInferior, int numMaxTentativas) {
        }

        public string Ajuda() {
            return "";
        }

        public bool PodeJogar() {
            return false;
        }

        private int RandomNumber(int min, int max) {
            Random random = new Random();
            return random.Next(min, max);
        }

        public bool Tentativa() {
            return false;
        }

    }
}
