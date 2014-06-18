using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorPalavras {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_ler_Click(object sender, EventArgs e) {
            StreamReader re;
            string filename = "";
            dlg_openfile.ShowDialog();
            filename = dlg_openfile.FileName;
            re = new StreamReader(filename, Encoding.UTF8);
            string input = null;
            while((input = re.ReadLine()) !=null) {
                lb_txt.Items.Add(input);
            }
            re.Close();
        }
    }
}
