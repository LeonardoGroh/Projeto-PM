using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototipoz._1._0.model;

namespace Prototipoz._1._0
{
    public partial class cadFunc : Form
    {
        public cadFunc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool teste = true;
            //verifica campos do groupbox1(informações do funcionário)           
            foreach (TextBox txt in groupBox1.Controls.OfType<TextBox>())
            {
                if ((txt.Text == "") || txt.Text == null)
                {
                    MessageBox.Show("Por favor, preencha Todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    teste = false;
                    break;
                }
                if (maskedCpf.Text == "")
                {
                    MessageBox.Show("Por favor, preencha Todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    teste = false;
                    break;            
                }
                
            }
           
            //verifica campos do groupbox2(informações de login)        
            if (teste == true)
            {


                foreach (TextBox txt in groupBox2.Controls.OfType<TextBox>())
                {
                    if ((txt.Text == "") || txt.Text == null)
                    {
                        MessageBox.Show("Por favor, preencha Todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (txtEmail.Text != repetEmail.Text)
                    {
                        MessageBox.Show("Os E-mails não conferem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        repetEmail.Focus();
                        break;
                    }
                    if (txtSenha.Text != repetSenha.Text)
                    {
                        MessageBox.Show("As Senhas não conferem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        repetSenha.Focus();
                        break;
                    
                    }
                    this.Cursor = Cursors.WaitCursor;
                    Usuario.Nome = txtNome.Text;
                    Usuario.Cpf = maskedCpf.Text;                  

                    if (radioButtonA.Checked)
                    {
                        Usuario.Tipo = 'A';
                    }
                    else
                    {
                        Usuario.Tipo = 'T';
                    }
                    Usuario.Login = txtLogin.Text;
                    Usuario.Email = txtEmail.Text;
                    Usuario.Senha = txtSenha.Text;

                    try
                    {
                        Usuario.cadastrarUsuario();
                        MessageBox.Show("Cadastrado efetuado com sucesso", "Operação Sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        break;
                    }
                    
                    
                    
                    break;
                }

            }


            this.Cursor = Cursors.Arrow;   
        }
    }
}
