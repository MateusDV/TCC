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
	public partial class FrmEditarFunc : Form
	{
		private int funcID;
		public FrmEditarFunc(int ID)
		{
			InitializeComponent();
			funcID = ID;
		}

		private void FrmEditarFunc_Load(object sender, EventArgs e)
		{
			Cargo.select();
			Funcionario.select(funcID.ToString());

			cmbSexo.Items.Add("M");
			cmbSexo.Items.Add("F");

			for(int i = 0; i < Cargo.Tabela.Rows.Count; i++)
			{
				cmbCargo.Items.Add(Cargo.Tabela.Rows[i]["NOME"].ToString());
			}

			txtNome.Text = Funcionario.Nome;
			cmbSexo.Text = Funcionario.Sexo;
			txtRG.Text = Funcionario.RG;
			txtCPF.Text = Funcionario.CPF;
			txtEmail.Text = Funcionario.Email;
			cmbCargo.SelectedIndex = (int.Parse(Funcionario.Cargo)) - 1;
			txtRua.Text = Funcionario.Rua;
			txtNum.Text = Funcionario.Num.ToString();
			txtBairro.Text = Funcionario.Bairro;
			txtCEP.Text = Funcionario.Cep;
			txtCidade.Text = Funcionario.Cidade;
			txtEstado.Text = Funcionario.Estado;              
			txtFone.Text = Funcionario.Telefone;
			txtCel.Text = Funcionario.Celular;
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
				String senha = Funcionario.Senha;
				int cargo = cmbCargo.SelectedIndex + 1;

				bool Valido = Validar.Cpf(cpf);

				//checa se os textbox, maskedtextbox estao vazios


				if(Checar.textbox(this) || Valido == false)
				{
					if(Valido == false)
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
					int c = Funcionario.update(Funcionario.ID_Funcionario, nome, sexo, rg, cpf, rua, numero, bairro, cep, cidade, estado, fone, cel, email, senha, cargo);
					MessageBox.Show(c.ToString());
				}
			}
			catch(Exception) { }
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int c = Funcionario.delete(Funcionario.ID_Funcionario.ToString());
			MessageBox.Show(c.ToString());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Funcionario.Tabela = new DataTable();
			FrmConsultaFunc frm = new FrmConsultaFunc();
			frm.MdiParent = this.MdiParent;
			frm.Show();
			this.Hide();
			this.Dispose();
		}
	}
}
