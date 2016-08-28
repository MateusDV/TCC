using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
	public class Aluno
	{
		ClasseConexao conexao;
		DataSet ds;

		public static int ID_Aluno { get; private set; }

		public static String Nome { get; private set; }

		public static String Email { get; private set; }

		public static String Sexo { get; private set; }

		public static String Senha { get; private set; }

		public static String Rua {	get; private set; }

		public static int Num { get; private set; }

		public static String Cep { get; private set; }

		public static String Cidade { get; private set; }

		public static String Estado { get; private set; }

		public static String Telefone { get; private set; }

		public static int insert(String nome, String email, String sexo, String senha, String rua, int numero, String cep, String cidade, String estado, String telefone)
		{
			ClasseConexao conexao = new ClasseConexao();

			int chec = 0;

			string check = string.Format("SELECT NOME FROM ALUNO WHERE NOME = '{0}'", nome);
			DataSet ds = conexao.executarSQL(check);
			int qnt = 0;
			qnt = ds.Tables[0].Rows.Count;

			if(qnt > 0) //se ja existe
			{
				MessageBox.Show("Esse aluno já existe nos registros");
			}
			else //se nao existe
			{
				//MessageBox.Show(curso + "\n" + periodo);

				conexao = new ClasseConexao();
				ds = new DataSet();

				string sql = string.Format("INSERT INTO ALUNO OUTPUT inserted.ID_ALUNO VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}', DEFAULT)", nome, email, sexo, senha, rua, numero, cep, cidade, estado, telefone);
				//MessageBox.Show(sql);
				ds = conexao.executarSQL(sql);
				chec = (int) ds.Tables[0].Rows[0]["ID_ALUNO"];
			};
			return chec;
		}
	}
}
