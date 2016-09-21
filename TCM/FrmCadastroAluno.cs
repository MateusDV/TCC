using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
	public partial class FrmCadastroAluno : Form
	{
		ClasseConexao conexao;
		DataSet ds;

		public FrmCadastroAluno()
		{
			InitializeComponent();
		}

		private void FrmCadastroAluno_Load(object sender, EventArgs e)
		{
			cmbSexo.Items.Add("M");
			cmbSexo.Items.Add("F");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();

            try
            {
                //Variáveis referentes aos controles do formulario
                String nome = txtNome.Text;
                String email = txtEmail.Text;
                String sexo = cmbSexo.SelectedItem.ToString();
                String senha = txtSenha.Text;
                String rua = txtRua.Text;
                int numero = int.Parse(txtNum.Text);
                String cep = txtCEP.Text;
                String cidade = txtCidade.Text;
                String estado = txtEstado.Text;
                String telefone = txtTelefone.Text;
                int curso;
                int periodo;

				//checa qual radio button está selecionado
				curso = Checar.radioTag(grbCurso);
				periodo = Checar.radioTag(grbPeriodo);
					
				//checa se os textbox, maskedtextbox estao vazios

				if (Checar.textbox(this) || curso == 0 || periodo == 0)
				{
					MessageBox.Show("Por favor preencha todos os campos e selecione as opções apropriadas");
				}
				else
				{
					int id = Aluno.insert(nome, email, sexo, senha, rua, numero, cep, cidade, estado, telefone);
					int per = Periodo_Aluno.insert(id, periodo);
					int cur = Curso_Aluno.insert(id, curso);

					MessageBox.Show(per +" "+ cur);
				}
            }
            catch(Exception) { }
        }

		private void button2_Click(object sender, EventArgs e)
		{
			Limpar.campos(this);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			txtNome.Text = "Joao Carlos Magalhaes";
			cmbSexo.Text = "M";
			txtEmail.Text = "joaoCM@gmail.com";
			txtSenha.Text = "12345";
			txtRua.Text = "Marcos Silva";
			txtNum.Text = "321";
			txtCEP.Text = "04146001";
			txtCidade.Text = "Sao Paulo";
			txtEstado.Text = "Sao Paulo";
			txtTelefone.Text = "01184121357";
			rdbBasico.Checked = true;
			rdbT.Checked = true;
		}
	}
}