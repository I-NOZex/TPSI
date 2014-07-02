using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo2DLL {
    public class App {
        private string userName;
        private DateTime dataInicio;
        private List<ToDo> todo_s;

        public string UserName {
            get;
            set;
        }
        public DateTime DataInicio {
            get;
            set;
        }
        public List<ToDo> Todo_s {
            get;
            set;
        }

        public void addTodo(ToDo todo) {
            if (this.Todo_s != default(List<ToDo>)) {
                this.Todo_s.Add(todo);
            }
            else {
                this.Todo_s = new List<ToDo>();
                this.Todo_s.Add(todo);
            }
        }

        public void changeTodoState(ToDo todo) {
            ToDo myTodo = this.todo_s.Find(aliasT => aliasT.Tarefa == todo.Tarefa);
            todo.changeState();
        }

        public void save() {
            DB db = new DB(".", "LP_DB");
            try {
                db.insert("app", "username", "'ze'");
	        } catch (Exception ex) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);                
	        } finally {
                db.close();
            }

        }

        public void load() {
            //
        }

    }
}
