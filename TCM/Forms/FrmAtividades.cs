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

		public FrmAtividades()
		{
			InitializeComponent();
		}

		private void formataGrid()
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
			dgvAtiv.DataSource = ds.Tables[0];
			formataGrid();
		}

		private void FrmAtividades_Load(object sender, EventArgs e)
		{
			String nivel = comp.Cargo;
			String id;

			grbCriar.Visible =  Cargo.ATIV_CRIAR;
			grbMod.Visible = Cargo.ATIV_EDIT;

			cmbCampo.Items.AddRange(ativ);
			cmbCampoMod.Items.AddRange(ativ);
			cmbCampoMod.Items.Remove("ID_ATIV");
			cmbCampoMod.Items.Remove("ID_PROFESSOR");

			lblCar.Text = "100";

			if(nivel.Equals("PROFESSOR"))
			{
				id = comp.Id;
			}
			else
			{
				id = "0";
			}

			Prova.select(int.Parse(id));
			Grid.atualizarGrid(Prova.Tabela, dgvAtiv);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			String nivel = comp.Cargo;
			String id = comp.Id;

			if (cmbCampo.SelectedItem.Equals("ID_PROFESSOR") && nivel.Equals("PROFESSOR"))
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

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			lblCar.Text = (100 - txtDesc.Text.Length).ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String nome = txtNome.Text;
			String desc = txtDesc.Text;
			String id = comp.Id;

			if (Checar.textbox(this) || desc.Trim().Length > 100)
			{
				MessageBox.Show("Por favor preencha o nome e a descrição, e tenha certeza que a descrição tenha menos de 100 caracteres");
			}
			else
			{
				conexao = new ClasseConexao();
				ds = new DataSet();

				string check = string.Format("SELECT * FROM ATIVIDADE WHERE NOME = '{0}'", nome);
				ds = conexao.executarSQL(check);
				int qnt = 0;
				qnt = ds.Tables[0].Rows.Count;

				if (qnt > 0) //se ja existe
				{
					MessageBox.Show("Essa atividade já existe nos registros");
				}
				else
				{
					conexao = new ClasseConexao();
					ds = new DataSet();

					String query = String.Format("INSERT INTO ATIVIDADE VALUES ('{0}','{1}', '{2}')", nome, desc, id);

					ds = conexao.executarSQL(query);

					String atl = String.Format("SELECT * FROM ATIVIDADE WHERE ID_PROFESSOR = '{0}'", id);
					atualizar_grid(atl);
				}
			}
		}

		private void dgvAtiv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtID.Text = dgvAtiv.Rows[e.RowIndex].Cells[0].Value.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();

			try
			{
				String ID = txtID.Text;
				String query = String.Format("DELETE FROM ATIVIDADE WHERE ID_ATIV = '{0}'", ID);

				if (txtID.Text.Equals("") || txtID.Text.Equals(null))
				{
					MessageBox.Show("Por favor digite um ID para continuar");
				}
				else
				{
					string check = string.Format("SELECT * FROM ATIVIDADE WHERE ID_ATIV = '{0}'", ID);
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

							String atl = String.Format("SELECT * FROM ATIVIDADE WHERE ID_PROFESSOR = '{0}'", comp.Id);
							atualizar_grid(atl);
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

		private void btnMod_Click(object sender, EventArgs e)
		{
			String ID = txtID.Text;
			String campo = cmbCampoMod.SelectedItem.ToString();
			String valor = txtValorMod.Text;
			String query = "";

			query = String.Format("UPDATE ATIVIDADE SET {0} = '{1}' WHERE ID_ATIV = '{2}'", campo, valor, ID);

			var emptyTextboxes = from tb in this.Controls.OfType<TextBox>() where string.IsNullOrEmpty(tb.Text) select tb;

			if (emptyTextboxes.Any())
			{
				MessageBox.Show("Por favor tenha certeza de que todos os campos estão preenchidos.");
			}
			else
			{
				conexao = new ClasseConexao();
				ds = new DataSet();

				string check = string.Format("SELECT * FROM ATIVIDADE WHERE ID_ATIV = '{0}'", ID);
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

						String atl = String.Format("SELECT * FROM ATIVIDADE WHERE ID_PROFESSOR = '{0}'", comp.Id);
						atualizar_grid(atl);
					}
					else
					{
						// If 'No', do something here.
					}
				}
				else
				{
					MessageBox.Show("Por favor escolha um registro válido");
				}
			}
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
