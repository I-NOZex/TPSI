using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            string[] palavras;
            string texto = "";
            StreamReader re;
            string filename = "";
            dlg_openfile.ShowDialog();
            filename = dlg_openfile.FileName;
            re = new StreamReader(filename, Encoding.UTF8);
            string input = null;
            while((input = re.ReadLine()) !=null) {
                lbx_txtOrg.Items.Add(input);
                texto += input+"\n";
            }
            re.Close();
            //texto = texto.Replace('.', ' ');
            //texto = texto.Replace(',', ' ');
            texto = texto.Replace("\n\n", " ");
            texto = texto.Replace('\n', ' ');
            palavras = texto.Split(' ');
            Array.Sort(palavras);
            lbx_ord.Items.AddRange(palavras);
            lbx_ord.Sorted = true;

            //Criação de um array de ParPalavraContador com tantos elementos quantos os elementos de um arra
            //(arrayPalavras).
            ParPalavraContador[] palavrasContador = new ParPalavraContador[palavras.Length];
            //Adicionar um novo objecto ao array
            for (int i = 0; i < palavras.Length; i++ ) {
                    foreach (ParPalavraContador palavra in palavrasContador) {
                        if ((palavra != null) && (palavra.Palavra == palavras[i])) {
                            palavra.Contador++;
                        }else {
                            ParPalavraContador p = new ParPalavraContador();
                            p.Palavra = palavras[i];
                            p.Contador = 1;
                            palavrasContador[i] = p;
                        }                        
                    }
            }

            dtgrid_ccount.DataSource = palavrasContador;
           
        }
    }
}
