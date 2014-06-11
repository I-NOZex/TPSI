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
using Microsoft.VisualBasic;

namespace tempoGui {
    public partial class frm_tempo : Form {
        static Tempo t = new Tempo();
        public frm_tempo() {
            InitializeComponent();
        }

        private void btn_mostraHoras_Click(object sender, EventArgs e) {
            try {
                t.Hora = int.Parse(edt_h.Text);
                t.Minuto = int.Parse(edt_m.Text);
                t.Segundo = int.Parse(edt_s.Text);

                MessageBox.Show(t.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_mostraHoras_MouseEnter(object sender, EventArgs e) {
            btn_mostraHoras.BackColor = Color.Silver;
        }

        private void btn_mostraHoras_MouseLeave(object sender, EventArgs e) {
            btn_mostraHoras.BackColor = DefaultBackColor;
        }

        private void btn_addHoras_Click(object sender, EventArgs e) {
            int hora = int.Parse(edt_incH.Text);
            t.addHoras(hora);
            MessageBox.Show("Horas atualizadas:\n"+t.ToString());

        }
    }
}
