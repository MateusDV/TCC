using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Forms
{
	public partial class FrmAlterarSenha : Form
	{
		public FrmAlterarSenha()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Compartilha comp = new Compartilha();

			string senha = textBox1.Text;

			if (textBox2.Text.Equals(textBox3.Text))
			{
				string Nsenha = textBox2.Text;
				int c = Funcionario.alterar_senha(int.Parse(comp.Id), comp.Cargo, senha, Nsenha);
				MessageBox.Show(c + "");
			}
			else
			{
				MessageBox.Show("As novas senhas não coincidem");
			}
		}
	}
}
