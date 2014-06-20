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
            texto = texto.TrimStart(' ');
            texto = texto.Replace("\n\n", " ");
            texto = texto.Replace('\n', ' ');
            palavras = texto.Split(' ');
            Array.Sort(palavras);
            lbx_ord.Items.AddRange(palavras);
            lbx_ord.Sorted = true;

            ParPalavraContador[] palavrasContador = new ParPalavraContador[palavras.Length];
            int totalPalavrasUsadas = 0;

            //
            for (int i = 0; i < palavras.Length; i++) {

                bool encontrou = false;
                for (int p = 0; p < totalPalavrasUsadas; p++) {
                    if (palavras[i] == palavrasContador[p].Palavra) {
                        encontrou = true;
                        palavrasContador[p].Contador++;
                        break;
                    }
                }
                //
                if (!encontrou) {
                    palavrasContador[totalPalavrasUsadas++] = new ParPalavraContador() {
                        Palavra = palavras[i],
                        Contador = 1
                    };
                }
            }

            //Criação de um array de ParPalavraContador com tantos elementos quantos os elementos de um arra
            //(arrayPalavras).
            /*ParPalavraContador[] palavrasContador = new ParPalavraContador[palavras.Length];
            //Adicionar um novo objecto ao array
            string lastw = null;
            for (int i = 0; i < palavras.Length; i++ ) {
                int j = 0;
                //ParPalavraContador p = new ParPalavraContador();
                //p.Palavra = palavras[i];
                //p.Contador = 1;
                //palavrasContador[i] = p;
                foreach (ParPalavraContador palavra in palavrasContador) {
                        //if (i == 0)
                            //break;

                        if ((i != 0) && ((j < i) || (palavra.Palavra == palavras[i]))) {
                            palavra.Contador++;
                        }
                        else {
                              //lastw = null;
                                ParPalavraContador p = new ParPalavraContador();
                                p.Palavra = palavras[i];
                                p.Contador = 1;
                                palavrasContador[i] = p;
                     
                        }
                        j++;

                }
                //if ((lastw != palavras[i])) {

                //}
                    //foreach (ParPalavraContador palavra in palavrasContador) {
                    //    if (i!=j){
                    //        if ((palavra != null) && (palavra.Palavra == palavras[i])) {
                    //            palavra.Contador++;
                    //        }else {
                    //            ParPalavraContador p = new ParPalavraContador();
                    //            p.Palavra = palavras[i];
                    //            p.Contador = 1;
                    //            palavrasContador[i] = p;
                    //        }   
                     
                    //    }
                    //}
            }*/

            dtgrid_ccount.DataSource = palavrasContador;
           
        }
    }
}
