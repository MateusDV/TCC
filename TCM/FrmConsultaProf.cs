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
	public partial class FrmConsultaProf : Form
	{
		ClasseConexao conexao;
		DataSet ds;

		private String[] Pes = { "ID_PROFESSOR", "NOME", "SEXO", "RG", "CPF" };
		private String[] Con = { "ID_PROFESSOR", "NOME", "EMAIL", "TELEFONE" };
		private String[] End = { "ID_PROFESSOR", "NOME", "RUA", "NUM", "CEP", "CIDADE", "ESTADO" };
		private String[] Prf = { "NOME", "SEXO", "RG", "CPF", "RUA", "NUM", "BAIRRO", "CEP", "CIDADE", "ESTADO", "TELEFONE", "CELULAR", "EMAIL" };

		public String[] getPes() { return Pes; }
		public String[] getCon() { return Con; }
		public String[] getEnd() { return End; }
		public String[] getPrf() { return Prf; }

		public FrmConsultaProf()
		{
			InitializeComponent();
		}

		private void formataGrid()
		{
			//permite personalizar o grid
			dgvProf.AutoGenerateColumns = true;
			dgvProf.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			dgvProf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			dgvProf.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			//altera a cor das linhas alternadas no grid
			dgvProf.RowsDefaultCellStyle.BackColor = Color.White;
			dgvProf.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			//altera o nome das colunas
			//dgvAluno.Columns[0].HeaderText = "ID";
			//dgvAluno.Columns[1].HeaderText = "NOME";
			//dgvAluno.Columns[2].HeaderText = "FONE";
			//dgvAluno.Columns[3].HeaderText = "NIVEL";
			//grid.Columns[3].HeaderText = "PREÇO UNITÁRIO";
			//dgvAluno.Columns[0].Width = 20;
			//dgvAluno.Columns[1].Width = 150;
			//dgvAluno.Columns[2].Width = 80;
			//dgvAluno.Columns[3].Width = 50;
			//formata a coluna para moeda (currency)
			//grid.Columns[3].DefaultCellStyle.Format = "c";
			//ao clicar, seleciona a linha inteira
			dgvProf.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//não permite seleção de multiplas linhas    
			dgvProf.MultiSelect = false;
			// exibe vazio no lugar de null
			//dgvAluno.DefaultCellStyle.NullValue = "";
			//Expande a célula automáticamente
			dgvProf.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			//alinha à direita os campos moeda
			//grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvProf.ReadOnly = true;
			dgvProf.RowHeadersVisible = false;
			dgvProf.AllowUserToAddRows = false;
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
			dgvProf.DataSource = ds.Tables[0];
			formataGrid();
		}

		private void FrmConsultaProf_Load(object sender, EventArgs e)
		{
			Compartilha comp = new Compartilha();
			string nivel = comp.Tipo;

			if (nivel.Equals("gerente", StringComparison.InvariantCultureIgnoreCase))
			{

			}
			else if (nivel.Equals("professor", StringComparison.InvariantCultureIgnoreCase))
			{

			}
			else
			{
				grbModificar.Visible = false;
			}

			atualizar_grid("");

			cmbExibe.Items.Add("Pessoais");
			cmbExibe.Items.Add("Contato");
			cmbExibe.Items.Add("Endereço");

			cmbAltCampo.Items.AddRange(getPrf());
		}

		private void btnExibir_Click(object sender, EventArgs e)
		{
			String query;
			if (rdbPessoais.Checked == true)
			{
				query = "SELECT ID_PROFESSOR AS ID, NOME, SEXO, RG, CPF FROM PROFESSOR";
			}
			else if (rdbContato.Checked == true)
			{
				query = "SELECT ID_PROFESSOR AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM PROFESSOR";
			}
			else if (rdbEnd.Checked == true)
			{
				query = "SELECT ID_PROFESSOR AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM PROFESSOR";
			}
			else
			{
				query = "";
				MessageBox.Show("Por favor selecione um modo de exibição.");
			}
			atualizar_grid(query);
		}

		private void cmbExibe_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbExibe.SelectedItem.Equals("Pessoais"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(getPes());
			}
			else if (cmbExibe.SelectedItem.Equals("Contato"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(getCon());
			}
			else if (cmbExibe.SelectedItem.Equals("Endereço"))
			{
				cmbCampo.Items.Clear();
				cmbCampo.Items.AddRange(getEnd());
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
				String query;
				String campo = cmbCampo.SelectedItem.ToString();
				String valor = txtPesquisa.Text;

				if (cmbExibe.SelectedItem.Equals("Pessoais"))
				{
					query = String.Format("SELECT ID_PROFESSOR AS ID, NOME, SEXO, RG, CPF FROM PROFESSOR WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else if (cmbExibe.SelectedItem.Equals("Contato"))
				{
					query = String.Format("SELECT ID_PROFESSOR AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM PROFESSOR WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else if (cmbExibe.SelectedItem.Equals("Endereço"))
				{
					query = String.Format("SELECT ID_PROFESSOR AS ID, NOME, RUA, NUM, CEP, BAIRRO, CIDADE, ESTADO FROM PROFESSOR WHERE {0} LIKE '{1}%'", campo, valor);
					//MessageBox.Show(query);
				}
				else
				{
					query = "";
					MessageBox.Show("Por favor selecione um modo de exibição");
				}
				atualizar_grid(query);
			}
			catch (Exception) { }
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			try
			{
				String ID = txtID.Text;
				String campo = cmbAltCampo.SelectedItem.ToString();
				String valor = txtAlt.Text;
				String query = "";

				query = String.Format("UPDATE PROFESSOR SET {0} = '{1}' WHERE ID_PROFESSOR = '{2}'", campo, valor, ID);

				var emptyTextboxes = from tb in this.Controls.OfType<TextBox>() where string.IsNullOrEmpty(tb.Text) select tb;

				if (emptyTextboxes.Any())
				{
					MessageBox.Show("Por favor tenha certeza de que todos os campos estão preenchidos.");
				}
				else
				{
					conexao = new ClasseConexao();
					ds = new DataSet();

					string check = string.Format("SELECT * FROM PROFESSOR WHERE ID_PROFESSOR = '{0}'", ID);
					ds = conexao.executarSQL(check);
					int qnt = 0;
					qnt = ds.Tables[0].Rows.Count;

					if (qnt > 0)
					{
						var confirm = MessageBox.Show("Tem certeza que deseja alterar o registro?", "Por favor confirmar", MessageBoxButtons.YesNo);
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
				}
			}
			catch (Exception) { }
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();
			try
			{
				String ID = txtID.Text;
				String query = String.Format("DELETE FROM PROFESSOR WHERE ID_PROFESSOR = '{0}'", ID);

				if (txtID.Text.Equals("") || txtID.Text.Equals(null))
				{
					MessageBox.Show("Por favor digite um ID para continuar");
				}
				else
				{
					string check = string.Format("SELECT * FROM PROFESSOR WHERE ID_PROFESSOR = '{0}'", ID);
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
