namespace jogoadivinhaForm {
    partial class Setup {
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
            this.pnl_setup = new System.Windows.Forms.Panel();
            this.edt_min = new System.Windows.Forms.TextBox();
            this.edt_max = new System.Windows.Forms.TextBox();
            this.lb_ntent = new System.Windows.Forms.Label();
            this.lb_max = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.edt_ntent = new System.Windows.Forms.TextBox();
            this.pnl_setup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_setup
            // 
            this.pnl_setup.Controls.Add(this.edt_min);
            this.pnl_setup.Controls.Add(this.edt_max);
            this.pnl_setup.Controls.Add(this.lb_ntent);
            this.pnl_setup.Controls.Add(this.lb_max);
            this.pnl_setup.Controls.Add(this.btn_play);
            this.pnl_setup.Controls.Add(this.lb_title);
            this.pnl_setup.Controls.Add(this.lb_min);
            this.pnl_setup.Controls.Add(this.edt_ntent);
            this.pnl_setup.Location = new System.Drawing.Point(12, 8);
            this.pnl_setup.Name = "pnl_setup";
            this.pnl_setup.Size = new System.Drawing.Size(699, 387);
            this.pnl_setup.TabIndex = 1;
            // 
            // edt_min
            // 
            this.edt_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_min.Location = new System.Drawing.Point(391, 90);
            this.edt_min.Name = "edt_min";
            this.edt_min.Size = new System.Drawing.Size(279, 27);
            this.edt_min.TabIndex = 1;
            // 
            // edt_max
            // 
            this.edt_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_max.Location = new System.Drawing.Point(391, 142);
            this.edt_max.Name = "edt_max";
            this.edt_max.Size = new System.Drawing.Size(279, 27);
            this.edt_max.TabIndex = 2;
            // 
            // lb_ntent
            // 
            this.lb_ntent.AutoSize = true;
            this.lb_ntent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ntent.Location = new System.Drawing.Point(159, 196);
            this.lb_ntent.Name = "lb_ntent";
            this.lb_ntent.Size = new System.Drawing.Size(226, 22);
            this.lb_ntent.TabIndex = 9;
            this.lb_ntent.Text = "Qual o limite de tentativas?";
            // 
            // lb_max
            // 
            this.lb_max.AutoSize = true;
            this.lb_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_max.Location = new System.Drawing.Point(48, 145);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(337, 22);
            this.lb_max.TabIndex = 8;
            this.lb_max.Text = "Qual o limite máximo do número a gerar?";
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_play.Location = new System.Drawing.Point(33, 315);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(637, 42);
            this.btn_play.TabIndex = 4;
            this.btn_play.Text = "JOGAR!";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(96, 18);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(535, 39);
            this.lb_title.TabIndex = 6;
            this.lb_title.Text = "Bem vindo ao Jogo do Adivinha!";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_min.Location = new System.Drawing.Point(53, 93);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(332, 22);
            this.lb_min.TabIndex = 3;
            this.lb_min.Text = "Qual o limite minimo do número a gerar?";
            // 
            // edt_ntent
            // 
            this.edt_ntent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_ntent.Location = new System.Drawing.Point(391, 193);
            this.edt_ntent.Name = "edt_ntent";
            this.edt_ntent.Size = new System.Drawing.Size(279, 27);
            this.edt_ntent.TabIndex = 3;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 402);
            this.Controls.Add(this.pnl_setup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem Vindo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Setup_FormClosed);
            this.pnl_setup.ResumeLayout(false);
            this.pnl_setup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_setup;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.TextBox edt_ntent;
        private System.Windows.Forms.Label lb_ntent;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.TextBox edt_min;
        private System.Windows.Forms.TextBox edt_max;

    }
}

