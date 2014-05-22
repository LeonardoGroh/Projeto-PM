namespace Prototipoz._1._0
{
    partial class cadRecinto
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nvSeguranca = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonCad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumRecinto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvSeguranca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número do Recinto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Prototipoz._1._0.Properties.Resources._image;
            this.pictureBox1.Location = new System.Drawing.Point(122, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nvSeguranca
            // 
            this.nvSeguranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nvSeguranca.Location = new System.Drawing.Point(172, 50);
            this.nvSeguranca.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nvSeguranca.Name = "nvSeguranca";
            this.nvSeguranca.Size = new System.Drawing.Size(28, 23);
            this.nvSeguranca.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(9, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Nível de Segurança:";
            // 
            // buttonCad
            // 
            this.buttonCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonCad.Location = new System.Drawing.Point(153, 248);
            this.buttonCad.Name = "buttonCad";
            this.buttonCad.Size = new System.Drawing.Size(88, 31);
            this.buttonCad.TabIndex = 30;
            this.buttonCad.Text = "Cadastrar ";
            this.buttonCad.UseVisualStyleBackColor = true;
            this.buttonCad.Click += new System.EventHandler(this.buttonCad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Planta:";
            // 
            // textBoxNumRecinto
            // 
            this.textBoxNumRecinto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxNumRecinto.Location = new System.Drawing.Point(172, 15);
            this.textBoxNumRecinto.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumRecinto.Name = "textBoxNumRecinto";
            this.textBoxNumRecinto.Size = new System.Drawing.Size(28, 23);
            this.textBoxNumRecinto.TabIndex = 1;
            // 
            // cadRecinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(382, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCad);
            this.Controls.Add(this.nvSeguranca);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNumRecinto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "cadRecinto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Recinto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvSeguranca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nvSeguranca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumRecinto;
    }
}