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
		ClasseConexao conexao;
		DataSet ds;

		private String[] Pes = { "ID_ALUNO", "NOME", "SEXO", "CURSO", "PERIODO" };
		private String[] Con = { "ID_ALUNO", "NOME", "EMAIL", "TELEFONE" };
		private String[] End = { "ID_ALUNO", "NOME", "RUA", "NUM", "CEP", "CIDADE", "ESTADO" };
		private String[] Aln = { "NOME", "EMAIL", "SEXO", "RUA", "NUM", "CEP", "CIDADE", "ESTADO", "TELEFONE", "CURSO", "PERIODO" };

		public FrmConsultaAluno()
		{
			InitializeComponent();
		}

		private void formataGrid()
		{
			//permite personalizar o grid
			dgvAluno.AutoGenerateColumns = true;
			dgvAluno.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dgvAluno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dgvAluno.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			//altera a cor das linhas alternadas no grid
			dgvAluno.RowsDefaultCellStyle.BackColor = Color.White;
			dgvAluno.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			//ao clicar, seleciona a linha inteira
			dgvAluno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//não permite seleção de multiplas linhas    
			dgvAluno.MultiSelect = false;
			// exibe vazio no lugar de null
			//dgvAluno.DefaultCellStyle.NullValue = "";
			//Expande a célula automáticamente
			dgvAluno.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			//alinha à direita os campos moeda
			//grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAluno.ReadOnly = true;
			dgvAluno.RowHeadersVisible = false;
			dgvAluno.AllowUserToAddRows = false;
		}

		private void atualizar_grid(String sql)
		{
			if (sql.Equals(null) || sql.Equals(""))
			{
				//placeholder
				sql = "SELECT TOP 0 0";
			}
			conexao = new ClasseConexao();
			ds = new DataSet();
			ds = conexao.executarSQL(sql);
			dgvAluno.DataSource = ds.Tables[0];
			formataGrid();
		}

		private void FrmConsultaAluno_Load(object sender, EventArgs e)
		{
			atualizar_grid("");

			cmbExibe.Items.Add("Pessoais");
			cmbExibe.Items.Add("Contato");
			cmbExibe.Items.Add("Endereço");

			cmbAltCampo.Items.AddRange(Aln);

			txtID.Enabled = false;
			cmbAltCampo.Enabled = false;
			txtAlt.Enabled = false;
			btnExcluir.Enabled = false;
		}

		private void btnExibir_Click(object sender, EventArgs e)
		{
			Aluno.select(Checar.radioTag(grbExibir));
			Grid.atualizarGrid(Aluno.Tabela, dgvAluno);
		}

		private void cmbExibe_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbExibe.SelectedItem.Equals("Pessoais"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(Pes);
			}
			else if (cmbExibe.SelectedItem.Equals("Contato"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(Con);
			}
			else if (cmbExibe.SelectedItem.Equals("Endereço"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(End);
			}
			else
			{
				cmbCampo.Items.Clear();
			}
		}

		private void btnPesquisa_Click(object sender, EventArgs e)
		{
			try
			{
				int exibe = cmbExibe.SelectedIndex + 1;
				String campo = cmbCampo.SelectedItem.ToString();
				String valor = txtPesquisa.Text;

				Aluno.select(exibe, campo, valor);
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

			FrmEditarAluno frm = new FrmEditarAluno(1);
			frm.MdiParent = this.MdiParent;
			frm.Show();
			this.Hide();
			this.Dispose();

		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();
			try
			{
				String ID = txtID.Text;
				String query = String.Format("DELETE FROM ALUNO WHERE ID_ALUNO = '{0}'", ID);

				if (txtID.Text.Equals("") || txtID.Text.Equals(null))
				{
					MessageBox.Show("Por favor digite um ID para continuar");
				}
				else
				{
					string check = string.Format("SELECT * FROM ALUNO WHERE ID_ALUNO = '{0}'", ID);
					ds = conexao.executarSQL(check);
					int qnt = 0;
					qnt = ds.Tables[0].Rows.Count;

					if (qnt > 0) //se ja existe
					{
						var confirm = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
						if (confirm.Equals(DialogResult.Yes))
						{
							conexao = new ClasseConexao();
							ds = new DataSet();

							//MessageBox.Show(query);
							ds = conexao.executarSQL(query);
						}
						else
						{
							// If 'No', do something here.
						}
					}
					else //se nao existe
					{
						MessageBox.Show("Esse registro não existe!");
					}
				}
			}
			catch (Exception) { }
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
