using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad {
    public partial class inputBox : Form {
        public string input;
        public inputBox() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            input = txt_user.Text;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void inputBox_FormClosing(object sender, FormClosingEventArgs e) {
        }
    }
}
