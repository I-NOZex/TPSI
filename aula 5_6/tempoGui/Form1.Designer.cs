namespace tempoGui {
    partial class frm_tempo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tempo));
            this.btn_mostraHoras = new System.Windows.Forms.Button();
            this.edt_h = new System.Windows.Forms.TextBox();
            this.edt_m = new System.Windows.Forms.TextBox();
            this.edt_s = new System.Windows.Forms.TextBox();
            this.lb_h = new System.Windows.Forms.Label();
            this.lb_m = new System.Windows.Forms.Label();
            this.lb_s = new System.Windows.Forms.Label();
            this.btn_addHoras = new System.Windows.Forms.Button();
            this.edt_incH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_mostraHoras
            // 
            this.btn_mostraHoras.Location = new System.Drawing.Point(10, 130);
            this.btn_mostraHoras.Name = "btn_mostraHoras";
            this.btn_mostraHoras.Size = new System.Drawing.Size(260, 39);
            this.btn_mostraHoras.TabIndex = 0;
            this.btn_mostraHoras.Text = "Mostrar Horas";
            this.btn_mostraHoras.UseVisualStyleBackColor = true;
            this.btn_mostraHoras.Click += new System.EventHandler(this.btn_mostraHoras_Click);
            this.btn_mostraHoras.MouseEnter += new System.EventHandler(this.btn_mostraHoras_MouseEnter);
            this.btn_mostraHoras.MouseLeave += new System.EventHandler(this.btn_mostraHoras_MouseLeave);
            // 
            // edt_h
            // 
            this.edt_h.Location = new System.Drawing.Point(101, 23);
            this.edt_h.Name = "edt_h";
            this.edt_h.Size = new System.Drawing.Size(154, 20);
            this.edt_h.TabIndex = 1;
            // 
            // edt_m
            // 
            this.edt_m.Location = new System.Drawing.Point(101, 55);
            this.edt_m.Name = "edt_m";
            this.edt_m.Size = new System.Drawing.Size(154, 20);
            this.edt_m.TabIndex = 2;
            // 
            // edt_s
            // 
            this.edt_s.Location = new System.Drawing.Point(101, 90);
            this.edt_s.Name = "edt_s";
            this.edt_s.Size = new System.Drawing.Size(154, 20);
            this.edt_s.TabIndex = 3;
            // 
            // lb_h
            // 
            this.lb_h.AutoSize = true;
            this.lb_h.Location = new System.Drawing.Point(48, 26);
            this.lb_h.Name = "lb_h";
            this.lb_h.Size = new System.Drawing.Size(38, 13);
            this.lb_h.TabIndex = 4;
            this.lb_h.Text = "Horas:";
            // 
            // lb_m
            // 
            this.lb_m.AutoSize = true;
            this.lb_m.Location = new System.Drawing.Point(48, 58);
            this.lb_m.Name = "lb_m";
            this.lb_m.Size = new System.Drawing.Size(47, 13);
            this.lb_m.TabIndex = 5;
            this.lb_m.Text = "Minutos:";
            // 
            // lb_s
            // 
            this.lb_s.AutoSize = true;
            this.lb_s.Location = new System.Drawing.Point(37, 93);
            this.lb_s.Name = "lb_s";
            this.lb_s.Size = new System.Drawing.Size(58, 13);
            this.lb_s.TabIndex = 6;
            this.lb_s.Text = "Segundos:";
            // 
            // btn_addHoras
            // 
            this.btn_addHoras.Location = new System.Drawing.Point(132, 185);
            this.btn_addHoras.Name = "btn_addHoras";
            this.btn_addHoras.Size = new System.Drawing.Size(138, 39);
            this.btn_addHoras.TabIndex = 7;
            this.btn_addHoras.Text = "Incrementar Horas...";
            this.btn_addHoras.UseVisualStyleBackColor = true;
            this.btn_addHoras.Click += new System.EventHandler(this.btn_addHoras_Click);
            // 
            // edt_incH
            // 
            this.edt_incH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_incH.Location = new System.Drawing.Point(10, 185);
            this.edt_incH.Name = "edt_incH";
            this.edt_incH.Size = new System.Drawing.Size(116, 38);
            this.edt_incH.TabIndex = 8;
            // 
            // frm_tempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 236);
            this.Controls.Add(this.edt_incH);
            this.Controls.Add(this.btn_addHoras);
            this.Controls.Add(this.lb_s);
            this.Controls.Add(this.lb_m);
            this.Controls.Add(this.lb_h);
            this.Controls.Add(this.edt_s);
            this.Controls.Add(this.edt_m);
            this.Controls.Add(this.edt_h);
            this.Controls.Add(this.btn_mostraHoras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_tempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tempo GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mostraHoras;
        private System.Windows.Forms.TextBox edt_h;
        private System.Windows.Forms.TextBox edt_m;
        private System.Windows.Forms.TextBox edt_s;
        private System.Windows.Forms.Label lb_h;
        private System.Windows.Forms.Label lb_m;
        private System.Windows.Forms.Label lb_s;
        private System.Windows.Forms.Button btn_addHoras;
        private System.Windows.Forms.TextBox edt_incH;
    }
}

