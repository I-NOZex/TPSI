namespace jogoadivinhaForm {
    partial class Jogo {
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
            this.pnl_jogo = new System.Windows.Forms.Panel();
            this.edt_tent = new System.Windows.Forms.TextBox();
            this.btn_try = new System.Windows.Forms.Button();
            this.lb_titleJogo = new System.Windows.Forms.Label();
            this.lb_tent = new System.Windows.Forms.Label();
            this.lb_intro = new System.Windows.Forms.Label();
            this.pnl_jogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_jogo
            // 
            this.pnl_jogo.Controls.Add(this.edt_tent);
            this.pnl_jogo.Controls.Add(this.btn_try);
            this.pnl_jogo.Controls.Add(this.lb_titleJogo);
            this.pnl_jogo.Controls.Add(this.lb_tent);
            this.pnl_jogo.Controls.Add(this.lb_intro);
            this.pnl_jogo.Location = new System.Drawing.Point(12, 12);
            this.pnl_jogo.Name = "pnl_jogo";
            this.pnl_jogo.Size = new System.Drawing.Size(699, 387);
            this.pnl_jogo.TabIndex = 0;
            // 
            // edt_tent
            // 
            this.edt_tent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tent.Location = new System.Drawing.Point(193, 200);
            this.edt_tent.Name = "edt_tent";
            this.edt_tent.Size = new System.Drawing.Size(490, 27);
            this.edt_tent.TabIndex = 1;
            // 
            // btn_try
            // 
            this.btn_try.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_try.FlatAppearance.BorderSize = 0;
            this.btn_try.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_try.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_try.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_try.Location = new System.Drawing.Point(33, 315);
            this.btn_try.Name = "btn_try";
            this.btn_try.Size = new System.Drawing.Size(637, 42);
            this.btn_try.TabIndex = 2;
            this.btn_try.Text = "Será?";
            this.btn_try.UseVisualStyleBackColor = false;
            this.btn_try.Click += new System.EventHandler(this.btn_try_Click);
            // 
            // lb_titleJogo
            // 
            this.lb_titleJogo.AutoSize = true;
            this.lb_titleJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titleJogo.Location = new System.Drawing.Point(96, 18);
            this.lb_titleJogo.Name = "lb_titleJogo";
            this.lb_titleJogo.Size = new System.Drawing.Size(535, 39);
            this.lb_titleJogo.TabIndex = 6;
            this.lb_titleJogo.Text = "Bem vindo ao Jogo do Adivinha!";
            // 
            // lb_tent
            // 
            this.lb_tent.AutoSize = true;
            this.lb_tent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tent.Location = new System.Drawing.Point(22, 203);
            this.lb_tent.Name = "lb_tent";
            this.lb_tent.Size = new System.Drawing.Size(165, 22);
            this.lb_tent.TabIndex = 4;
            this.lb_tent.Text = "DO YOUR BEST!";
            // 
            // lb_intro
            // 
            this.lb_intro.AutoSize = true;
            this.lb_intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_intro.Location = new System.Drawing.Point(19, 157);
            this.lb_intro.Name = "lb_intro";
            this.lb_intro.Size = new System.Drawing.Size(662, 22);
            this.lb_intro.TabIndex = 3;
            this.lb_intro.Text = "Pensei num número... Estarás à altura de o descobrir em apenas {0} tentativas? ;)" +
    "";
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 402);
            this.Controls.Add(this.pnl_jogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vamos jogar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Jogo_FormClosed);
            this.Load += new System.EventHandler(this.Jogo_Load);
            this.pnl_jogo.ResumeLayout(false);
            this.pnl_jogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_jogo;
        private System.Windows.Forms.Label lb_titleJogo;
        private System.Windows.Forms.Label lb_tent;
        private System.Windows.Forms.Label lb_intro;
        private System.Windows.Forms.Button btn_try;
        private System.Windows.Forms.TextBox edt_tent;
    }
}

