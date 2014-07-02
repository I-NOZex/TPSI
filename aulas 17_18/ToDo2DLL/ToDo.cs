using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo2DLL
{
    public class ToDo {
        private string tarefa;
        private DateTime dataTarefa;
        private DateTime dataConclusao;
        private bool concluido;

        public string Tarefa {
            get { return this.tarefa; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    this.tarefa = value;
                }
                else {
                    throw new ArgumentNullException("Introduza uma descrição da tarefa.");
                }
            }
        }

        public DateTime DataTarefa {
            get { return this.dataTarefa; }
            set {
                if (value > DateTime.Now) {
                    this.dataTarefa = value;
                }
                else {
                    throw new ArgumentException("Introduza uma data superior à atual.");
                }
            }
        }

        public DateTime DataConclusao {
            get { return this.dataConclusao; }
            set {
                if (value > DateTime.Now) {
                    this.dataConclusao = value;
                }
                else {
                    throw new ArgumentException("Introduza uma data superior à atual.");
                }
            }
        }

        public bool Concluido {
            get { return this.concluido; }
            set {
                if (value != null) {
                    this.concluido = value;
                }
                else {
                    throw new ArgumentException("Defina o estado de conclusão.");
                }
            }
        }

        public void changeState() {
            if (this.Concluido == true)
                this.Concluido = false;
            else if (this.Concluido == false)
                this.Concluido = true;
        }
    }
}
