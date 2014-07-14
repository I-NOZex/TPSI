using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTodoDLL{
    public class App{
        private string user;
        private DateTime data;
        private List<Todo> todo_s;

        public string User {
            get { return this.user; }
            set {
                if (!string.IsNullOrEmpty(value))
                    this.user = value;
                else
                    throw new todoException("O campo de utilizador é obrigatório");
            }
        }
        public DateTime Data { get; set; }

        public List<Todo> Todo_s { get; set; }

        /// <summary>
        /// Permite adicionar um TODO à lista de TODO's.
        /// Inicializa a lista caso ainda não tenha sido inicializada
        /// </summary>
        /// <param name="todo">Todo object</param>
        public void addTodo(Todo todo) {
            if (Todo_s == default(List<Todo>))
                Todo_s = new List<Todo>();
            Todo_s.Add(todo);
        }
    }
}
