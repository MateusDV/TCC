using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
	public class Professor
	{
		ClasseConexao conexao;
		DataSet ds;

		public static int ID_Professor { get; private set; }

		public static String Nome { get; private set; }

		public static String Sexo { get; private set; }

		public static String RG { get; private set; }

		public static String CPF { get; private set; }

		public static String Rua { get; private set; }

		public static int Num { get; private set; }

		public static String Bairro { get; private set; }

		public static String Cep { get; private set; }

		public static String Cidade { get; private set; }

		public static String Estado { get; private set; }

		public static String Telefone { get; private set; }

		public static String Celular { get; private set; }

		public static String Email { get; private set; }

		public static String Senha { get; private set; }

		public bool login(String email, String senha, out String id, out String tipo)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();
			Compartilha comp = new Compartilha();

			string sql = String.Format("SELECT * FROM PROFESSOR WHERE EMAIL = '{0}' AND SENHA = '{1}'", email, senha);

			ds = conexao.executarSQL(sql);

			int conta = ds.Tables[0].Rows.Count;

			if (conta > 0)
			{
				id = ds.Tables[0].Rows[0]["ID_PROFESSOR"].ToString();
				tipo = "professor";
				comp.Nome = ds.Tables[0].Rows[0]["NOME"].ToString();
				return true;
			}
			else
			{
				id = "";
				tipo = "";
				return false;
			}
		}

		public static int insert(String nome, String sexo, String rg, String cpf, String rua, int numero, String bairro, String cep, String cidade, String estado, String fone, String cel, String email, String senha)
		{
			ClasseConexao conexao = new ClasseConexao();
			DataSet ds = new DataSet();

			int chec = 0;
			string check = string.Format("SELECT NOME FROM PROFESSOR WHERE NOME = '{0}'", nome);
			ds = conexao.executarSQL(check);
			int qnt = 0;
			qnt = ds.Tables[0].Rows.Count;

			if(qnt > 0) //se ja existe
			{
				MessageBox.Show("Esse professor já existe nos registros");
			}
			else //se nao existe
			{
				//MessageBox.Show(curso + "\n" + periodo);

				conexao = new ClasseConexao();
				ds = new DataSet();

				string sql = String.Format("INSERT INTO PROFESSOR VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', DEFAULT)", nome, sexo, rg, cpf, rua, numero, bairro, cep, cidade, estado, fone, cel, email, senha);
				//MessageBox.Show(sql);
				chec = conexao.executarSQLNonQuery(sql);
			}
			return chec;
		}
	}
}
