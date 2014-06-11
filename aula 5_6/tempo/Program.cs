using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempoDLL;

namespace TempoConsole{
    class Program {
        static void Main(string[] args) {
            Tempo t = new Tempo();
            t.Hora = 10;
            t.Minuto = 20;
            t.Segundo = 59;
            Console.WriteLine(t.ToString());
            Console.Read();
        }
    }
}
