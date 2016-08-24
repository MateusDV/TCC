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
	public partial class FrmCadastroAluno : Form
	{
		ClasseConexao conexao;
		DataSet ds;

		public FrmCadastroAluno()
		{
			InitializeComponent();
		}

		private void FrmCadastroAluno_Load(object sender, EventArgs e)
		{
			cmbSexo.Items.Add("M");
			cmbSexo.Items.Add("F");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();

            try
            {
                //Variáveis referentes aos controles do formulario
                String nome = txtNome.Text;
                String email = txtEmail.Text;
                String sexo = cmbSexo.SelectedItem.ToString();
                String senha = txtSenha.Text;
                String rua = txtRua.Text;
                int numero = int.Parse(txtNum.Text);
                String cep = txtCEP.Text;
                String cidade = txtCidade.Text;
                String estado = txtEstado.Text;
                String telefone = txtTelefone.Text;
                int curso;
                int periodo;

                //checa qual radio button está selecionado
                var rCurso = grbCurso.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault();
                if (rCurso == null)
                {
                    curso = 0;
                    //MessageBox.Show("Por favor selecione um curso");
                }
                else
                {
                    curso = int.Parse(rCurso.Tag.ToString());  
                }

                var rPeriodo = grbPeriodo.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault();
                if (rPeriodo == null)
                {
                    periodo = 0;
                    //MessageBox.Show("Por favor selecione um período");
                }
                else
                {
                    periodo = int.Parse(rPeriodo.Tag.ToString());
                }

				//checa se os textbox, maskedtextbox estao vazios
				var emptyTextboxes = from tb in this.Controls.OfType<TextBox>()where string.IsNullOrEmpty(tb.Text)select tb;

				var emptyMask = from mb in this.Controls.OfType<MaskedTextBox>() where string.IsNullOrEmpty(mb.Text) select mb;

				if (emptyTextboxes.Any() || emptyMask.Any() || rCurso == null || rPeriodo == null)
				{
					MessageBox.Show("Por favor preencha todos os campos e selecione as opções apropriadas");
				}
				else
				{
					//checa o nome para ver se já nao existe
					string check = string.Format("SELECT NOME FROM ALUNO WHERE NOME = '{0}'", nome);
					ds = conexao.executarSQL(check);
					int qnt = 0;
					qnt = ds.Tables[0].Rows.Count;

					if (qnt > 0) //se ja existe
					{
						MessageBox.Show("Esse aluno já existe nos registros");
					}
					else //se nao existe
					{
						//MessageBox.Show(curso + "\n" + periodo);

						conexao = new ClasseConexao();
						ds = new DataSet();

						string sql = string.Format("INSERT INTO ALUNO VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}', {10}, {11})", nome, email, sexo, senha, rua, numero, cep, cidade, estado, telefone, curso, periodo);
						//MessageBox.Show(sql);
						ds = conexao.executarSQL(sql);
					}
				}
            }
            catch (Exception)
            {
				
            }
        }

		private void button2_Click(object sender, EventArgs e)
		{
			Limpar.ClearAllText(this);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			txtNome.Text = "Joao Carlos Magalhaes";
			cmbSexo.Text = "M";
			txtEmail.Text = "joaoCM@gmail.com";
			txtSenha.Text = "12345";
			txtRua.Text = "Marcos Silva";
			txtNum.Text = "321";
			txtCEP.Text = "04146001";
			txtCidade.Text = "Sao Paulo";
			txtEstado.Text = "Sao Paulo";
			txtTelefone.Text = "01184121357";
			rdbBasico.Checked = true;
			rdbT.Checked = true;
		}
	}
}