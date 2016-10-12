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
    public partial class FrmLogin : Form
    {
		Funcionario func = new Funcionario();
		Professor prof = new Professor();

        public FrmLogin()
        {
            InitializeComponent();
        }

        //faz a combinaçao alt+f4 se desabilitar
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

		//botao login
		private void btnLogin_Click(object sender, EventArgs e)
        {
			Compartilha comp = new Compartilha();

			string email = txtUser.Text;
			string senha = txtPass.Text;
            //string id = "";
            //string tipo = "";

			if (func.login(email, senha))
			{
				this.Hide();
				FrmPrincipal frmPrincipal = new FrmPrincipal();
				frmPrincipal.Show();
			}
			else
			{
				MessageBox.Show("Usuário ou senha incorretos");
			}
		}

        //botao cancelar
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Sai da aplicacao
        }

		private void txtPass_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin.PerformClick();
				// these last two lines will stop the beep sound
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}
	}
}
