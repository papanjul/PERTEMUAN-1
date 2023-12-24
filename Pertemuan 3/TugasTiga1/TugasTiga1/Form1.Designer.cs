namespace TugasTiga1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.lblNim = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.lblTampilNim = new System.Windows.Forms.Label();
            this.lblTampilNama = new System.Windows.Forms.Label();
            this.lblTampilKelas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(48, 152);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 0;
            this.btnTampil.Text = "Tampilkan";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.Location = new System.Drawing.Point(158, 152);
            this.btnKosongkan.Name = "btnKosongkan";
            this.btnKosongkan.Size = new System.Drawing.Size(75, 23);
            this.btnKosongkan.TabIndex = 0;
            this.btnKosongkan.Text = "Kosongkan";
            this.btnKosongkan.UseVisualStyleBackColor = true;
            this.btnKosongkan.Click += new System.EventHandler(this.btnKosongkan_Click);
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(29, 30);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(51, 13);
            this.lblNim.TabIndex = 1;
            this.lblNim.Text = "NIM       :";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(29, 61);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(50, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama    :";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(29, 91);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(51, 13);
            this.lblKelas.TabIndex = 1;
            this.lblKelas.Text = "Kelas     :";
            // 
            // lblTampilNim
            // 
            this.lblTampilNim.AutoSize = true;
            this.lblTampilNim.Location = new System.Drawing.Point(88, 30);
            this.lblTampilNim.Name = "lblTampilNim";
            this.lblTampilNim.Size = new System.Drawing.Size(10, 13);
            this.lblTampilNim.TabIndex = 1;
            this.lblTampilNim.Text = " ";
            // 
            // lblTampilNama
            // 
            this.lblTampilNama.AutoSize = true;
            this.lblTampilNama.Location = new System.Drawing.Point(88, 61);
            this.lblTampilNama.Name = "lblTampilNama";
            this.lblTampilNama.Size = new System.Drawing.Size(10, 13);
            this.lblTampilNama.TabIndex = 1;
            this.lblTampilNama.Text = " ";
            // 
            // lblTampilKelas
            // 
            this.lblTampilKelas.AutoSize = true;
            this.lblTampilKelas.Location = new System.Drawing.Point(88, 91);
            this.lblTampilKelas.Name = "lblTampilKelas";
            this.lblTampilKelas.Size = new System.Drawing.Size(10, 13);
            this.lblTampilKelas.TabIndex = 1;
            this.lblTampilKelas.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 209);
            this.Controls.Add(this.lblTampilKelas);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblTampilNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblTampilNim);
            this.Controls.Add(this.lblNim);
            this.Controls.Add(this.btnKosongkan);
            this.Controls.Add(this.btnTampil);
            this.Name = "Form1";
            this.Text = "Tugas 3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnKosongkan;
        private System.Windows.Forms.Label lblNim;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblTampilNim;
        private System.Windows.Forms.Label lblTampilNama;
        private System.Windows.Forms.Label lblTampilKelas;
    }
}

