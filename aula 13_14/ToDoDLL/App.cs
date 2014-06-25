using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ToDoDLL {
    public class App {
        private string nomeApp;
        private DateTime dataInicio;
        private List<ToDo> todo_s;

        public string NomeApp {
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
            }else{
                this.Todo_s = new List<ToDo>();
                this.Todo_s.Add(todo);
            }
        }

        public void changeTodoState(ToDo todo) {
            ToDo myTodo = this.todo_s.Find(aliasT => aliasT.Tarefa == todo.Tarefa);
            todo.changeState();
        }

        public void save() {
            TextWriter t = new StreamWriter(System.IO.Path.GetTempPath());
            XmlSerializer x = new XmlSerializer(typeof(App));
            x.Serialize(t, this);
            t.Close();
        }

        public void save(string path) {
            TextWriter t = new StreamWriter(path);
            XmlSerializer x = new XmlSerializer(typeof(App));
            x.Serialize(t, this);
            t.Close();
        }

        public void load() {
            App app;
            TextReader t = new StreamReader(System.IO.Path.GetTempPath());
            XmlSerializer x = new XmlSerializer(typeof(App));
            app = (App)x.Deserialize(t);
            this.NomeApp = app.NomeApp;
            this.dataInicio = app.DataInicio;
            this.Todo_s = app.Todo_s;
            t.Close();
        }

        public void load(string path) {
            App app;
            TextReader t = new StreamReader(path);
            XmlSerializer x = new XmlSerializer(typeof(App));
            app = (App)x.Deserialize(t);
            this.NomeApp = app.NomeApp;
            this.dataInicio = app.DataInicio;
            this.Todo_s = app.Todo_s;
            t.Close();
        }
    }
}
