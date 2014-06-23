using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcao02 {
    class MinhasExcepcoes : ApplicationException {
        public MinhasExcepcoes()
            :base("Operação ilegal."){  
        }  
        public MinhasExcepcoes(string mensagem)
            :base(mensagem){  
        }  
        public MinhasExcepcoes(string mensagem, Exception innerException)
            :base(mensagem, innerException)         {         }
    }
}
