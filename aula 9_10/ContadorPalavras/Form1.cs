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
            lbx_ord.Sorted = true;

            //Criação de um array de ParPalavraContador com tantos elementos quantos os elementos de um arra
            //(arrayPalavras).
            ParPalavraContador[] palavrasContador = new ParPalavraContador[palavras.Length];
            //Adicionar um novo objecto ao array
            foreach (var palavra in palavras) {
                
            }
            ParPalavraContador p = new ParPalavraContador();
            p.Palavra = palavras[i];
            p.Contador = 1;
            palavrasContador[palavras] = p;
            //Alterar o contador de uma determinada palavra
            palavrasContador[j].Contador = palavrasContador[j].Contador + 1;
        }
    }
}
