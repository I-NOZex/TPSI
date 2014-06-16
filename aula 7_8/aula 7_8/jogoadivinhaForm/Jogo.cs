using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jogoadivinhaDll;

namespace jogoadivinhaForm {
    public partial class Jogo : Form {

        private Setup setup;
        private jogoadivinhaDll.Jogo j;

        public Jogo(Setup setup) {
            this.setup = setup;
            InitializeComponent();
        }

        private void Jogo_FormClosed(object sender, FormClosedEventArgs e) {
            setup.Show();
        }

        private void Jogo_Load(object sender, EventArgs e) {
            int min = int.Parse(setup.Edt_min);
            int max = int.Parse(setup.Edt_max);
            int nTent = int.Parse(setup.Edt_ntent);
            j = new jogoadivinhaDll.Jogo(min, max, nTent);
            lb_intro.Text = string.Format("Pensei num número... Estarás à altura de o descobrir em apenas {0} tentativas? ;)", nTent);
        }

        private void btn_try_Click(object sender, EventArgs e) {
            int meuNumero = 0;

            if (j.PodeJogar()) {
                try {
                    meuNumero = int.Parse(edt_tent.Text);

                    if (j.Tentativa(meuNumero) == true) {
                        MessageBox.Show("Parabéns!\nAcertou em cheio!");
                    }else {
                        if (j.PodeJogar() == false) {
                            MessageBox.Show(string.Format("Esgotou todas as tentativas :(\nO número era {0}.", j.NumeroSorteado));
                        }
                        else {
                            MessageBox.Show(string.Format("O seu número é {0} que o meu.", j.Ajuda()));
                        }
                    }
                }
                catch (FormatException) {
                    MessageBox.Show("Cuidado, deve inserir um número!");
                }

            }
        }
    }
}
