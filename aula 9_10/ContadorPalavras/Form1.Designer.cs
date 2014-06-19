namespace ContadorPalavras {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn_ler = new System.Windows.Forms.Button();
            this.dlg_openfile = new System.Windows.Forms.OpenFileDialog();
            this.lbx_ord = new System.Windows.Forms.ListBox();
            this.lb_txtOrg = new System.Windows.Forms.Label();
            this.lb_plOrd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbx_txtOrg = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ler
            // 
            this.btn_ler.Location = new System.Drawing.Point(12, 12);
            this.btn_ler.Name = "btn_ler";
            this.btn_ler.Size = new System.Drawing.Size(114, 23);
            this.btn_ler.TabIndex = 0;
            this.btn_ler.Text = "Abrir Ficheiro";
            this.btn_ler.UseVisualStyleBackColor = true;
            this.btn_ler.Click += new System.EventHandler(this.btn_ler_Click);
            // 
            // dlg_openfile
            // 
            this.dlg_openfile.Filter = "Texto|*.txt";
            // 
            // lbx_ord
            // 
            this.lbx_ord.FormattingEnabled = true;
            this.lbx_ord.Location = new System.Drawing.Point(12, 275);
            this.lbx_ord.Name = "lbx_ord";
            this.lbx_ord.Size = new System.Drawing.Size(461, 186);
            this.lbx_ord.TabIndex = 4;
            // 
            // lb_txtOrg
            // 
            this.lb_txtOrg.AutoSize = true;
            this.lb_txtOrg.Location = new System.Drawing.Point(13, 48);
            this.lb_txtOrg.Name = "lb_txtOrg";
            this.lb_txtOrg.Size = new System.Drawing.Size(75, 13);
            this.lb_txtOrg.TabIndex = 5;
            this.lb_txtOrg.Text = "Texto Original:";
            // 
            // lb_plOrd
            // 
            this.lb_plOrd.AutoSize = true;
            this.lb_plOrd.Location = new System.Drawing.Point(13, 259);
            this.lb_plOrd.Name = "lb_plOrd";
            this.lb_plOrd.Size = new System.Drawing.Size(106, 13);
            this.lb_plOrd.TabIndex = 6;
            this.lb_plOrd.Text = "Palavras Ordenadas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 449);
            this.dataGridView1.TabIndex = 7;
            // 
            // lbx_txtOrg
            // 
            this.lbx_txtOrg.FormattingEnabled = true;
            this.lbx_txtOrg.Location = new System.Drawing.Point(16, 64);
            this.lbx_txtOrg.Name = "lbx_txtOrg";
            this.lbx_txtOrg.Size = new System.Drawing.Size(457, 173);
            this.lbx_txtOrg.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 473);
            this.Controls.Add(this.lbx_txtOrg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_plOrd);
            this.Controls.Add(this.lb_txtOrg);
            this.Controls.Add(this.lbx_ord);
            this.Controls.Add(this.btn_ler);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ler;
        private System.Windows.Forms.OpenFileDialog dlg_openfile;
        private System.Windows.Forms.ListBox lbx_ord;
        private System.Windows.Forms.Label lb_txtOrg;
        private System.Windows.Forms.Label lb_plOrd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbx_txtOrg;
    }
}

