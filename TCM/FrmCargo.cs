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
	public partial class FrmCargo : Form
	{
		private int isloaded = 0;
		public FrmCargo()
		{
			InitializeComponent();
		}

		private void atualizar()
		{
			Cargo.select();

			if(isloaded > 0)
			{
				comboBox1.Items.Clear();
			}

			comboBox1.Items.Add("Novo");
			for(int i = 0; i < Cargo.Tabela.Rows.Count; i++)
			{
				comboBox1.Items.Add(Cargo.Tabela.Rows[i]["NOME"].ToString());
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String nome = textBox1.Text;
			Boolean aluno_cad = checkBox1.Checked;
			Boolean aluno_con = checkBox2.Checked;
			Boolean aluno_alt = checkBox3.Checked;
			Boolean prof_cad = checkBox4.Checked;
			Boolean prof_con = checkBox5.Checked;
			Boolean prof_alt = checkBox6.Checked;
			Boolean func_cad = checkBox7.Checked;
			Boolean func_con = checkBox8.Checked;
			Boolean func_alt = checkBox9.Checked;
			Boolean ativ_cri = checkBox10.Checked;
			Boolean ativ_con = checkBox11.Checked;
			Boolean ativ_alt = checkBox12.Checked;
			Boolean nota_atr = checkBox13.Checked;
			Boolean nota_con = checkBox14.Checked;

			int fun = Cargo.insert(nome, aluno_cad, aluno_con, aluno_alt, prof_cad, prof_con, prof_alt, func_cad, func_con, func_alt, ativ_cri, ativ_con, ativ_alt, nota_atr, nota_con);
			Limpar.ClearAllText(this);
			atualizar();

			MessageBox.Show(fun.ToString());
		}

		private void FrmCargo_Load(object sender, EventArgs e)
		{
			button5.Visible = false;
			atualizar();
			isloaded = 1;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int ind = comboBox1.SelectedIndex;

			if (ind > 0)
			{
				Cargo.select(ind.ToString());

				button1.Visible = false;
				button5.Visible = true;

				textBox1.Text = Cargo.Nome;
				checkBox1.Checked = Cargo.ALUNO_CADS;
				checkBox2.Checked = Cargo.ALUNO_CONS;
				checkBox3.Checked = Cargo.ALUNO_EDIT;
				checkBox4.Checked = Cargo.PROF_CADS;
				checkBox5.Checked = Cargo.PROF_CONS;
				checkBox6.Checked = Cargo.PROF_EDIT;
				checkBox7.Checked = Cargo.FUNC_CADS;
				checkBox8.Checked = Cargo.FUNC_CONS;
				checkBox9.Checked = Cargo.FUNC_EDIT;
				checkBox10.Checked = Cargo.ATIV_CRIAR;
				checkBox11.Checked = Cargo.ATIV_CONS;
				checkBox12.Checked = Cargo.ATIV_EDIT;
				checkBox13.Checked = Cargo.NOTA_ATRIB;
				checkBox14.Checked = Cargo.NOTA_CONS;
			}
			else
			{
				Limpar.ClearAllText(this);
				button1.Visible = true;
				button5.Visible = false;
			}

		}

		private void button5_Click(object sender, EventArgs e)
		{
			String nome = textBox1.Text;
			Boolean aluno_cad = checkBox1.Checked;
			Boolean aluno_con = checkBox2.Checked;
			Boolean aluno_alt = checkBox3.Checked;
			Boolean prof_cad = checkBox4.Checked;
			Boolean prof_con = checkBox5.Checked;
			Boolean prof_alt = checkBox6.Checked;
			Boolean func_cad = checkBox7.Checked;
			Boolean func_con = checkBox8.Checked;
			Boolean func_alt = checkBox9.Checked;
			Boolean ativ_cri = checkBox10.Checked;
			Boolean ativ_con = checkBox11.Checked;
			Boolean ativ_alt = checkBox12.Checked;
			Boolean nota_atr = checkBox13.Checked;
			Boolean nota_con = checkBox14.Checked;
			int id = comboBox1.SelectedIndex;

			int fun = Cargo.update(nome, aluno_cad, aluno_con, aluno_alt, prof_cad, prof_con, prof_alt, func_cad, func_con, func_alt, ativ_cri, ativ_con, ativ_alt, nota_atr, nota_con, id);
			Limpar.ClearAllText(this);
			atualizar();
			MessageBox.Show(fun.ToString());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
