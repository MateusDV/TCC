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
		Cargo cargo = new Cargo();

		public FrmCargo()
		{
			InitializeComponent();
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

			int fun = cargo.insert(nome, aluno_cad, aluno_con, aluno_alt, prof_cad, prof_con, prof_alt, func_cad, func_con, func_alt, ativ_cri, ativ_con, ativ_alt, nota_atr, nota_con);

			MessageBox.Show(fun.ToString());
		}
	}
}
