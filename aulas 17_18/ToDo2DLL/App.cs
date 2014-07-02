using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo2DLL {
    public class App {
        private string userName;
        private DateTime dataRegisto;
        private List<ToDo> todo_s;

        public string UserName {
            get;
            set;
        }
        public DateTime DataRegisto {
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
            int id = 0;
            DB db = new DB(".", "LP_DB");

            string values = string.Format("'{0}','{1}'", this.UserName, this.DataRegisto);
            try {
                id = db.insert("app", "username, data_reg", values);

                foreach (ToDo item in Todo_s) {
                    values = string.Format("'{0}','{1}','{2}'", item.Tarefa, item.DataTarefa, item.DataConclusao, item.Concluido, id);
                    db.insert(
                        "todo",
                        "tarefa, data_reg, data_concl, concluido, user_id",
                        values
                    );

                }
	        } catch (Exception ex) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);                
	        } finally {
                db.close();
            }
            Console.WriteLine(id);
        }

        public void load() {
            //
        }

    }
}
