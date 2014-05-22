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
    public partial class cadRecinto : Form
    {
        public cadRecinto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCad_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int aux = 0;
            while (aux < 2)
            {
                try
                {
                    int.Parse(textBoxNumRecinto.Text);
                    aux = aux + 1;

                }
                catch (Exception)
                {

                    MessageBox.Show("Número do recinto incorreto !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                if (nvSeguranca.Value <= 0)
                {
                    MessageBox.Show("O nível de segurança está incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else
                {
                    aux = aux + 1;
               
                }

                //classe

                Recinto.IDRecinto = int.Parse(textBoxNumRecinto.Text);
                Recinto.NvSeguranca = nvSeguranca.Value;




                try
                {
                    Recinto.cadastrarRecinto();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNumRecinto.Clear();
                    nvSeguranca.Value = 0;
                    pictureBox1.Image = Prototipoz._1._0.Properties.Resources._image;
                            
                }
                catch (Exception erro)
                {
                    if (erro.Message == "Duplicate entry '"+textBoxNumRecinto.Text+"' for key 'PRIMARY'")
                    {
                        MessageBox.Show("Esse recinto ja foi cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        MessageBox.Show(erro.Message);
                        break;
                    }
                   
                }
                


            }
            this.Cursor = Cursors.Arrow;
        }
    }
}
