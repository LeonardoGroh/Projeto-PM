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
using Prototipoz._1._0.DB;
using System.IO;




namespace Prototipoz._1._0
{
    public partial class cadAnimal : Form
    {
        public cadAnimal()
        {
            InitializeComponent();

        }
       //variaveis de auxilio
        bool imagemTrocada = false;
        string consultaSQL;
        ComboBox combobox;
       //botão para importar imagem
        private void procurarImagem_Click(object sender, EventArgs e)
        {
            imagem();
          
        }

        //método para abrir imagem
        private void imagem()
        {
            //Variavel para salvar caminho da imagem
            string caminhoImagem= null;

            this.Cursor = Cursors.WaitCursor;
            openFileDialog1.ShowDialog();

            if (imagemTrocada == true)
            {
                openFileDialog1.OpenFile();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            
                caminhoImagem = openFileDialog1.FileName;

            }
            this.Cursor = Cursors.Default;
            //Salvar a imagem
            FileStream flStream = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(flStream);
            Animal.Foto = br.ReadBytes((int)flStream.Length);
        }
        // valida os campos e insere no banco
        private void buttonCad_Click(object sender, EventArgs e)
        {
            if (textBoxNecesi.Text == "")
            {
                textBoxNecesi.Text = "nenhuma";
            }
            // verifica se o usuário cadastrou todas as caixas de texto necessárias
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                if ((txt.Text == "") || txt.Text == null)
                {
                    MessageBox.Show("Por favor, preencha Todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                //verifica se o usuário inseriu somente números no campo textBoxNumero
                try
                {
                    int.Parse(textBoxNumero.Text);
                }
                catch
                {

                    MessageBox.Show("O número do registro parece estar incorreto !", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNumero.Focus();
                    break;
                }
                // verifica se o usuario inseriu somente numeros no campo textboxMarcacao
                try
                {
                    int.Parse(textBoxMarcacao.Text);
                }
                catch
                {

                    MessageBox.Show("O número da marcação parece estar incorreto !", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNumero.Focus();
                    break;
                }

                // verifica as comboboxes
                if ((comboBoxCienti.Text == "")|| (comboBoxPopular.Text == "") )
                {
                    MessageBox.Show("Por favor, preencha Todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break; 
                }
                // verifica  se o usuário definiu o sexo do animal
                if ((radioButtonF.Checked == false) & (radioButtonM.Checked == false))
                {
                    MessageBox.Show("Por favor, defina  o sexo do animal!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);                   
                    break;
                }
                // verifica a data de entrada
                if ((comboBoxDia.Text == "") || (comboBoxMes.Text == ""))
                {
                    MessageBox.Show("Defina corretamente o Dia e o Mês da data de entrada do animal!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxDia.Focus();
                    break;
                }
                if ((ano.Value < 1800) || (ano.Value > System.DateTime.Now.Year))
                {
                    MessageBox.Show("O ano da data de entrada do animal está incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ano.Focus();
                    break;
                }

               

                //verifica se o usuario definiu o recinto do animal
                if (comboBoxRecinto.Text == "")
                {
                    MessageBox.Show("Por favor, defina o recinto em que o animal se encontra!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxRecinto.Focus();
                    break;
                }
                if (nvSeguranca.Value <= 0)
                {
                    MessageBox.Show("O nível de segurança está incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }

                //verifica se o usuário cadastrou uma imagem
                if (imagemTrocada == false)
                {
                    if (MessageBox.Show("Você  gostaria de adicionar uma imagem ?", "Sem imagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        imagem();
                    }
                   
                }
               
                this.Cursor = Cursors.WaitCursor;
               
                //Passa os dados para a classe ANIMAL
                Animal.Marcacao = textBoxMarcacao.Text;
                Animal.NumeroZoo = int.Parse(textBoxNumero.Text);
                Animal.NomeZoo = textBoxApelido.Text;
               
                Animal.Origem = textBoxOrigem.Text;
                if (radioButtonF.Checked)
                {
                    Animal.Sexo = "F";
                }                        
                if (radioButtonM.Checked)
                 {
                     Animal.Sexo = "M"; 
                  }
                if (radioButtonN.Checked)
                {
                    Animal.Sexo = "Null";
                }
                    
               
                

                
                Animal.Dia = comboBoxDia.Text;
                Animal.Mes = (comboBoxMes.SelectedIndex + 1).ToString(); ;
                Animal.Ano = ano.Value.ToString();
                Animal.Necessidades = textBoxNecesi.Text;
                Animal.Recinto = int.Parse(comboBoxRecinto.Text);               
                Animal.IDEspecie = int.Parse(Banco.RecuperarDado("select idEspecie from especie where nomecien = '" + comboBoxCienti.Text + "';").ToString());
                
                //inserção no banco
                try
                {
                    Animal.cadastrarAnimal();
                }
                catch (Exception x)
                {
                    if (x.Message == "Incorrect date value: '"+Animal.Ano + "-" + Animal.Mes + "-" + Animal.Dia +"' for column 'entrada' at row 1")
                    {
                        MessageBox.Show("Dia do mês inválido !", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Cursor = Cursors.Arrow;
                        comboBoxDia.Focus();
                        break;
                    }
                    MessageBox.Show(x.Message);
                    
                   
                    this.Cursor = Cursors.Arrow;
                    break;
                }

                MessageBox.Show("Cadastrado efetuado com sucesso","Operação Sucedida",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
                break;
            }
            
        }

        private void textBoxNecesi_Validated(object sender, EventArgs e)
        {
            textBoxNecesi.Clear();
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imagemTrocada = true;
        }

        private void cadAnimal_Load_1(object sender, EventArgs e)
        {
            ano.Maximum = int.Parse(System.DateTime.Now.Year.ToString());
            ano.Value = int.Parse(System.DateTime.Now.Year.ToString());
        }
        
       
        private void cadAnimal_Load(object sender, EventArgs e)
        {
            ano.Value = int.Parse(System.DateTime.Now.Year.ToString());
            ano.Maximum = int.Parse(System.DateTime.Now.Year.ToString());

            //prenche combobox nome cientifico
            consultaSQL = "select nomecien from especie;";
            combobox = comboBoxCienti;
            PreencheComboBox();
           
            //preenche combobox nomepopular
            consultaSQL = "select nomepop from especie;";
            combobox = comboBoxPopular;
            PreencheComboBox();
            
            // preenche combobox recinto
            consultaSQL = "select idRecinto from recinto where Ativo = 1;";
            combobox = comboBoxRecinto;
            PreencheComboBox();
          
           
               
            
           
        }

        private void PreencheComboBox()
        {
            try
            {               
                DataSet ds = Banco.RecuperarRegistro(consultaSQL);
                
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    combobox.Items.Add(row.ItemArray[0].ToString());
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void comboBoxCienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prenche combobox nome popular
            consultaSQL = "select nomepop from especie where nomecien ='" + comboBoxCienti.Text + "';";
            combobox = comboBoxPopular;
            comboBoxPopular.Items.Clear();
            PreencheComboBox();
            comboBoxPopular.Text = comboBoxPopular.Items[0].ToString();

            preenchein169();
            
           
        }

        

        private void preenchein169()
        {
            DataSet ds = Banco.RecuperarRegistro("select IN169 from especie where nomecien ='" + comboBoxCienti.Text + "';");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                richIN169.Text = row.ItemArray[0].ToString();

            }
            
        }

        

        
    }
}
