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
    public partial class FrmPrincipal : Form
    {
		Compartilha comp = new Compartilha();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{
			string nivel = comp.Nivel;
			string nome = comp.Nome;

			if (nivel.Equals("gerente", StringComparison.InvariantCultureIgnoreCase))
			{

			}
			else if (nivel.Equals("professor", StringComparison.InvariantCultureIgnoreCase))
			{
				alunoToolStripMenuItem.Visible = false;
				funcionárioToolStripMenuItem.Visible = false;
				cadastrarToolStripMenuItem1.Visible = false;
				cONSULToolStripMenuItem.Visible = false;
			}
			else
			{
				cadastrarToolStripMenuItem.Visible = false;
			}

			tslBV.Text = String.Format("Seja bem vindo(a) {0}", nome);
		}

		//botao sair
		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //botao log off
        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
			this.Dispose();
		}

		//MENU FUNCIONÁRIO--------------------------------------------------------------
        //botao cadastrar
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nao permite duas instancias do mesmo formulario
            if (Application.OpenForms.OfType<FrmCadastroFunc>().Count() > 0)
            {
				MessageBox.Show("O formulário já está aberto");
            }
            else
            {
                FrmCadastroFunc frmCadastroF = new FrmCadastroFunc();
				frmCadastroF.Show();
				frmCadastroF.MdiParent = this;
            }
        }

		//botao consultar
		private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if (Application.OpenForms.OfType<FrmConsultaFunc>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmConsultaFunc frmConsultaF = new FrmConsultaFunc();
				frmConsultaF.Show();
				frmConsultaF.MdiParent = this;
			}
		}

		//MENU ALUNO---------------------------------------------------------------------------------
		//botao caddastrar
		private void cadastrarMatricularToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if (Application.OpenForms.OfType<FrmCadastroAluno>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmCadastroAluno frmCadastroA = new FrmCadastroAluno();
				frmCadastroA.Show();
				frmCadastroA.MdiParent = this;
			}
		}

		//botao consultar
		private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if (Application.OpenForms.OfType<FrmConsultaAluno>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmConsultaAluno frmConsultaA = new FrmConsultaAluno();
				frmConsultaA.Show();
				frmConsultaA.MdiParent = this;
			}
		}

		//MENU PROFESSOR-----------------------------------------------------------------
		//botao cadastrar
		private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if (Application.OpenForms.OfType<FrmCadastroProf>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmCadastroProf frmCadastroP = new FrmCadastroProf();
				frmCadastroP.Show();
				frmCadastroP.MdiParent = this;
			}
		}

		//botao consultar
		private void cONSULToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if (Application.OpenForms.OfType<FrmConsultaProf>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmConsultaProf frmConsultaP = new FrmConsultaProf();
				frmConsultaP.Show();
				frmConsultaP.MdiParent = this;
			}
		}

		private void atividadesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if (Application.OpenForms.OfType<FrmAtividades>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmAtividades frmAtiv = new FrmAtividades();
				frmAtiv.Show();
				frmAtiv.MdiParent = this;
			}
		}

		private void notasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//nao permite duas instancias do mesmo formulario
			if (Application.OpenForms.OfType<FrmNotas>().Count() > 0)
			{
				MessageBox.Show("O formulário já está aberto");
			}
			else
			{
				FrmNotas frmNotas = new FrmNotas();
				frmNotas.Show();
				frmNotas.MdiParent = this;
			}
		}
	}
}
