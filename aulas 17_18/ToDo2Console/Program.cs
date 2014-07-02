using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo2DLL;

namespace ToDo2Console {
    class Program {
        static void Main(string[] args) {
            //Console.WriteLine((string)((int)false));
            ToDo t = new ToDo();
            t.Tarefa = "ouvir musica";
            t.DataTarefa = DateTime.Now.AddDays(5);
            t.DataConclusao = DateTime.Now.AddDays(7);
            t.Concluido = false;

            ToDo t2 = new ToDo();
            t2.Tarefa = "ver filme";
            t2.DataTarefa = DateTime.Now.AddDays(2);
            t2.DataConclusao = DateTime.Now.AddDays(7);
            t2.Concluido = true;

            App app = new App();
            app.UserName = "Ze mane";
            app.DataRegisto = DateTime.Now;
            app.addTodo(t);
            app.addTodo(t2);
            app.save();
        }
    }
}
