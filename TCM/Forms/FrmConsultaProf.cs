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
		private int idProfessor;

		private String[] Prf = { "NOME", "SEXO", "RG", "CPF", "RUA", "NUM", "BAIRRO", "CEP", "CIDADE", "ESTADO", "TELEFONE", "CELULAR", "EMAIL" };

		public FrmConsultaProf()
		{
			InitializeComponent();
		}

		private void FrmConsultaProf_Load(object sender, EventArgs e)
		{
			cmbCampo.Items.AddRange(Prf);
			btnAlterar.Visible = Cargo.PROF_EDIT;
		}

		private void btnExibir_Click(object sender, EventArgs e)
		{
			Professor.select(Checar.radioTag(grbExibir), checkBox1.Checked ? 0 : 1);
			Grid.atualizarGrid(Professor.Tabela, dgvProf);
		}

		private void btnPesquisa_Click(object sender, EventArgs e)
		{
			try
			{
				String campo = cmbCampo.SelectedItem.ToString();
				String valor = txtPesquisa.Text;
				int tipo = Checar.radioTag(grbExibir);

				Professor.select(tipo, checkBox1.Checked ? 0 : 1, campo, valor);
				Grid.atualizarGrid(Professor.Tabela, dgvProf);
			}
			catch(Exception) { }
		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{
			if (idProfessor != 0)
			{
				FrmEditarProf frm = new FrmEditarProf(idProfessor);
				frm.MdiParent = this.MdiParent;
				frm.Show();
				this.Hide();
				this.Dispose();
			}
			else
			{
				MessageBox.Show("Por favor selecione um professor da lista para poder alterar");
			}
		}

		private void dgvProf_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			idProfessor = (int)dgvProf.Rows[e.RowIndex].Cells[0].Value;
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
