namespace Prototipoz._1._0
{
    partial class Login
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonLogar = new System.Windows.Forms.Button();
            this.labelIncorreta = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelinformeEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(27, 28);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(27, 63);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 1;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(97, 25);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(97, 63);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(100, 20);
            this.textBoxSenha.TabIndex = 3;
            // 
            // buttonLogar
            // 
            this.buttonLogar.Location = new System.Drawing.Point(97, 107);
            this.buttonLogar.Name = "buttonLogar";
            this.buttonLogar.Size = new System.Drawing.Size(75, 23);
            this.buttonLogar.TabIndex = 4;
            this.buttonLogar.Text = "Logar";
            this.buttonLogar.UseVisualStyleBackColor = true;
            this.buttonLogar.Click += new System.EventHandler(this.buttonLogar_Click);
            // 
            // labelIncorreta
            // 
            this.labelIncorreta.AutoSize = true;
            this.labelIncorreta.ForeColor = System.Drawing.Color.Red;
            this.labelIncorreta.Location = new System.Drawing.Point(200, 66);
            this.labelIncorreta.Name = "labelIncorreta";
            this.labelIncorreta.Size = new System.Drawing.Size(86, 13);
            this.labelIncorreta.TabIndex = 5;
            this.labelIncorreta.Text = "*Senha incorreta";
            this.labelIncorreta.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(94, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueceu sua senha ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(2, 2);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(311, 39);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "Caso você tenha esquecido sua senha,um código será enviado \r\npara o e-mail que fo" +
    "i informado no seu cadastro.Você poderá \r\nutilizar esse código para entra no sis" +
    "tema e alterar sua senha.\r\n";
            this.labelInfo.Visible = false;
            // 
            // labelinformeEmail
            // 
            this.labelinformeEmail.AutoSize = true;
            this.labelinformeEmail.Location = new System.Drawing.Point(27, 70);
            this.labelinformeEmail.Name = "labelinformeEmail";
            this.labelinformeEmail.Size = new System.Drawing.Size(95, 13);
            this.labelinformeEmail.TabIndex = 8;
            this.labelinformeEmail.Text = "Informe seu e-mail:";
            this.labelinformeEmail.Visible = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(128, 67);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 9;
            this.textBoxEmail.Visible = false;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(108, 116);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 10;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Visible = false;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonRedefinir_Click);
            // 
            // buttonvoltar
            // 
            this.buttonvoltar.Location = new System.Drawing.Point(222, 116);
            this.buttonvoltar.Name = "buttonvoltar";
            this.buttonvoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonvoltar.TabIndex = 11;
            this.buttonvoltar.Text = "Voltar";
            this.buttonvoltar.UseVisualStyleBackColor = true;
            this.buttonvoltar.Visible = false;
            this.buttonvoltar.Click += new System.EventHandler(this.buttonvoltar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 142);
            this.Controls.Add(this.buttonvoltar);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelinformeEmail);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelIncorreta);
            this.Controls.Add(this.buttonLogar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonLogar;
        private System.Windows.Forms.Label labelIncorreta;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelinformeEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonvoltar;
    }
}