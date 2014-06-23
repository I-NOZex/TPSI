using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcao02 {
    class Program {
        static void Main(string[] args) {
            Teste t = new Teste();
            try {
                t.erro01();
            }
            catch (MinhasExcepcoes ex) {
                Console.WriteLine("Excepçao 1");
            } 
            //-----------------------
            try {
                t.erro02();
            }
            catch (MinhasExcepcoes ex) {
                Console.WriteLine("Excepçao 2");
            }
            //-----------------------
            try {
                t.erro03();
            }
            catch (MinhasExcepcoes ex) {
                Console.WriteLine("Excepçao 3");
            }
        }
    }
}
