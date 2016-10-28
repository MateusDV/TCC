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
	public partial class FrmEditarProf : Form
	{
		private int profID;


		public FrmEditarProf(int id)
		{
			InitializeComponent();
			this.profID = id;
		}

		private void FrmEditarProf_Load(object sender, EventArgs e)
		{
			Professor.select(profID.ToString());

			cmbSexo.Items.Add("M");
			cmbSexo.Items.Add("F");

			txtNome.Text = Professor.Nome;
			cmbSexo.Text = Professor.Sexo;
			txtRG.Text = Professor.RG;
			txtCPF.Text = Professor.CPF;
			txtEmail.Text = Professor.Email;
			txtRua.Text = Professor.Rua;
			txtNum.Text = Professor.Num.ToString();
			txtBairro.Text = Professor.Bairro;
			txtCEP.Text = Professor.Cep;
			txtCidade.Text = Professor.Cidade;
			txtEstado.Text = Professor.Estado;
			txtFone.Text = Professor.Telefone;
			txtCel.Text = Professor.Celular;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				String nome = txtNome.Text;
				String sexo = cmbSexo.SelectedItem.ToString();
				String rg = txtRG.Text;
				String cpf = txtCPF.Text;
				String rua = txtRua.Text;
				int numero = int.Parse(txtNum.Text);
				String bairro = txtBairro.Text;
				String cep = txtCEP.Text;
				String cidade = txtCidade.Text;
				String estado = txtEstado.Text;
				String fone = txtFone.Text;
				String cel = txtCel.Text;
				String email = txtEmail.Text;
				String senha = Professor.Senha;

				bool Valido = Validar.Cpf(cpf);

				//checa se os textbox, maskedtextbox estao vazios


				if (Checar.textbox(this) || Valido == false)
				{
					if (Valido == false)
					{
						MessageBox.Show("Por favor digite um CPF válido");
					}
					else
					{
						MessageBox.Show("Por favor preencha todos os campos e selecione as opções apropriadas");
					}
				}
				else
				{
					int c = Professor.update(Professor.ID_Professor, nome, sexo, rg, cpf, rua, numero, bairro, cep, cidade, estado, fone, cel, email, senha);
					MessageBox.Show(c.ToString());
				}
			}
			catch (Exception) { }
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int c = Professor.delete(Professor.ID_Professor.ToString());
			MessageBox.Show(c.ToString());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Professor.Tabela = new DataTable();
			FrmConsultaProf frm = new FrmConsultaProf();
			frm.MdiParent = this.MdiParent;
			frm.Show();
			this.Hide();
			this.Dispose();
		}
	}
}
