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
	public partial class FrmConsultaAluno : Form
	{
		private String[] Aln = { "NOME", "EMAIL", "SEXO", "RUA", "NUM", "CEP", "CIDADE", "ESTADO", "TELEFONE", "CURSO", "PERIODO" };
         
		private int idAluno;

		public FrmConsultaAluno()
		{
			InitializeComponent();
		}

		private void FrmConsultaAluno_Load(object sender, EventArgs e)
		{
			Grid.atualizarGrid(Aluno.Tabela, dgvAluno);

			cmbCampo.Items.AddRange(Aln);

			btnAlterar.Visible = Cargo.ALUNO_EDIT;
		}

		private void btnExibir_Click(object sender, EventArgs e)
		{
			Aluno.select(Checar.radioTag(grbExibir), checkBox1.Checked ? 0 : 1);
			Grid.atualizarGrid(Aluno.Tabela, dgvAluno);
		}

		private void btnPesquisa_Click(object sender, EventArgs e)
		{
			try
			{
				int exibe = Checar.radioTag(grbExibir);
				String campo = cmbCampo.SelectedItem.ToString();
				String valor = txtPesquisa.Text;

				Aluno.select(exibe, checkBox1.Checked ? 0 : 1, campo, valor);
				Grid.atualizarGrid(Aluno.Tabela, dgvAluno);
			}
			catch (Exception) { }
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	String ID = txtID.Text;
			//	String campo = cmbAltCampo.SelectedItem.ToString();
			//	String valor = txtAlt.Text;
			//	String query = "";
			//	bool IsValido;

			//	if (campo.Equals("CURSO"))
			//	{
			//		if (valor.ToUpper().Equals("BASICO"))
			//		{
			//			valor = "1";
			//			IsValido = true;
			//		}
			//		else if (valor.ToUpper().Equals("COMPLETO"))
			//		{
			//			valor = "2";
			//			IsValido = true;
			//		}
			//		else if (valor.ToUpper().Equals("EXPRESSO"))
			//		{
			//			valor = "3";
			//			IsValido = true;
			//		}
			//		else
			//		{
			//			IsValido = false;
			//		}
			//		query = String.Format("UPDATE ALUNO SET ID_CURSO = '{0}' WHERE ID_ALUNO = '{1}'", valor, ID);
			//	}
			//	else if (campo.Equals("PERIODO"))
			//	{
			//		if (valor.ToUpper().Equals("MANHA"))
			//		{
			//			valor = "1";
			//			IsValido = true;
			//		}
			//		else if (valor.ToUpper().Equals("TARDE"))
			//		{
			//			valor = "2";
			//			IsValido = true;
			//		}
			//		else if (valor.ToUpper().Equals("NOITE"))
			//		{
			//			valor = "3";
			//			IsValido = true;
			//		}
			//		else
			//		{
			//			IsValido = false;
			//		}
			//		query = String.Format("UPDATE ALUNO SET ID_PERIODO = '{0}' WHERE ID_ALUNO = '{1}'", valor, ID);
			//	}
			//	else
			//	{
			//		query = String.Format("UPDATE ALUNO SET {0} = '{1}' WHERE ID_ALUNO = '{2}'", campo, valor, ID);
			//		IsValido = true;
			//	}

			//	var emptyTextboxes = from tb in this.Controls.OfType<TextBox>() where string.IsNullOrEmpty(tb.Text) select tb;

			//	if (IsValido == false || emptyTextboxes.Any())
			//	{
			//		MessageBox.Show("Por favor digite o nome do curso e do período sem acentos, e tenha certeza de que todos os campos estão preenchidos.");
			//	}
			//	else
			//	{
			//		conexao = new ClasseConexao();
			//		ds = new DataSet();

			//		string check = string.Format("SELECT * FROM ALUNO WHERE ID_ALUNO = '{0}'", ID);
			//		ds = conexao.executarSQL(check);
			//		int qnt = 0;
			//		qnt = ds.Tables[0].Rows.Count;

			//		if (qnt > 0)
			//		{
			//			var confirm = MessageBox.Show("Tem certeza que deseja alterar o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
			//			if (confirm.Equals(DialogResult.Yes))
			//			{
			//				conexao = new ClasseConexao();

			//				//MessageBox.Show(query);
			//				conexao.executarSQL(query);
			//			}
			//		}
			//	}
			//}
			//catch (Exception) { }

			if (idAluno != 0)
			{
				FrmEditarAluno frm = new FrmEditarAluno(idAluno);
				frm.MdiParent = this.MdiParent;
				frm.Show();
				this.Hide();
				this.Dispose();
			}
			else
			{
				MessageBox.Show("Por favor selecione um aluno da lista para poder alterar");
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			//conexao = new ClasseConexao();
			//ds = new DataSet();
			//try
			//{
			//	String ID = txtID.Text;
			//	String query = String.Format("DELETE FROM ALUNO WHERE ID_ALUNO = '{0}'", ID);

			//	if (txtID.Text.Equals("") || txtID.Text.Equals(null))
			//	{
			//		MessageBox.Show("Por favor digite um ID para continuar");
			//	}
			//	else
			//	{
			//		string check = string.Format("SELECT * FROM ALUNO WHERE ID_ALUNO = '{0}'", ID);
			//		ds = conexao.executarSQL(check);
			//		int qnt = 0;
			//		qnt = ds.Tables[0].Rows.Count;

			//		if (qnt > 0) //se ja existe
			//		{
			//			var confirm = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
			//			if (confirm.Equals(DialogResult.Yes))
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
			//		else //se nao existe
			//		{
			//			MessageBox.Show("Esse registro não existe!");
			//		}
			//	}
			//}
			//catch (Exception) { }
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			idAluno = (int) dgvAluno.Rows[e.RowIndex].Cells[0].Value;
		}
	}
}
