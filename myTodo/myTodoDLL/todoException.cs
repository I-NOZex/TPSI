using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTodoDLL{
    public class todoException : Exception {
        public todoException() : base("Ocorreu uma excepçao") { }
        public todoException(string message) : base(message) { }
        public todoException(string message, Exception inExcept) : base(message, inExcept) { }
    }
}
