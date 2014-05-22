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

namespace Prototipoz._1._0
{
    public partial class Menu : Form
    {       
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    Banco.LerDado("show tables;");
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Não foi possivel se conectar ao banco de dados,verifique sua conexão com a internet!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    Close();
            //}
            Login lg = new Login();
            lg.ShowDialog();          
            this.WindowState = FormWindowState.Maximized;
        }

        private void cadastrarAnimalMenuF_Click(object sender, EventArgs e)
        {
            cadastrarAnimal();
        }

        private void cadastrarAnimal()
        {
            this.Cursor = Cursors.WaitCursor;
            int aux = 0;
            while (aux == 0)
            {
                try
                {
                    object especie = Banco.LerDado("select * from especie;");
                    object recinto = Banco.LerDado("select * from recinto;");

                    if (especie.ToString() == "False")
                    {
                        MessageBox.Show("Antes de cadastrar um animal, é necessário haver pelo menos uma espécie cadastrada.", "Atenção, não há nenhuma espécie cadastrada!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else
                    {
                        if (recinto.ToString() == "False")
                        {
                            MessageBox.Show("Antes de cadastrar um animal, é necessário haver pelo menos um recinto cadastrado.", "Atenção, não há nenhum recinto cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            cadAnimal ca = new cadAnimal();
                            ca.ShowDialog();
                            aux = 1;
                        }
                    }

                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    break;
                }
            }

            this.Cursor = Cursors.Arrow;
        }

        private void CadastrarAnimalMenuV_Click(object sender, EventArgs e)
        {
            cadastrarAnimal();
        }

        private void cadastrarAnimalMenuA_Click(object sender, EventArgs e)
        {
            cadastrarAnimal();
            
        }

        private void cadastrarRecintoMenu_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
             cadRecinto cr = new cadRecinto();
            cr.ShowDialog();
            this.Cursor = Cursors.Arrow;
        }

        private void cadastrarFuncionarioMenu_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            cadFunc cf = new cadFunc();
            cf.ShowDialog();
            this.Cursor = Cursors.Arrow;
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair da conta ?", "Trocar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            } 
            
        }

        private void cadastrarEspécieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            cadEspecie ce = new cadEspecie();
            ce.ShowDialog();
            this.Cursor = Cursors.Arrow;
        }

        private void cadastrarEspécieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            cadEspecie ce = new cadEspecie();
            ce.ShowDialog();
            this.Cursor = Cursors.Arrow;
        }

      

       

       
            

        

       
    }
}
