using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcao02 {
    class Teste {
        public void erro01() { 
            throw new MinhasExcepcoes(); 
        }
        public void erro02() { 
            throw new MinhasExcepcoes("yuhuuu"); 
        }
        public void erro03() { 
            try { 
                int i; 
                i = 0; 
                i = 2 / i; 
            } catch (Exception e) { 
                throw new MinhasExcepcoes("Ups!", e); 
            } 
        } 
    }
}
