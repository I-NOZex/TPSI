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
            for (int i = 0; i < 100; i++)
                Thread.Sleep(100);
        }
    }
}
