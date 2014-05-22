using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototipoz._1._0.DB;
using Prototipoz._1._0.model;
using System.Net.Mail;

namespace Prototipoz._1._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void buttonRedefinir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                // verifica se existe uma conta com este email cadastrado
                object verificaEMail = Banco.LerDado("select email from usuario where email ='" + textBoxEmail.Text + "';");
                if (verificaEMail.ToString() == "False")
                {
                    MessageBox.Show("Não há nenhuma conta com este e-mail cadastrado ! \r Por Favor informe o e-mail referente à sua conta.", "E-mail incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Arrow;
                }
                else
                {
                    
                    string email = textBoxEmail.Text;
                    object nome = Banco.RecuperarDado("select nome from usuario where email ='" + email + "';");
                    object senha = Banco.RecuperarDado("select senha from usuario where email ='" + email + "';");

                    EMail.enviarEmail(email, nome.ToString(), senha.ToString());
                    MessageBox.Show("Um código foi enviado para o seu e-mail com sucesso ! \r Verifique a pasta lixo", "E-mail enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            this.Cursor = Cursors.Arrow;
            
            
        }

        private void buttonvoltar_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
            labelLogin.Visible = true;
            labelSenha.Visible = true;
            buttonLogar.Visible = true;
            linkLabel1.Visible = true;          
            textBoxLogin.Visible = true;
            textBoxSenha.Visible = true;

            labelInfo.Visible = false;
            labelinformeEmail.Visible = false;
            textBoxEmail.Visible = false;
            buttonEnviar.Visible = false;
            buttonvoltar.Visible = false;
            this.Text = "Login";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelLogin.Visible = false;
            labelSenha.Visible = false;
            buttonLogar.Visible = false;
            linkLabel1.Visible = false;
            labelIncorreta.Visible = false;
            textBoxLogin.Visible = false;
            textBoxSenha.Visible = false;

            labelInfo.Visible = true;
            labelinformeEmail.Visible = true;
            textBoxEmail.Visible = true;
            buttonEnviar.Visible = true;
            buttonvoltar.Visible = true;
            this.Text = "Recuperar Senha";
        }
    }
}
