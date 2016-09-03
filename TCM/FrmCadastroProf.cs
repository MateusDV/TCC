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
	public partial class FrmCadastroProf : Form
	{
		ClasseConexao conexao;
		DataSet ds;

		public FrmCadastroProf()
		{
			InitializeComponent();
		}

        private void FrmCadastroProf_Load(object sender, EventArgs e)
        {
			cmbSexo.Items.Add("M");
			cmbSexo.Items.Add("F");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			txtNome.Text = "Rafael Lima";
			cmbSexo.Text = "M";
			txtRG.Text = "439834608";
			txtCPF.Text = "05380505783";
			txtEmail.Text = "rafaelL@gmail.com";
			txtSenha.Text = "12345";
			txtRua.Text = "Jose Carlos";
			txtNum.Text = "576";
			txtBairro.Text = "Vila Nova";
			txtCEP.Text = "09862537";
			txtCidade.Text = "Sao Paulo";
			txtEstado.Text = "Sao Paulo";
			txtFone.Text = "01183582538";
			txtCel.Text = "011982546587";
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();

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
				String senha = txtSenha.Text;

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
					int c = Professor.insert(nome, sexo, rg, cpf, rua, numero, bairro, cep, cidade, estado, fone, cel, email, senha);
					MessageBox.Show(c.ToString());
					
				}
			}
			catch(Exception) { }
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			Limpar.campos(this);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
