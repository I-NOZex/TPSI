using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiThreadingWinForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void thread1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            pb.Value = e.ProgressPercentage;
        }

        private void thread1_DoWork(object sender, DoWorkEventArgs e) {
            int limite = 100;
            int j = 0;
            //a cada iteração verifica se o thread foi cancelado e faz o report do progresso!
            for(int i = 0; i < limite; i++){
                if(thread1.CancellationPending){
                    e.Cancel = true;
                    break;
                }
                    thread1.ReportProgress(i);
                    Thread.Sleep(500);
                    j = i;
            }
                e.Result = i;
        }

        private void thread1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Cancelled){
                MessageBox.Show("A operação foi cancelada!");
            } else {
                MessageBox.Show("terminou! " + e.Result);
            }
        }

        private void btn_free_Click(object sender, EventArgs e) {
            MessageBox.Show("Test");
        }
    }
}
