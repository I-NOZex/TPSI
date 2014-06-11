using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempoDLL {
    public class Tempo {
        private int hora;
        private int minuto;
        private int segundo;

        public int Hora {
            set {
                if (value >= 0 && value < 24) {
                    this.hora = value;
                }
                else {
                    throw new Exception("Hora inválida!");
                }
            }
            get {
                return hora;
            }
        }

        public int Minuto {
            set {
                if (value >= 0 && value <= 59) {
                    this.minuto = value;
                }
                else {
                    throw new Exception("Minuto inválido!");
                }
            }
            get {
                return minuto;
            }
        }

        public int Segundo {
            set {
                if (value >= 0 && value <= 59) {
                    this.segundo = value;
                }
                else {
                    throw new Exception("Segundo inválida!");
                }
            }
            get {
                return segundo;
            }
        }

        public override string ToString() {
            return string.Format("{0}h {1}min {2}seg", this.Hora, this.Minuto, this.Segundo);
        }
    }
}
