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

		private string[] curso = { "Basico", "Intermediario", "Avancado", "Expresso" };
		private string[] perio = { "Manha", "Tarde", "Noite" };

		private string id_aluno;
		private string nome_aluno;

		private string id_prova;
		private string nome_prova;

		public FrmNotas()
		{
			InitializeComponent();
		}

		private void FrmNotas_Load(object sender, EventArgs e)
		{
			Compartilha comp = new Compartilha();

			if(!comp.Cargo.Equals("PROFESSOR"))
			{
				grbAdicionar.Visible = false;
			}

			cmbCurso.Items.AddRange(curso);
			cmbPeriodo.Items.AddRange(perio);
		}

		private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbCurso.SelectedIndex > 0 && cmbPeriodo.SelectedIndex > 0)
			{
				Turma.selectNome(cmbCurso.SelectedIndex, cmbPeriodo.SelectedIndex);

				for(int i = 0; i < Turma.Nomes.Rows.Count; i++)
				{
					cmbTurma.Items.Add(Turma.Nomes.Rows[i][0].ToString());
				}
			}
		}

		private void cmbTurma_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTurma.SelectedIndex > 0)
			{
				Turma.selectAlunos(cmbTurma.SelectedText);
				Grid.atualizarGrid(Turma.Alunos, dgvAlunos);
			}
		}

		private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			nome_aluno = dgvAluno.Rows[e.RowIndex].Cells[1].Value.ToString();

			Turma.selectAlunoEspec(nome_aluno);

			id_aluno = label21.Text = Turma.Alunos_Spec.Rows[0][0].ToString();
			label22.Text = Turma.Alunos_Spec.Rows[0][1].ToString();
			label23.Text = Turma.Alunos_Spec.Rows[0][2].ToString();
			label24.Text = Turma.Alunos_Spec.Rows[0][3].ToString();
			label25.Text = Turma.freq + "%";

			Nota.select_disp(int.Parse(id_aluno));
			Grid.atualizarGrid(Nota.Tabela_Atrib, dgvAtiv);
		}

		private void dgvAtiv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			label20.Text = nome_prova = dgvAtiv.Rows[e.RowIndex].Cells[0].Value.ToString();

			Prova.select("NOME", nome_prova);

			id_prova = Prova.Tabela.Rows[0][0].ToString();
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			try
			{
				int[] nota = new int[4];
				bool[] parse = new bool[4];
				bool[] valid = new bool[4];

				parse[0] = int.TryParse(txtListening.Text, out nota[0]);
				parse[1] = int.TryParse(txtReading.Text, out nota[1]);
				parse[2] = int.TryParse(txtSpeaking.Text, out nota[2]);
				parse[3] = int.TryParse(txtPerf.Text, out nota[3]);

				for(int i = 0; i < 4; i++)
				{
					valid[i] = Validar.nota(nota[i]);
				}

				if(Checar.textbox(this) || txtListening.Text.Length > 2 || parse.Any() == false || valid.Any() == false)
				{
					MessageBox.Show("Por favor tenha certeza de de todos os campos estejam preenchidos e de que a nota esteja no formato 00 (mínimo 0, máximo 10)");
				}
				else
				{
					var confirm = MessageBox.Show("Tem certeza que deseja adicionar essa nota? Lembre-se de que ela não poderá ser alterada depois.", "Por favor confirmar", MessageBoxButtons.YesNo);
					if(confirm.Equals(DialogResult.Yes))
					{
						int c = Nota.insert(int.Parse(id_prova), int.Parse(id_aluno), nota[0], nota[1], nota[2], nota[3]);

						MessageBox.Show(c + "");
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
