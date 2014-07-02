using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo2DLL;

namespace ToDo2Console {
    class Program {
        static void Main(string[] args) {
            App app = new App();
            app.save();
        }
    }
}
