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
    public partial class FrmCadastroFunc : Form
    {
		ClasseConexao conexao;
		DataSet ds;

        public FrmCadastroFunc()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroFunc_Load(object sender, EventArgs e)
		{ 
			Cargo.select();

			cmbSexo.Items.Add("M");
			cmbSexo.Items.Add("F");

			for (int i = 0; i < Cargo.Tabela.Rows.Count; i++)
			{
				cmbCargo.Items.Add(Cargo.Tabela.Rows[i]["NOME"].ToString());
			}
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
				int cargo = cmbCargo.SelectedIndex + 1;

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
					int c = Funcionario.insert(nome, sexo, rg, cpf, rua, numero, bairro, cep, cidade, estado, fone, cel, email, senha, cargo);
					MessageBox.Show(c.ToString());
				}
			}
			catch(Exception) { }
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			Limpar.campos(this);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			txtNome.Text = "Fatima Cardoso";
			cmbSexo.Text = "F";
			txtRG.Text = "473097415";
			txtCPF.Text = "25337075209";
			txtEmail.Text = "fatimaC@gmail.com";
			txtSenha.Text = "12345";
			cmbCargo.SelectedIndex = 0;
			txtRua.Text = "Marcos Silva";
			txtNum.Text = "321";
			txtBairro.Text = "Centro";
			txtCEP.Text = "04146001";
			txtCidade.Text = "Sao Paulo";
			txtEstado.Text = "Sao Paulo";
			txtFone.Text = "01184121357";
			txtCel.Text = "011964236785";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if(Application.OpenForms.OfType<FrmCargo>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmCargo frmCargo = new FrmCargo();
				frmCargo.Show();
				frmCargo.MdiParent = this.MdiParent;
			}
		}
	}
}
