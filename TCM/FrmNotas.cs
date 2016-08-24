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
	public partial class FrmNotas : Form
	{
		ClasseConexao conexao;
		DataSet ds;
		Compartilha comp = new Compartilha();

		private String[] Tabela = {"Nota", "Aluno", "Atividade"};
		private String[] Nota = {"Id_Aluno", "Aluno", "Atividade", "Valor"};
		private String[] Aluno = { "Id_Aluno", "Nome" };
		private String[] Atividade = { "ID_Ativ", "Nome", "Descricao" };

		public FrmNotas()
		{
			InitializeComponent();
		}

		private void formataGrid_Nota()
		{
			//permite personalizar o grid
			dgvNotas.AutoGenerateColumns = true;
			dgvNotas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dgvNotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			//altera a cor das linhas alternadas no grid
			dgvNotas.RowsDefaultCellStyle.BackColor = Color.White;
			dgvNotas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			//ao clicar, seleciona a linha inteira
			dgvNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//não permite seleção de multiplas linhas    
			dgvNotas.MultiSelect = false;
			//Expande a célula automáticamente
			dgvNotas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			//read only
			dgvNotas.ReadOnly = true;
			dgvNotas.RowHeadersVisible = false;
			dgvNotas.AllowUserToAddRows = false;
		}

		private void atualizar_grid_nota(String sql)
		{
			if (sql.Equals(null) || sql.Equals(""))
			{
				//placeholder
				sql = "SELECT TOP 0 0";
			}
			conexao = new ClasseConexao();
			ds = new DataSet();
			ds = conexao.executarSQL(sql);
			dgvNotas.DataSource = ds.Tables[0];
			formataGrid_Nota();
		}

		private void formataGrid_Aluno()
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
			//Expande a célula automáticamente
			dgvAluno.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			//read only
			dgvAluno.ReadOnly = true;
			dgvAluno.RowHeadersVisible = false;
			dgvAluno.AllowUserToAddRows = false;
		}

		private void atualizar_grid_Aluno(String sql)
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
			formataGrid_Aluno();
		}

		private void formataGrid_Ativ()
		{
			//permite personalizar o grid
			dgvAtiv.AutoGenerateColumns = true;
			dgvAtiv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dgvAtiv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dgvAtiv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			//altera a cor das linhas alternadas no grid
			dgvAtiv.RowsDefaultCellStyle.BackColor = Color.White;
			dgvAtiv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			//ao clicar, seleciona a linha inteira
			dgvAtiv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//não permite seleção de multiplas linhas    
			dgvAtiv.MultiSelect = false;
			//Expande a célula automáticamente
			dgvAtiv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			//read only
			dgvAtiv.ReadOnly = true;
			dgvAtiv.RowHeadersVisible = false;
			dgvAtiv.AllowUserToAddRows = false;
		}

		private void atualizar_grid_Ativ(String sql)
		{
			if (sql.Equals(null) || sql.Equals(""))
			{
				//placeholder
				sql = "SELECT TOP 0 0";
			}
			conexao = new ClasseConexao();
			ds = new DataSet();
			ds = conexao.executarSQL(sql);
			dgvAtiv.DataSource = ds.Tables[0];
			formataGrid_Ativ();
		}

		private void FrmNotas_Load(object sender, EventArgs e)
		{
			cmbTabela.Items.AddRange(Tabela);

			String SelAluno = "SELECT ID_ALUNO AS ID, NOME FROM ALUNO";
			String SelAtiv;
			String SelNota;
			String nivel = comp.Nivel;

			if (nivel.Equals("professor", StringComparison.InvariantCultureIgnoreCase))
			{
				SelAtiv = String.Format("SELECT ID_ATIV AS ID, NOME, DESCRICAO FROM ATIVIDADE WHERE ID_PROFESSOR = '{0}'", comp.Id);
				SelNota = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME AS ALUNO, ATIVIDADE.NOME AS ATIVIDADE, NOTA.VALOR AS NOTA FROM ALUNO INNER JOIN NOTA ON ALUNO.ID_ALUNO = NOTA.ID_ALUNO INNER JOIN ATIVIDADE ON NOTA.ID_ATIV = ATIVIDADE.ID_ATIV WHERE ATIVIDADE.ID_PROFESSOR = '{0}'", comp.Id);
			}
			else
			{
				SelAtiv = "SELECT ID_ATIV AS ID, NOME, DESCRICAO FROM ATIVIDADE";
				SelNota = "SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME AS ALUNO, ATIVIDADE.NOME AS ATIVIDADE, NOTA.VALOR AS NOTA FROM ALUNO INNER JOIN NOTA ON ALUNO.ID_ALUNO = NOTA.ID_ALUNO INNER JOIN ATIVIDADE ON NOTA.ID_ATIV = ATIVIDADE.ID_ATIV";

				grbAdicionar.Visible = false;
			}

			atualizar_grid_Aluno(SelAluno);
			atualizar_grid_Ativ(SelAtiv);
			atualizar_grid_nota(SelNota);
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			try
			{
				String tabela = cmbTabela.SelectedItem.ToString();
				String campo = cmbCampo.SelectedItem.ToString();
				String valor = txtValor.Text;
				String query = "";

				if (tabela.Equals("Nota"))
				{
					if (cmbCampo.SelectedIndex == 1)
					{
						if (comp.Nivel.Equals("professor"))
						{
							query = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME AS ALUNO, ATIVIDADE.NOME AS ATIVIDADE, NOTA.VALOR AS NOTA FROM ALUNO INNER JOIN NOTA ON ALUNO.ID_ALUNO = NOTA.ID_ALUNO INNER JOIN ATIVIDADE ON NOTA.ID_ATIV = ATIVIDADE.ID_ATIV WHERE ATIVIDADE.ID_PROFESSOR = '{0}' AND ALUNO.NOME LIKE '{1}%'", comp.Id, valor);
						}
						else
						{
							query = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME AS ALUNO, ATIVIDADE.NOME AS ATIVIDADE, NOTA.VALOR AS NOTA FROM ALUNO INNER JOIN NOTA ON ALUNO.ID_ALUNO = NOTA.ID_ALUNO INNER JOIN ATIVIDADE ON NOTA.ID_ATIV = ATIVIDADE.ID_ATIV WHERE ALUNO.NOME LIKE '{0}%'", valor);
						}
					}
					else if (cmbCampo.SelectedIndex == 2)
					{
						if (comp.Nivel.Equals("professor"))
						{
							query = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME AS ALUNO, ATIVIDADE.NOME AS ATIVIDADE, NOTA.VALOR AS NOTA FROM ALUNO INNER JOIN NOTA ON ALUNO.ID_ALUNO = NOTA.ID_ALUNO INNER JOIN ATIVIDADE ON NOTA.ID_ATIV = ATIVIDADE.ID_ATIV WHERE ATIVIDADE.ID_PROFESSOR = '{0}' AND ATIVIDADE.NOME LIKE '{1}%'", comp.Id, valor);
						}
						else
						{
							query = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME AS ALUNO, ATIVIDADE.NOME AS ATIVIDADE, NOTA.VALOR AS NOTA FROM ALUNO INNER JOIN NOTA ON ALUNO.ID_ALUNO = NOTA.ID_ALUNO INNER JOIN ATIVIDADE ON NOTA.ID_ATIV = ATIVIDADE.ID_ATIV WHERE ATIVIDADE.NOME LIKE '{0}%'", valor);
						}
					}
					else
					{
						if (comp.Nivel.Equals("professor"))
						{
							query = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME AS ALUNO, ATIVIDADE.NOME AS ATIVIDADE, NOTA.VALOR AS NOTA FROM ALUNO INNER JOIN NOTA ON ALUNO.ID_ALUNO = NOTA.ID_ALUNO INNER JOIN ATIVIDADE ON NOTA.ID_ATIV = ATIVIDADE.ID_ATIV WHERE ATIVIDADE.ID_PROFESSOR = '{0}' AND NOTA.{1} LIKE '{2}%'", comp.Id, campo, valor);
						}
						else
						{
							query = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME AS ALUNO, ATIVIDADE.NOME AS ATIVIDADE, NOTA.VALOR AS NOTA FROM ALUNO INNER JOIN NOTA ON ALUNO.ID_ALUNO = NOTA.ID_ALUNO INNER JOIN ATIVIDADE ON NOTA.ID_ATIV = ATIVIDADE.ID_ATIV WHERE NOTA.{0} LIKE '{1}%'", campo, valor);
						}
					}
					atualizar_grid_nota(query);
				}
				else if (tabela.Equals("Aluno"))
				{
					query = String.Format("SELECT ID_ALUNO AS ID, NOME FROM ALUNO WHERE {0} LIKE '{1}%'", campo, valor);
					atualizar_grid_Aluno(query);
				}
				else if (tabela.Equals("Atividade"))
				{
					if (comp.Nivel.Equals("professor"))
					{
						query = String.Format("SELECT ID_ATIV AS ID, NOME, DESCRICAO FROM ATIVIDADE WHERE ID_PROFESSOR = '{0}' AND {1} LIKE '{2}%'", comp.Id, campo, valor);
					}
					else
					{
						query = String.Format("SELECT ID_ATIV AS ID, NOME, DESCRICAO FROM ATIVIDADE WHERE {0} LIKE '{1}%'", campo, valor);
					}
					atualizar_grid_Ativ(query);
				}
				else
				{
					MessageBox.Show("Por favor selecione uma tabela");
				}
			}
			catch(Exception) { }
		}

		private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtIDAluno.Text = dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
		}

		private void dgvAtiv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtIDAtiv.Text = dgvAtiv.Rows[e.RowIndex].Cells[0].Value.ToString();
		}

		private void cmbTabela_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbTabela.SelectedItem.Equals("Nota"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(Nota);
			}
			else if (cmbTabela.SelectedItem.Equals("Aluno"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(Aluno);
			}
			else if (cmbTabela.SelectedItem.Equals("Atividade"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(Atividade);
			}
			else
			{
				cmbCampo.Items.Clear();
			}
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			//conexao = new ClasseConexao();
			//ds = new DataSet();

			try
			{
				String ID_aluno = txtIDAluno.Text;
				String ID_ativ = txtIDAtiv.Text;
				int nota;
				bool parse = int.TryParse(txtNota.Text, out nota);

				bool n = Validar.nota(nota);

				var emptyTextboxes = from tb in this.Controls.OfType<TextBox>() where string.IsNullOrEmpty(tb.Text) select tb;

				var emptyMask = from mb in this.Controls.OfType<MaskedTextBox>() where string.IsNullOrEmpty(mb.Text) select mb;

				if (emptyTextboxes.Any() || emptyMask.Any() || txtNota.Text.Length > 4 || parse == false || n == false)
				{
					MessageBox.Show("Por favor tenha certeza de de todos os campos estejam preenchidos e de que a nota esteja no formato 00 (´mínimo 0, máximo 10");
				}
				else
				{
					conexao = new ClasseConexao();
					ds = new DataSet();

					String check = String.Format("SELECT * FROM NOTA WHERE ID_ALUNO = '{0}' AND ID_ATIV = '{1}'", ID_aluno, ID_ativ);
					ds = conexao.executarSQL(check);
					int qnt = 0;
					qnt = ds.Tables[0].Rows.Count;

					if (qnt > 0)
					{
						MessageBox.Show("Esse registro já existe!");
					}
					else
					{
						var confirm = MessageBox.Show("Tem certeza que deseja adicionar essa nota? Lembre-se de que ela não poderá ser alterada depois.", "Por favor confirmar", MessageBoxButtons.YesNo);
						if (confirm.Equals(DialogResult.Yes))
						{
							conexao = new ClasseConexao();
							ds = new DataSet();

							String query = String.Format("INSERT INTO NOTA VALUES('{0}', '{1}', '{2}')",ID_ativ, ID_aluno, nota);
							//MessageBox.Show(query);
							ds = conexao.executarSQL(query);

							String att = String.Format("SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME AS ALUNO, ATIVIDADE.NOME AS ATIVIDADE, NOTA.VALOR AS NOTA FROM ALUNO INNER JOIN NOTA ON ALUNO.ID_ALUNO = NOTA.ID_ALUNO INNER JOIN ATIVIDADE ON NOTA.ID_ATIV = ATIVIDADE.ID_ATIV WHERE ATIVIDADE.ID_PROFESSOR = '{0}'", comp.Id);
							atualizar_grid_nota(att);
						}
						else
						{
							// If 'No', do something here.
						}
					}
				}
			}
			catch(Exception) { }
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
