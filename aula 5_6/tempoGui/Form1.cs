using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempoDLL;

namespace tempoGui {
    public partial class frm_tempo : Form {
        public frm_tempo() {
            InitializeComponent();
        }

        private void btn_mostraHoras_Click(object sender, EventArgs e) {
            try {
                Tempo t = new Tempo();
                t.Hora = int.Parse(edt_h.Text);
                t.Minuto = int.Parse(edt_m.Text);
                t.Segundo = int.Parse(edt_s.Text);

                MessageBox.Show(t.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
