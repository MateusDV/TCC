using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
	public class Funcionario
	{
		ClasseConexao conexao;
		DataSet ds;

		public static int ID_Funcionario { get; private set; }

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

		public static String Cargo { get; private set; }

		public bool login(String email, String senha, out String id, out String tipo)
		{
			conexao = new ClasseConexao();
			ds = new DataSet();

			string sql = String.Format("SELECT * FROM FUNCIONARIO WHERE EMAIL = '{0}' AND SENHA = '{1}'", email, senha);

			ds = conexao.executarSQL(sql);

			int conta = ds.Tables[0].Rows.Count;

			if (conta > 0)
			{
				id = ds.Tables[0].Rows[0]["ID_FUNCIONARIO"].ToString();
				tipo = ds.Tables[0].Rows[0]["NOME"].ToString();
				return true;
			}
			else
			{
				id = "";
				tipo = "";
				return false;
			}
		}
	}
}
