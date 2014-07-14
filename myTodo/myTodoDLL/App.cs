using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTodoDLL{
    public class App{
        private string user;
        private DateTime data;

        public string User {
            get { return this.user; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    this.user = value;   
                }
            }
        }
        public DateTime Data { get; set; }
    }
}
