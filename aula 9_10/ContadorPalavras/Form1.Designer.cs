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
            this.lb_txt = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb_txtOrg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // lb_txt
            // 
            this.lb_txt.FormattingEnabled = true;
            this.lb_txt.Location = new System.Drawing.Point(12, 67);
            this.lb_txt.Name = "lb_txt";
            this.lb_txt.Size = new System.Drawing.Size(461, 147);
            this.lb_txt.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 269);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(461, 173);
            this.listBox1.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Texto Original:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_txtOrg);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lb_txt);
            this.Controls.Add(this.btn_ler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ler;
        private System.Windows.Forms.OpenFileDialog dlg_openfile;
        private System.Windows.Forms.ListBox lb_txt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lb_txtOrg;
        private System.Windows.Forms.Label label1;
    }
}

