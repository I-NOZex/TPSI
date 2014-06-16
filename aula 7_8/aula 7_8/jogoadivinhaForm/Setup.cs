using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoadivinhaForm {
    public partial class Setup : Form {
        public Setup() {
            InitializeComponent();
        }

        public string Edt_max {
            get {
                return edt_max.Text;
            }
        }
        public string Edt_min {
            get {
                return edt_min.Text;
            }
        }
        public string Edt_ntent {
            get {
                return edt_ntent.Text;
            }
        }

        private void btn_play_Click(object sender, EventArgs e) {
            Jogo jogo = new Jogo(this);
            jogo.Show();
            this.Hide();
        }

        private void Setup_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
