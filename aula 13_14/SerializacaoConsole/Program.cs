using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDLL;

namespace SerializacaoConsole {
    class Program{
        static void Main(string[] args) {
            ToDo t = new ToDo();
            t.Tarefa = "ouvir musica";
            t.DataTarefa = DateTime.Now.AddDays(5);
            t.Concluido = false;

            ToDo t2 = new ToDo();
            t2.Tarefa = "ver filme";
            t2.DataTarefa = DateTime.Now.AddDays(1);
            t2.Concluido = true;

            App app = new App();
            //app.addTodo(t);
            //app.addTodo(t2);
            //app.save();
            app.load("C:\\Users\\I-NOZex\\Documents\\Visual Studio 2012\\Projects\\aula 13_14\\feicheiro.xml");
        }
    }
}
