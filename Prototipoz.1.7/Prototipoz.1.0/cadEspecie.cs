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
    public partial class cadEspecie : Form
    {
        public cadEspecie()
        {
            InitializeComponent();
        }

        //botão Cadastrar
        private void buttonCad_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
               // verifica os textboxes
                if ((txt.Text == "") || txt.Text == null)
                {
                    MessageBox.Show("Por favor, preencha Todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);                 
                    break;
                }
               
                //diz que o nv de segurança não pode ser 0 e obriga o usúario a defini-lo manualmente para evitar erro no cadastro
                if (nvSeguranca.Value == 0)
                {
                    MessageBox.Show("O nível de segurança da espécie está incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nvSeguranca.Focus();
                    break;
                }

                //verifica se o usuário digitou algo no campo in169
                if (richIN169.Text == "" )
                {
                    MessageBox.Show("O campo  referente à IN169 não pode ser vazio !","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    richIN169.Focus();
                    break;
                   
                }

                // passa os dados para a classe Especie
                Especie.NomeCientifico = textBoxCient.Text;
                Especie.NomePopular = textBoxPopular.Text;
                Especie.Familia = textBoxFamilia.Text;
                Especie.NvSeguranca = nvSeguranca.Value;
                Especie.IN169 = richIN169.Text;

                try
                {
                     Especie.cadastrarEspecie();
                }
                catch (Exception exp)
                {
                    
                    MessageBox.Show(exp.Message);
                }
               
                
                MessageBox.Show("Cadastrado efetuado com sucesso", "Operação Sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                break;
            }
        }
        
        
        
        
        private void buttonBold_Click(object sender, EventArgs e)
        {
            //negrito
            if (richIN169.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richIN169.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (richIN169.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                richIN169.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle);

                richIN169.Focus();

                if (richIN169.SelectionFont.Bold == true)
                {
                    buttonBold.FlatStyle = FlatStyle.Flat;
                    buttonBold.BackColor = Color.Red;
                }
                else
                {
                    buttonBold.FlatStyle = FlatStyle.Standard;
                    buttonBold.BackColor = SystemColors.Control;
                }
                if (buttonItalics.FlatStyle == FlatStyle.Flat)
                {
                    buttonItalics.FlatStyle = FlatStyle.Standard;
                    buttonItalics.BackColor = SystemColors.Control;
                }
            }
        }

        private void buttonBold_MouseEnter(object sender, EventArgs e)
        {
            labelBold.Visible = true;
        }

        private void buttonBold_MouseLeave(object sender, EventArgs e)
        {
            labelBold.Visible = false;
        }

        private void buttonItalics_Click(object sender, EventArgs e)
        {
            //itálico
            if (richIN169.SelectionFont != null)
            {

                System.Drawing.Font currentFont = richIN169.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (richIN169.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }

                richIN169.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle

                );
                richIN169.Focus();
                if (richIN169.SelectionFont.Italic == true)
                {
                    buttonItalics.FlatStyle = FlatStyle.Flat;
                    buttonItalics.BackColor = Color.Red;

                }
                else
                {
                    buttonItalics.FlatStyle = FlatStyle.Standard;
                    buttonItalics.BackColor = SystemColors.Control;
                }
                if (buttonBold.FlatStyle == FlatStyle.Flat)
                {
                    buttonBold.FlatStyle = FlatStyle.Standard;
                    buttonBold.BackColor = SystemColors.Control;
                }
            }
        }

        private void buttonItalics_MouseEnter(object sender, EventArgs e)
        {
            labelItalics.Visible = true;
        }

        private void buttonItalics_MouseLeave(object sender, EventArgs e)
        {
            labelItalics.Visible = false;
        }

        

      
   
    
    
    
    }
}
