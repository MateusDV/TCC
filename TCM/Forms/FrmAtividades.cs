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
	public partial class FrmAtividades : Form
	{
		ClasseConexao conexao;
		DataSet ds;

		Compartilha comp = new Compartilha();

		private String[] ativ = { "ID_ATIV", "NOME", "DESCRICAO", "ID_PROFESSOR" };

		private string id_prova;
		private string id_prof;

		public FrmAtividades()
		{
			InitializeComponent();
		}

		private void FrmAtividades_Load(object sender, EventArgs e)
		{
			String cargo = comp.Cargo;

			String id = "";
			id_prof = "";

			cmbCampo.Items.AddRange(ativ);

			lblCar.Text = "100";
			label7.Text = "100";

			if(cargo.Equals("PROFESSOR"))
			{
				id_prof = id = comp.Id;
			}
			else
			{
				grbCriar.Visible = Cargo.ATIV_CRIAR;
				grbMod.Visible = Cargo.ATIV_EDIT;
			}

			//Prova.select(int.Parse(id));
			//Grid.atualizarGrid(Prova.Tabela, dgvAtiv);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			String nivel = comp.Cargo;
			String id = comp.Id;

			if(cmbCampo.SelectedItem.Equals("ID_PROFESSOR") && nivel.Equals("PROFESSOR"))
			{
				txtValor.Text = id;
				txtValor.Enabled = false;
			}
			else
			{
				txtValor.Enabled = true;
			}
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();

			String campo = cmbCampo.SelectedItem.ToString();
			String valor = txtValor.Text;

			Prova.select(campo, valor);
			Grid.atualizarGrid(Prova.Tabela, dgvAtiv);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String nome = txtNome.Text;
			String desc = txtDesc.Text;
			String id = comp.Id;

			if(Checar.textbox(this) || desc.Trim().Length > 100)
			{
				MessageBox.Show("Por favor preencha o nome e a descrição, e tenha certeza que a descrição tenha menos de 100 caracteres");
			}
			else
			{
				int c = Prova.insert(nome, desc, id);
				Prova.select(int.Parse(id));
				Grid.atualizarGrid(Prova.Tabela, dgvAtiv);
				MessageBox.Show(c + "");
			}
		}

		private void dgvAtiv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id_prova = txtID.Text = dgvAtiv.Rows[e.RowIndex].Cells[0].Value.ToString();

			Prova.select(id_prova);

			textBox2.Text = Prova.Nome;
			textBox1.Text = Prova.Descricao;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				if(txtID.Text.Equals("") || txtID.Text.Equals(null))
				{
					MessageBox.Show("Por favor digite um ID para continuar");
				}
				else
				{
					var confirm = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
					if(confirm.Equals(DialogResult.Yes))
					{
						int c = Prova.delete(id_prova);
						Prova.select(int.Parse(id_prof));
						Grid.atualizarGrid(Prova.Tabela, dgvAtiv);
						MessageBox.Show(c + "");
					}
				}
			}
			catch(Exception) { }
		}

		private void btnMod_Click(object sender, EventArgs e)
		{
			String ID = txtID.Text;
			String nome = textBox2.Text;
			string descricao = textBox1.Text;

			if(Checar.textbox(this))
			{
				MessageBox.Show("Por favor tenha certeza de que todos os campos estão preenchidos.");
			}
			else
			{
				var confirm = MessageBox.Show("Tem certeza que deseja alterar o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
				if(confirm.Equals(DialogResult.Yes))
				{
					int c = Prova.update(id_prova, nome, descricao);
					Prova.select(int.Parse(id_prof));
					Grid.atualizarGrid(Prova.Tabela, dgvAtiv);
					MessageBox.Show(c + "");
				}
			}
		}


		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtDesc_TextChanged(object sender, EventArgs e)
		{
			lblCar.Text = (100 - txtDesc.Text.Length).ToString();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			label7.Text = (100 - textBox1.Text.Length).ToString();
		}
	}
}
