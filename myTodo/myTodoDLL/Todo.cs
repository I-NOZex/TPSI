using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTodoDLL {
    public class Todo {
        private string tarefa;

        public DateTime Data { get; set; }
        public string Tarefa {
            get { return this.tarefa; }
            set {
                if (!string.IsNullOrEmpty(value))
                    this.tarefa = value;
                else
                    throw new todoException("Deve introduzir uma descrição da tarefa");
            }
        }
    }
}
