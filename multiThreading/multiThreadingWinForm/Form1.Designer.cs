namespace multiThreadingWinForm {
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
            this.thread1 = new System.ComponentModel.BackgroundWorker();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_free = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thread1
            // 
            this.thread1.WorkerReportsProgress = true;
            this.thread1.WorkerSupportsCancellation = true;
            this.thread1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.thread1_DoWork);
            this.thread1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.thread1_ProgressChanged);
            this.thread1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.thread1_RunWorkerCompleted);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 226);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(260, 23);
            this.pb.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(105, 121);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_free
            // 
            this.btn_free.Location = new System.Drawing.Point(197, 121);
            this.btn_free.Name = "btn_free";
            this.btn_free.Size = new System.Drawing.Size(75, 23);
            this.btn_free.TabIndex = 2;
            this.btn_free.Text = "Estou Livre";
            this.btn_free.UseVisualStyleBackColor = true;
            this.btn_free.Click += new System.EventHandler(this.btn_free_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 121);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Iniciar";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(12, 23);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(34, 13);
            this.lb.TabIndex = 4;
            this.lb.Text = "Teste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_free);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker thread1;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_free;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb;
    }
}

