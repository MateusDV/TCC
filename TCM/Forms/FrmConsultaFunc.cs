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
	public partial class FrmConsultaFunc : Form
	{
		private String[] Fun = { "NOME", "SEXO", "RG", "CPF", "CARGO", "RUA", "NUM", "BAIRRO", "CEP", "CIDADE", "ESTADO", "TELEFONE", "CELULAR", "EMAIL" };

		private int idFuncionario;

		public FrmConsultaFunc()
		{
			InitializeComponent();
		}

		private void FrmConsultaFunc_Load(object sender, EventArgs e)
		{
			cmbCampo.Items.AddRange(Fun);

			btnAlterar.Visible = Cargo.FUNC_EDIT;
		}

		private void btnExibir_Click(object sender, EventArgs e)
		{
			Funcionario.select(Checar.radioTag(grbExibir), checkBox1.Checked ? 0 : 1);
			Grid.atualizarGrid(Funcionario.Tabela, dgvFunc);
			//String query;
			//if(rdbPessoais.Checked == true)
			//{
			//	query = "SELECT ID_FUNCIONARIO AS ID, NOME, SEXO, RG, CPF, CARGO FROM FUNCIONARIO";
			//}
			//else if(rdbContato.Checked == true)
			//{
			//	query = "SELECT ID_FUNCIONARIO AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM FUNCIONARIO";
			//}
			//else if(rdbEnd.Checked == true)
			//{
			//	query = "SELECT ID_FUNCIONARIO AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM FUNCIONARIO";
			//}
			//else
			//{
			//	query = "";
			//	MessageBox.Show("Por favor selecione um modo de exibição.");
			//}
			//atualizar_grid(query);
		}

		private void btnPesquisa_Click(object sender, EventArgs e)
		{
			try
			{
				String campo = cmbCampo.SelectedItem.ToString();
				String valor = txtPesquisa.Text;
				int tipo = Checar.radioTag(grbExibir);

				Funcionario.select(tipo, checkBox1.Checked ? 0 : 1, campo, valor);
				Grid.atualizarGrid(Funcionario.Tabela, dgvFunc);
			}
			catch(Exception) { }
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	String ID = txtID.Text;
			//	String campo = cmbAltCampo.SelectedItem.ToString();
			//	String valor = txtAlt.Text;
			//	String query = "";

			//	query = String.Format("UPDATE FUNCIONARIO SET {0} = '{1}' WHERE ID_FUNCIONARIO = '{2}'", campo, valor, ID);

			//	var emptyTextboxes = from tb in this.Controls.OfType<TextBox>() where string.IsNullOrEmpty(tb.Text) select tb;

			//	if(emptyTextboxes.Any())
			//	{
			//		MessageBox.Show("Por favor tenha certeza de que todos os campos estão preenchidos.");
			//	}
			//	else
			//	{
			//		conexao = new ClasseConexao();
			//		ds = new DataSet();

			//		string check = string.Format("SELECT * FROM FUNCIONARIO WHERE ID_FUNCIONARIO = '{0}'", ID);
			//		ds = conexao.executarSQL(check);
			//		int qnt = 0;
			//		qnt = ds.Tables[0].Rows.Count;

			//		if(qnt > 0)
			//		{
			//			var confirm = MessageBox.Show("Tem certeza que deseja alterar o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
			//			if(confirm.Equals(DialogResult.Yes))
			//			{
			//				conexao = new ClasseConexao();
			//				ds = new DataSet();

			//				//MessageBox.Show(query);
			//				ds = conexao.executarSQL(query);
			//			}
			//			else
			//			{
			//				// If 'No', do something here.
			//			}
			//		}
			//		else
			//		{
			//			MessageBox.Show("Por favor escolha um registro válido");
			//		}
			//	}
			//}
			//catch(Exception) { }

			if (idFuncionario != 0)
			{
				FrmEditarFunc frm = new FrmEditarFunc(idFuncionario);
				frm.MdiParent = this.MdiParent;
				frm.Show();
				this.Hide();
				this.Dispose();
			}
			else
			{
				MessageBox.Show("Por favor selecione um funcionario da lista para poder alterar");
			}
		}

	//	conexao = new ClasseConexao();
	//	ds = new DataSet();
	//		try
	//		{
	//			String ID = txtID.Text;
	//	String query = String.Format("DELETE FROM FUNCIONARIO WHERE ID_FUNCIONARIO = '{0}'", ID);

	//			if (txtID.Text.Equals("") || txtID.Text.Equals(null))
	//			{
	//				MessageBox.Show("Por favor digite um ID para continuar");
	//			}
	//			else
	//			{
	//				string check = string.Format("SELECT * FROM FUNCIONARIO WHERE ID_FUNCIONARIO = '{0}'", ID);
	//ds = conexao.executarSQL(check);
	//				int qnt = 0;
	//qnt = ds.Tables[0].Rows.Count;

	//				if (qnt > 0) //se ja existe
	//				{
	//					var confirm = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
	//					if (confirm.Equals(DialogResult.Yes))
	//					{
	//						conexao = new ClasseConexao();
	//ds = new DataSet();

	////MessageBox.Show(query);
	//ds = conexao.executarSQL(query);
	//					}
	//					else
	//					{
	//						// If 'No', do something here.
	//					}
	//				}
	//				else //se nao existe
	//				{
	//					MessageBox.Show("Esse registro não existe!");
	//				}
	//			}
	//		}
	//		catch (Exception) { }
		
		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvFunc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			idFuncionario = (int) dgvFunc.Rows[e.RowIndex].Cells[0].Value;
		}
	}
}
