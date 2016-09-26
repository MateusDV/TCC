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
	public partial class FrmEditarAluno : Form
	{
		private int AlunoID;

		public FrmEditarAluno(int val)
		{
			InitializeComponent();
			this.AlunoID = val;
		}

		private void FrmEditarAluno_Load(object sender, EventArgs e)
		{
			Aluno.select(AlunoID.ToString());
			Curso_Aluno.select(AlunoID.ToString());
			Periodo_Aluno.select(AlunoID.ToString());

			cmbSexo.Items.Add("M");
			cmbSexo.Items.Add("F");

			txtNome.Text = Aluno.Nome;
			cmbSexo.Text = Aluno.Sexo;
			txtEmail.Text = Aluno.Email;
			txtRua.Text = Aluno.Rua;
			txtNum.Text = Aluno.Num.ToString();
			txtCEP.Text = Aluno.Cep;
			txtCidade.Text = Aluno.Cidade;
			txtEstado.Text = Aluno.Estado;
			txtTelefone.Text = Aluno.Telefone;

			foreach(RadioButton r in grbCurso.Controls)
			{
				if (r.Tag.ToString().Equals(Curso_Aluno.ID_Curso.ToString()))
				{
					r.Checked = true;
				}
			}

			foreach(RadioButton r in grbPeriodo.Controls)
			{
				if (r.Tag.ToString().Equals(Periodo_Aluno.ID_Periodo.ToString()))
				{
					r.Checked = true;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				//Variáveis referentes aos controles do formulario
				String nome = txtNome.Text;
				String email = txtEmail.Text;
				String sexo = cmbSexo.SelectedItem.ToString();
				String senha = Aluno.Senha;
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

				if(Checar.textbox(this) || curso == 0 || curso == 0)
				{
					MessageBox.Show("Por favor preencha todos os campos e selecione as opções apropriadas");
				}
				else
				{
					int al = Aluno.update(AlunoID.ToString(), nome, email, sexo, senha, rua, numero, cep, cidade, estado, telefone);
					int cr = Curso_Aluno.update(curso, AlunoID);
					MessageBox.Show(al + cr +"");

					this.button3.Text = "Sair";
				}
			}
			catch(Exception) { }
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FrmConsultaAluno frm = new FrmConsultaAluno();
			frm.MdiParent = this.MdiParent;
			frm.Show();
			this.Hide();
			this.Dispose();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				int c = Aluno.delete(AlunoID);
				MessageBox.Show(c+"");
			}
			catch (Exception) { }
		}
	}
}
